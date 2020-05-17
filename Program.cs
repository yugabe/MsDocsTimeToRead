using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;

namespace MsDocsTimeToRead
{
    public class Program
    {
        public static async Task Main() =>
            await new HostBuilder()
                .ConfigureWebHost(h =>
                    h.UseKestrel()
                     .ConfigureServices(s =>
                         s.AddSingleton<LinksService>()
                          .AddRazorPages())
                     .Configure(a =>
                         a.UseRouting()
                          .UseEndpoints(e =>
                              e.MapRazorPages())))
                .Build()
                .StartAsync();
    }
}
