using HtmlAgilityPack;
using HtmlAgilityPack.CssSelectors.NetCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MsDocsTimeToRead
{
    public class LinksService
    {
        public async Task<IEnumerable<Link>> GetLinksAsync(string baseAddress, string tocJsonAddress)
        {
            using var client = new HttpClient() { BaseAddress = new Uri(baseAddress) };
            Directory.CreateDirectory("Cache");
            var response = await JsonSerializer.DeserializeAsync<TocResponse>(new MemoryStream(Encoding.UTF8.GetBytes(await GetStringOrCachedAsync(tocJsonAddress))));
            var sitesToCrawl = response.Items.Flatten(i => i.Children).Where(i => i.item.Href != null).ToList().AsEnumerable();
            if (sitesToCrawl.All(i => i.item.TimeToRead == null))
            {
                while (sitesToCrawl.Any())
                {
                    await Task.WhenAll(sitesToCrawl.Take(50).Select(async i =>
                    {
                        var document = new HtmlDocument();
                        document.LoadHtml(await GetStringOrCachedAsync(i.item.Href!));
                        i.item.TimeToRead = int.TryParse(document.QuerySelector(".readingTime")?.InnerText?.Split()?.FirstOrDefault(), out var readingTime) ? readingTime : (int?)null;
                    }));
                    sitesToCrawl = sitesToCrawl.Skip(50);
                }
                using var cacheFileStream = File.Create(GetCacheFileName(tocJsonAddress));
                await JsonSerializer.SerializeAsync(cacheFileStream, response);
            }

            return response.Items;

            static string GetCacheFileName(string url) => $"Cache\\{url.Aggregate(23, (acc, c) => acc * 31 + c)}.dat";

            async Task<string> GetStringOrCachedAsync(string url)
            {
                var cachedResult = new FileInfo(GetCacheFileName(url));
                if (cachedResult.Exists)
                    return File.ReadAllText(cachedResult.FullName);

                var result = await client.GetAsync(url);
                if (result.IsSuccessStatusCode)
                {
                    using var cacheWriter = cachedResult.OpenWrite();
                    await result.Content.CopyToAsync(cacheWriter);
                }
                return await result.Content.ReadAsStringAsync();
            }
        }
    }
}
