# 🔒🗄️ Archived Project 🗄️🔒

This project was made for fun, to solve a crawling "problem" and see how long it would allegedly take based on the estimates by the automation to read (not *comprehend* or *learn*) through the docs on the Microsoft Learn website. The crawler would pull all pages and extract the estimated time from the HTML and grouped the results. It was a fun experiment to compare various parts of the docs against each other.

Unfortunately, the Docs (*née Learn*) website no longer publishes this information, so it's unavailable to crawl. This repo is thus archived for reference, and you can still see the original results I gathered at the bottom of this page, which reflect the data as it was on May 17, 2020.

-----

# MsDocsTimeToRead
This application is a very simple ASP.NET Core application, which crawls and outputs a generated Razor Page, which shows how much time is needed to read through the full [ASP.NET Core Docs](https://docs.microsoft.com/en-us/aspnet/core/). I was interested primarily in how much time it would take to learn [Blazor](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor) A-Z, so I decided to calculate it programatically. It was just one more step to calculate it for the entire documentation site. As it turns out, if you concentrate on reading through the docs, <b>you can learn Blazor in about 368 minutes</b>, so less than a full workday! The entire documentation site takes 5691 minutes, which means <b>you can be adept in all things ASP.NET Core in 3 days, 22 hours and 51 minutes</b>!

## Disclaimer
<b>Obviously, this is just a rough indicator on how much time it takes to read through the docs.</b> From my experience, you can get started with Blazor in just a few days, it's really impressive! Reading through the docs won't make you a pro, nor being a pro makes you know everything that's written in the docs. These numbers can give you an indication based on your prior experiences. Consider using a multiplier, eg. 5-10x, that you should calculate with when wanting to take a deep dive in any of the topics.

If you like this app or consider the results useful or fun, please, don't forget to star this repository! Thank you.

## Caution!
<b>This app crawls all links in the site contents of the docs! Please do not use it if you just want to just see the results. They are available below.</b>

## Running the app
After cloning the app and starting it, it will crawl all known URLs by looking at the table of contents on the documentation page available at https://docs.microsoft.com/en-us/aspnet/core/toc.json?view=aspnetcore-5.0. It will cache all results in the Cache directory. Running after the cache is build, it won't use crawling.

## Results
The results are avaiable below, which represent the state available on May 17, 2020. It takes about 20 seconds to crawl all pages and get the data which shows how many minutes it takes generally to read through each article. The articles have a metadata section which show this information, probably using the size of the page or some machine learning algorithms. You can see the generated results table below.

<table>
    <thead>
        <tr>
            <th colspan="5">Title</th>
            <th>Children</th>
            <th>Min</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td colspan="7"><b>Total time to read: 5691</b></td>
        </tr>
            <tr>
                <td colspan="5">ASP.NET Core documentation</td>
                <td><b></b></td>
                <td></td>
            </tr>
            <tr>
                <td colspan="5">What's new in ASP.NET Core docs</td>
                <td><b></b></td>
                <td></td>
            </tr>
            <tr>
                <td colspan="5">Overview</td>
                <td><b>16</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">About ASP.NET Core</td>
                <td><b></b></td>
                <td>8</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Compare ASP.NET Core and ASP.NET</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Compare .NET Core and .NET Framework</td>
                <td><b></b></td>
                <td>6</td>
            </tr>
            <tr>
                <td colspan="5">Get started</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                <td colspan="5">Release notes</td>
                <td><b>34</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">What's new in 3.1</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">What's new in 3.0</td>
                <td><b></b></td>
                <td>14</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">What's new in 2.2</td>
                <td><b></b></td>
                <td>5</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">What's new in 2.1</td>
                <td><b></b></td>
                <td>6</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">What's new in 2.0</td>
                <td><b></b></td>
                <td>5</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">What's new in 1.1</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                <td colspan="5">Tutorials</td>
                <td><b>743</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Web apps</td>
                <td><b>217</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Razor Pages</td>
                <td><b>99</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Overview</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Get started</td>
                <td><b></b></td>
                <td>10</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Add a model</td>
                <td><b></b></td>
                <td>22</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Scaffolding</td>
                <td><b></b></td>
                <td>16</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Work with a database</td>
                <td><b></b></td>
                <td>12</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Update the pages</td>
                <td><b></b></td>
                <td>9</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Add search</td>
                <td><b></b></td>
                <td>9</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Add a new field</td>
                <td><b></b></td>
                <td>10</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Add validation</td>
                <td><b></b></td>
                <td>9</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">MVC</td>
                <td><b>110</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Overview</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Get started</td>
                <td><b></b></td>
                <td>10</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Add a controller</td>
                <td><b></b></td>
                <td>12</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Add a view</td>
                <td><b></b></td>
                <td>16</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Add a model</td>
                <td><b></b></td>
                <td>28</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Work with a database</td>
                <td><b></b></td>
                <td>9</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Controller actions and views</td>
                <td><b></b></td>
                <td>9</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Add search</td>
                <td><b></b></td>
                <td>7</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Add a new field</td>
                <td><b></b></td>
                <td>5</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Add validation</td>
                <td><b></b></td>
                <td>9</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Examine the Details and Delete methods</td>
                <td><b></b></td>
                <td>3</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Blazor</td>
                <td><b></b></td>
                <td>8</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Web API apps</td>
                <td><b>65</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Create a web API</td>
                <td><b></b></td>
                <td>31</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Web API with MongoDB</td>
                <td><b></b></td>
                <td>21</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Web API with JavaScript</td>
                <td><b></b></td>
                <td>5</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Backend for mobile</td>
                <td><b></b></td>
                <td>8</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Real-time web apps</td>
                <td><b>41</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">SignalR with JavaScript</td>
                <td><b></b></td>
                <td>13</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">SignalR with TypeScript</td>
                <td><b></b></td>
                <td>21</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">SignalR with Blazor WebAssembly</td>
                <td><b></b></td>
                <td>7</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Remote Procedure Call apps</td>
                <td><b>9</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Get started with a gRPC service</td>
                <td><b></b></td>
                <td>9</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Data access</td>
                <td><b>411</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">EF Core with Razor Pages</td>
                <td><b>247</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Get started</td>
                <td><b></b></td>
                <td>32</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Create, Read, Update, and Delete</td>
                <td><b></b></td>
                <td>22</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Sort, filter, page, and group</td>
                <td><b></b></td>
                <td>29</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Migrations</td>
                <td><b></b></td>
                <td>11</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Create a complex data model</td>
                <td><b></b></td>
                <td>57</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Read related data</td>
                <td><b></b></td>
                <td>28</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Update related data</td>
                <td><b></b></td>
                <td>32</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Handle concurrency conflicts</td>
                <td><b></b></td>
                <td>36</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">EF Core with MVC</td>
                <td><b>164</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Overview</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Get started</td>
                <td><b></b></td>
                <td>21</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Create, Read, Update, and Delete</td>
                <td><b></b></td>
                <td>19</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Sort, filter, page, and group</td>
                <td><b></b></td>
                <td>14</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Migrations</td>
                <td><b></b></td>
                <td>7</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Create a complex data model</td>
                <td><b></b></td>
                <td>30</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Read related data</td>
                <td><b></b></td>
                <td>14</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Update related data</td>
                <td><b></b></td>
                <td>18</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Handle concurrency conflicts</td>
                <td><b></b></td>
                <td>18</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Inheritance</td>
                <td><b></b></td>
                <td>8</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Advanced topics</td>
                <td><b></b></td>
                <td>13</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Microsoft Learn modules</td>
                <td><b>0</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Web apps &gt;&gt;</td>
                <td><b></b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Web API apps &gt;&gt;</td>
                <td><b></b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Data access &gt;&gt;</td>
                <td><b></b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Web app security &gt;&gt;</td>
                <td><b></b></td>
                <td></td>
            </tr>
            <tr>
                <td colspan="5">Fundamentals</td>
                <td><b>474</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Overview</td>
                <td><b></b></td>
                <td>17</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">The Startup class</td>
                <td><b></b></td>
                <td>13</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Dependency injection (services)</td>
                <td><b></b></td>
                <td>34</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Middleware</td>
                <td><b></b></td>
                <td>21</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Host</td>
                <td><b>49</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Generic Host</td>
                <td><b></b></td>
                <td>32</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Web Host</td>
                <td><b></b></td>
                <td>17</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Servers</td>
                <td><b></b></td>
                <td>7</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Configuration</td>
                <td><b></b></td>
                <td>57</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Options</td>
                <td><b></b></td>
                <td>38</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Environments (dev, stage, prod)</td>
                <td><b></b></td>
                <td>20</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Logging</td>
                <td><b></b></td>
                <td>55</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Routing</td>
                <td><b></b></td>
                <td>102</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Handle errors</td>
                <td><b></b></td>
                <td>8</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Make HTTP requests</td>
                <td><b></b></td>
                <td>45</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Static files</td>
                <td><b></b></td>
                <td>8</td>
            </tr>
            <tr>
                <td colspan="5">Web apps</td>
                <td><b>1289</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Razor Pages</td>
                <td><b>185</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Introduction</td>
                <td><b></b></td>
                <td>43</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Tutorial</td>
                <td><b>99</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Overview</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Get started</td>
                <td><b></b></td>
                <td>10</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Add a model</td>
                <td><b></b></td>
                <td>22</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Scaffolding</td>
                <td><b></b></td>
                <td>16</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Work with a database</td>
                <td><b></b></td>
                <td>12</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Update the pages</td>
                <td><b></b></td>
                <td>9</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Add search</td>
                <td><b></b></td>
                <td>9</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Add a new field</td>
                <td><b></b></td>
                <td>10</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Add validation</td>
                <td><b></b></td>
                <td>9</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Filters</td>
                <td><b></b></td>
                <td>8</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Route and app conventions</td>
                <td><b></b></td>
                <td>35</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">MVC</td>
                <td><b>242</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Overview</td>
                <td><b></b></td>
                <td>9</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Tutorial</td>
                <td><b>110</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Overview</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Get started</td>
                <td><b></b></td>
                <td>10</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Add a controller</td>
                <td><b></b></td>
                <td>12</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Add a view</td>
                <td><b></b></td>
                <td>16</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Add a model</td>
                <td><b></b></td>
                <td>28</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Work with a database</td>
                <td><b></b></td>
                <td>9</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Controller actions and views</td>
                <td><b></b></td>
                <td>9</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Add search</td>
                <td><b></b></td>
                <td>7</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Add a new field</td>
                <td><b></b></td>
                <td>5</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Add validation</td>
                <td><b></b></td>
                <td>9</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Examine the Details and Delete methods</td>
                <td><b></b></td>
                <td>3</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Views</td>
                <td><b></b></td>
                <td>13</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Partial views</td>
                <td><b></b></td>
                <td>8</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Controllers</td>
                <td><b></b></td>
                <td>4</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Routing</td>
                <td><b></b></td>
                <td>68</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Dependency injection - controllers</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Dependency injection - views</td>
                <td><b></b></td>
                <td>4</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Unit test</td>
                <td><b></b></td>
                <td>24</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Blazor</td>
                <td><b>368</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Overview</td>
                <td><b></b></td>
                <td>5</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Supported platforms</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Get started</td>
                <td><b></b></td>
                <td>6</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Hosting models</td>
                <td><b></b></td>
                <td>9</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Tutorials</td>
                <td><b>15</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Build your first app</td>
                <td><b></b></td>
                <td>8</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">SignalR with Blazor WebAssembly</td>
                <td><b></b></td>
                <td>7</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Templates</td>
                <td><b></b></td>
                <td>3</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Components</td>
                <td><b></b></td>
                <td>25</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Data binding</td>
                <td><b></b></td>
                <td>7</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Event handling</td>
                <td><b></b></td>
                <td>5</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Lifecycle</td>
                <td><b></b></td>
                <td>10</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Templated components</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Integrate components</td>
                <td><b></b></td>
                <td>5</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Globalization and localization</td>
                <td><b></b></td>
                <td>4</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Layouts</td>
                <td><b></b></td>
                <td>4</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Forms and validation</td>
                <td><b></b></td>
                <td>9</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Dependency injection</td>
                <td><b></b></td>
                <td>9</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Routing</td>
                <td><b></b></td>
                <td>7</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Call JavaScript from .NET</td>
                <td><b></b></td>
                <td>15</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Call .NET from JavaScript</td>
                <td><b></b></td>
                <td>6</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Hosting model configuration</td>
                <td><b></b></td>
                <td>6</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Component libraries</td>
                <td><b></b></td>
                <td>3</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Security and Identity</td>
                <td><b>127</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Overview</td>
                <td><b></b></td>
                <td>10</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Blazor WebAssembly</td>
                <td><b>86</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="1">Overview</td>
                <td><b></b></td>
                <td>3</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="1">Standalone with Authentication library</td>
                <td><b></b></td>
                <td>6</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="1">Standalone with Microsoft Accounts</td>
                <td><b></b></td>
                <td>7</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="1">Standalone with AAD</td>
                <td><b></b></td>
                <td>7</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="1">Standalone with AAD B2C</td>
                <td><b></b></td>
                <td>7</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="1">Hosted with AAD</td>
                <td><b></b></td>
                <td>12</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="1">Hosted with AAD B2C</td>
                <td><b></b></td>
                <td>13</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="1">Hosted with Identity Server</td>
                <td><b></b></td>
                <td>10</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="1">Additional scenarios</td>
                <td><b></b></td>
                <td>15</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="1">AAD groups and roles</td>
                <td><b></b></td>
                <td>6</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Blazor Server</td>
                <td><b>26</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="1">Overview</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="1">Threat mitigation</td>
                <td><b></b></td>
                <td>22</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="1">Additional scenarios</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Content Security Policy</td>
                <td><b></b></td>
                <td>5</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">State management</td>
                <td><b></b></td>
                <td>12</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Handle errors</td>
                <td><b></b></td>
                <td>11</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Debug WebAssembly</td>
                <td><b></b></td>
                <td>4</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Call a web API from WebAssembly</td>
                <td><b></b></td>
                <td>6</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">WebAssembly performance</td>
                <td><b></b></td>
                <td>4</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Progressive Web Applications</td>
                <td><b></b></td>
                <td>15</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Host and deploy</td>
                <td><b>22</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Overview</td>
                <td><b></b></td>
                <td>3</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Blazor WebAssembly</td>
                <td><b></b></td>
                <td>13</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Blazor Server</td>
                <td><b></b></td>
                <td>4</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Configure the Linker</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Advanced scenarios</td>
                <td><b></b></td>
                <td>10</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Client-side development</td>
                <td><b>58</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Single Page Apps</td>
                <td><b>23</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Angular</td>
                <td><b></b></td>
                <td>6</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">React</td>
                <td><b></b></td>
                <td>4</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">React with Redux</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">JavaScript Services</td>
                <td><b></b></td>
                <td>11</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">LibMan</td>
                <td><b>17</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Overview</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">CLI</td>
                <td><b></b></td>
                <td>8</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Visual Studio</td>
                <td><b></b></td>
                <td>7</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Grunt</td>
                <td><b></b></td>
                <td>8</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Bundle and minify</td>
                <td><b></b></td>
                <td>7</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Browser Link</td>
                <td><b></b></td>
                <td>3</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Session and state management</td>
                <td><b></b></td>
                <td>31</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Layout</td>
                <td><b></b></td>
                <td>5</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Razor syntax</td>
                <td><b></b></td>
                <td>18</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Razor class libraries</td>
                <td><b></b></td>
                <td>10</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Tag Helpers</td>
                <td><b>221</b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Overview</td>
                <td><b></b></td>
                <td>12</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Create Tag Helpers</td>
                <td><b></b></td>
                <td>16</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Use Tag Helpers in forms</td>
                <td><b></b></td>
                <td>18</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Tag Helper Components</td>
                <td><b></b></td>
                <td>5</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Built-in Tag Helpers</td>
                <td><b>170</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Anchor</td>
                <td><b></b></td>
                <td>6</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Cache</td>
                <td><b></b></td>
                <td>4</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Component</td>
                <td><b></b></td>
                <td>3</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Distributed Cache</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Environment</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Form</td>
                <td><b></b></td>
                <td>18</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Form Action</td>
                <td><b></b></td>
                <td>18</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Image</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Input</td>
                <td><b></b></td>
                <td>18</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Label</td>
                <td><b></b></td>
                <td>18</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Link</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Partial</td>
                <td><b></b></td>
                <td>3</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Script</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Select</td>
                <td><b></b></td>
                <td>18</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Textarea</td>
                <td><b></b></td>
                <td>18</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Validation Message</td>
                <td><b></b></td>
                <td>18</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Validation Summary</td>
                <td><b></b></td>
                <td>18</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Advanced</td>
                <td><b>149</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Application parts</td>
                <td><b></b></td>
                <td>7</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Application model</td>
                <td><b></b></td>
                <td>10</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Areas</td>
                <td><b></b></td>
                <td>14</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Filters</td>
                <td><b></b></td>
                <td>44</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Razor SDK</td>
                <td><b></b></td>
                <td>8</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">View components</td>
                <td><b></b></td>
                <td>11</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">View compilation</td>
                <td><b></b></td>
                <td>5</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Upload files</td>
                <td><b></b></td>
                <td>44</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Web SDK</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">aspnet-codegenerator (Scaffolding)</td>
                <td><b></b></td>
                <td>4</td>
            </tr>
            <tr>
                <td colspan="5">Web API apps</td>
                <td><b>146</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Overview</td>
                <td><b></b></td>
                <td>10</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Tutorials</td>
                <td><b>52</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Create a web API</td>
                <td><b></b></td>
                <td>31</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Web API with MongoDB</td>
                <td><b></b></td>
                <td>21</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Swagger / OpenAPI</td>
                <td><b>24</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Overview</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Get started with Swashbuckle</td>
                <td><b></b></td>
                <td>14</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Get started with NSwag</td>
                <td><b></b></td>
                <td>6</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">OpenAPI tools</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Action return types</td>
                <td><b></b></td>
                <td>6</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Handle JSON Patch requests</td>
                <td><b></b></td>
                <td>13</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Format response data</td>
                <td><b></b></td>
                <td>7</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Custom formatters</td>
                <td><b></b></td>
                <td>4</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Analyzers</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Conventions</td>
                <td><b></b></td>
                <td>3</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Handle errors</td>
                <td><b></b></td>
                <td>6</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Test APIs with HTTP REPL</td>
                <td><b></b></td>
                <td>19</td>
            </tr>
            <tr>
                <td colspan="5">Real-time apps</td>
                <td><b>219</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">SignalR overview</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Supported platforms</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Tutorials</td>
                <td><b>41</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">SignalR with JavaScript</td>
                <td><b></b></td>
                <td>13</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">SignalR with TypeScript</td>
                <td><b></b></td>
                <td>21</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">SignalR with Blazor WebAssembly</td>
                <td><b></b></td>
                <td>7</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Samples</td>
                <td><b></b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Server concepts</td>
                <td><b>13</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Hubs</td>
                <td><b></b></td>
                <td>7</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Send from outside a hub</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Users and groups</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">API design considerations</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Clients</td>
                <td><b>20</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Overview</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">.NET client</td>
                <td><b></b></td>
                <td>7</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">.NET API reference</td>
                <td><b></b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Java client</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Java API reference</td>
                <td><b></b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">JavaScript client</td>
                <td><b></b></td>
                <td>9</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">JavaScript API reference</td>
                <td><b></b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Host and scale</td>
                <td><b>15</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Overview</td>
                <td><b></b></td>
                <td>5</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Azure App Service</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Redis backplane</td>
                <td><b></b></td>
                <td>4</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">SignalR with background services</td>
                <td><b></b></td>
                <td>4</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Configuration</td>
                <td><b></b></td>
                <td>69</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Authentication and authorization</td>
                <td><b></b></td>
                <td>9</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Security considerations</td>
                <td><b></b></td>
                <td>5</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">MessagePack Hub Protocol</td>
                <td><b></b></td>
                <td>15</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Streaming</td>
                <td><b></b></td>
                <td>9</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Compare SignalR and SignalR Core</td>
                <td><b></b></td>
                <td>5</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">WebSockets without SignalR</td>
                <td><b></b></td>
                <td>7</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Logging and diagnostics</td>
                <td><b></b></td>
                <td>7</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Specifications</td>
                <td><b>0</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Hub protocol</td>
                <td><b></b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Transport protocols</td>
                <td><b></b></td>
                <td></td>
            </tr>
            <tr>
                <td colspan="5">Remote Procedure Call apps</td>
                <td><b>68</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Introduction to gRPC services</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Tutorials</td>
                <td><b>9</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Get started with a gRPC service</td>
                <td><b></b></td>
                <td>9</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">gRPC services with C#</td>
                <td><b></b></td>
                <td>3</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">gRPC services with ASP.NET Core</td>
                <td><b></b></td>
                <td>4</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Call gRPC services with .NET client</td>
                <td><b></b></td>
                <td>5</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">gRPC client factory integration</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Use gRPC in browser apps</td>
                <td><b></b></td>
                <td>4</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Configuration</td>
                <td><b></b></td>
                <td>4</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Authentication and authorization</td>
                <td><b></b></td>
                <td>4</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Logging and diagnostics</td>
                <td><b></b></td>
                <td>7</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Security considerations</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Versioning gRPC services</td>
                <td><b></b></td>
                <td>5</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Manage Protobuf references with dotnet-grpc</td>
                <td><b></b></td>
                <td>4</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Migrate gRPC services from C-core</td>
                <td><b></b></td>
                <td>3</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Compare gRPC services with HTTP APIs</td>
                <td><b></b></td>
                <td>5</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Samples</td>
                <td><b></b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Troubleshoot</td>
                <td><b></b></td>
                <td>5</td>
            </tr>
            <tr>
                <td colspan="5">Test, debug, and troubleshoot</td>
                <td><b>259</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Razor Pages unit tests</td>
                <td><b></b></td>
                <td>19</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Test controllers</td>
                <td><b></b></td>
                <td>24</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Test middleware</td>
                <td><b></b></td>
                <td>3</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Remote debugging</td>
                <td><b></b></td>
                <td>20</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Snapshot debugging</td>
                <td><b></b></td>
                <td>7</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Snapshot debugging in Visual Studio</td>
                <td><b></b></td>
                <td>5</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Integration tests</td>
                <td><b></b></td>
                <td>38</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Load and stress testing</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Troubleshoot and debug</td>
                <td><b></b></td>
                <td>4</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Logging</td>
                <td><b></b></td>
                <td>55</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Troubleshoot Azure and IIS</td>
                <td><b></b></td>
                <td>60</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Azure and IIS errors reference</td>
                <td><b></b></td>
                <td>22</td>
            </tr>
            <tr>
                <td colspan="5">Data access</td>
                <td><b>429</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Tutorials</td>
                <td><b>411</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">EF Core with Razor Pages</td>
                <td><b>247</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Get started</td>
                <td><b></b></td>
                <td>32</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Create, Read, Update, and Delete</td>
                <td><b></b></td>
                <td>22</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Sort, filter, page, and group</td>
                <td><b></b></td>
                <td>29</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Migrations</td>
                <td><b></b></td>
                <td>11</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Create a complex data model</td>
                <td><b></b></td>
                <td>57</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Read related data</td>
                <td><b></b></td>
                <td>28</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Update related data</td>
                <td><b></b></td>
                <td>32</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Handle concurrency conflicts</td>
                <td><b></b></td>
                <td>36</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">EF Core with MVC</td>
                <td><b>164</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Overview</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Get started</td>
                <td><b></b></td>
                <td>21</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Create, Read, Update, and Delete</td>
                <td><b></b></td>
                <td>19</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Sort, filter, page, and group</td>
                <td><b></b></td>
                <td>14</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Migrations</td>
                <td><b></b></td>
                <td>7</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Create a complex data model</td>
                <td><b></b></td>
                <td>30</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Read related data</td>
                <td><b></b></td>
                <td>14</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Update related data</td>
                <td><b></b></td>
                <td>18</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Handle concurrency conflicts</td>
                <td><b></b></td>
                <td>18</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Inheritance</td>
                <td><b></b></td>
                <td>8</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Advanced topics</td>
                <td><b></b></td>
                <td>13</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">EF 6 with ASP.NET Core</td>
                <td><b></b></td>
                <td>3</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Azure Storage with Visual Studio</td>
                <td><b>15</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Connected Services</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Blob storage</td>
                <td><b></b></td>
                <td>10</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Queue storage</td>
                <td><b></b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Table storage</td>
                <td><b></b></td>
                <td>3</td>
            </tr>
            <tr>
                <td colspan="5">Host and deploy</td>
                <td><b>735</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Overview</td>
                <td><b></b></td>
                <td>7</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Azure App Service</td>
                <td><b>186</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Overview</td>
                <td><b></b></td>
                <td>12</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Publish with Visual Studio</td>
                <td><b></b></td>
                <td>3</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Publish with Visual Studio for Mac</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Publish with the CLI</td>
                <td><b></b></td>
                <td>13</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Publish with Visual Studio and Git</td>
                <td><b></b></td>
                <td>6</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Continuous deployment with Azure Pipelines</td>
                <td><b></b></td>
                <td>28</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">ASP.NET Core Module</td>
                <td><b></b></td>
                <td>40</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Troubleshoot</td>
                <td><b></b></td>
                <td>60</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Errors reference</td>
                <td><b></b></td>
                <td>22</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">DevOps</td>
                <td><b>27</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Overview</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Tools and downloads</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Deploy to App Service</td>
                <td><b></b></td>
                <td>7</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Continuous integration and deployment</td>
                <td><b></b></td>
                <td>10</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Monitor and troubleshoot</td>
                <td><b></b></td>
                <td>4</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Next steps</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">IIS</td>
                <td><b>218</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Overview</td>
                <td><b></b></td>
                <td>76</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Publish to IIS tutorial</td>
                <td><b></b></td>
                <td>5</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">ASP.NET Core Module</td>
                <td><b></b></td>
                <td>40</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">IIS support in Visual Studio</td>
                <td><b></b></td>
                <td>8</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">IIS Modules</td>
                <td><b></b></td>
                <td>5</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Troubleshoot</td>
                <td><b></b></td>
                <td>60</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Errors reference</td>
                <td><b></b></td>
                <td>22</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Transform web.config</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Kestrel</td>
                <td><b></b></td>
                <td>69</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">HTTP.sys</td>
                <td><b></b></td>
                <td>37</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Windows service</td>
                <td><b></b></td>
                <td>32</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Linux with Nginx</td>
                <td><b></b></td>
                <td>14</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Linux with Apache</td>
                <td><b></b></td>
                <td>12</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Docker</td>
                <td><b>18</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Overview</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Build Docker images</td>
                <td><b></b></td>
                <td>5</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Visual Studio Tools</td>
                <td><b></b></td>
                <td>9</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Publish to a Docker image</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Sample Docker images</td>
                <td><b></b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Proxy and load balancer configuration</td>
                <td><b></b></td>
                <td>26</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Web farm</td>
                <td><b></b></td>
                <td>5</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Visual Studio publish profiles</td>
                <td><b></b></td>
                <td>13</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Visual Studio for Mac publish to folder</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Directory structure</td>
                <td><b></b></td>
                <td>3</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Health checks</td>
                <td><b></b></td>
                <td>44</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Blazor</td>
                <td><b>22</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Overview</td>
                <td><b></b></td>
                <td>3</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Blazor WebAssembly</td>
                <td><b></b></td>
                <td>13</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Blazor Server</td>
                <td><b></b></td>
                <td>4</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Configure the Linker</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                <td colspan="5">Security and Identity</td>
                <td><b>730</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Overview</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Authentication</td>
                <td><b>264</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Overview</td>
                <td><b></b></td>
                <td>4</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Introduction to Identity</td>
                <td><b></b></td>
                <td>16</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Identity with SPA</td>
                <td><b></b></td>
                <td>11</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Scaffold Identity</td>
                <td><b></b></td>
                <td>39</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Add custom user data to Identity</td>
                <td><b></b></td>
                <td>13</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Authentication samples</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Customize Identity</td>
                <td><b></b></td>
                <td>19</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Community OSS authentication options</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Configure Identity</td>
                <td><b></b></td>
                <td>5</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Configure Windows Authentication</td>
                <td><b></b></td>
                <td>10</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Custom storage providers for Identity</td>
                <td><b></b></td>
                <td>9</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Google, Facebook ...</td>
                <td><b>38</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Overview</td>
                <td><b></b></td>
                <td>4</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Google authentication</td>
                <td><b></b></td>
                <td>3</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Facebook authentication</td>
                <td><b></b></td>
                <td>5</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Microsoft authentication</td>
                <td><b></b></td>
                <td>4</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Twitter authentication</td>
                <td><b></b></td>
                <td>4</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Other providers</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Additional claims</td>
                <td><b></b></td>
                <td>16</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Policy schemes</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">WS-Federation authentication</td>
                <td><b></b></td>
                <td>4</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Account confirmation and password recovery</td>
                <td><b></b></td>
                <td>14</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Enable QR code generation in Identity</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Two-factor authentication with SMS</td>
                <td><b></b></td>
                <td>5</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Use cookie authentication without Identity</td>
                <td><b></b></td>
                <td>14</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Use social authentication without Identity</td>
                <td><b></b></td>
                <td>4</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Azure Active Directory</td>
                <td><b>20</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Overview</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Integrate Azure AD into a web app</td>
                <td><b></b></td>
                <td>5</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Scenarios</td>
                <td><b>13</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="1">Web app that signs in users</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="1">Web app that calls web APIs</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="1">Protected web API</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="1">Web API that calls other web APIs</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="1">Integrate Azure AD B2C into a web app</td>
                <td><b></b></td>
                <td>5</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Samples</td>
                <td><b>0</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="1">Sign-in users and call web APIs using Azure AD V2</td>
                <td><b></b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="1">Calling an ASP.NET Core 2.0 Web API from a WPF application using Azure AD V2</td>
                <td><b></b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="1">Web API with Azure AD B2C</td>
                <td><b></b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Secure ASP.NET Core apps with IdentityServer4</td>
                <td><b></b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Secure ASP.NET Core apps with Azure App Service authentication (Easy Auth)</td>
                <td><b></b></td>
                <td>7</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Individual user accounts</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Configure certificate authentication</td>
                <td><b></b></td>
                <td>11</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Multi-factor authentication</td>
                <td><b></b></td>
                <td>11</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Authorization</td>
                <td><b>91</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Overview</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Create a web app with authorization</td>
                <td><b></b></td>
                <td>39</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Razor Pages authorization conventions</td>
                <td><b></b></td>
                <td>6</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Simple authorization</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Role-based authorization</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Claims-based authorization</td>
                <td><b></b></td>
                <td>3</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Policy-based authorization</td>
                <td><b></b></td>
                <td>20</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Authorization policy providers</td>
                <td><b></b></td>
                <td>5</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Dependency injection in requirement handlers</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Resource-based authorization</td>
                <td><b></b></td>
                <td>5</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">View-based authorization</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Limit identity by scheme</td>
                <td><b></b></td>
                <td>3</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Data protection</td>
                <td><b>96</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Overview</td>
                <td><b></b></td>
                <td>5</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Data protection APIs</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Consumer APIs</td>
                <td><b>15</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Overview</td>
                <td><b></b></td>
                <td>3</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Purpose strings</td>
                <td><b></b></td>
                <td>3</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Purpose hierarchy and multi-tenancy</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Hash passwords</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Limit the lifetime of protected payloads</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Unprotect payloads whose keys have been revoked</td>
                <td><b></b></td>
                <td>3</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Configuration</td>
                <td><b>20</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Overview</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Configure data protection</td>
                <td><b></b></td>
                <td>10</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Default settings</td>
                <td><b></b></td>
                <td>3</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Machine-wide policy</td>
                <td><b></b></td>
                <td>3</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Non-DI aware scenarios</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Extensibility APIs</td>
                <td><b>16</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Overview</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Core cryptography extensibility</td>
                <td><b></b></td>
                <td>5</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Key management extensibility</td>
                <td><b></b></td>
                <td>7</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Miscellaneous APIs</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Implementation</td>
                <td><b>34</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Overview</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Authenticated encryption details</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Subkey derivation and authenticated encryption</td>
                <td><b></b></td>
                <td>3</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Context headers</td>
                <td><b></b></td>
                <td>8</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Key management</td>
                <td><b></b></td>
                <td>6</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Key storage providers</td>
                <td><b></b></td>
                <td>4</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Key encryption at rest</td>
                <td><b></b></td>
                <td>3</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Key immutability and settings</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Key storage format</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Ephemeral data protection providers</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Compatibility</td>
                <td><b>4</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Overview</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Replace machineKey in ASP.NET</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Secrets management</td>
                <td><b>44</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Protect secrets in development</td>
                <td><b></b></td>
                <td>15</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Azure Key Vault Configuration Provider</td>
                <td><b></b></td>
                <td>29</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Enforce HTTPS</td>
                <td><b></b></td>
                <td>12</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Host Docker with HTTPS</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Docker Compose with HTTPS</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">EU General Data Protection Regulation (GDPR) support</td>
                <td><b></b></td>
                <td>7</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Anti-request forgery</td>
                <td><b></b></td>
                <td>14</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Prevent open redirect attacks</td>
                <td><b></b></td>
                <td>3</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Prevent Cross-Site Scripting</td>
                <td><b></b></td>
                <td>6</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Enable Cross-Origin Requests (CORS)</td>
                <td><b></b></td>
                <td>33</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Share cookies among apps</td>
                <td><b></b></td>
                <td>5</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">SameSite cookies</td>
                <td><b></b></td>
                <td>10</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">SameSite samples</td>
                <td><b>8</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Razor Pages 2.1 SameSite cookie sample</td>
                <td><b></b></td>
                <td>3</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Razor Pages 3.1 SameSite cookie sample</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">MVC SameSite cookie sample</td>
                <td><b></b></td>
                <td>3</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">IP safelist</td>
                <td><b></b></td>
                <td>4</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Application security - OWASP</td>
                <td><b></b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Blazor</td>
                <td><b>127</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Overview</td>
                <td><b></b></td>
                <td>10</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Blazor WebAssembly</td>
                <td><b>86</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Overview</td>
                <td><b></b></td>
                <td>3</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Standalone with Authentication library</td>
                <td><b></b></td>
                <td>6</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Standalone with Microsoft Accounts</td>
                <td><b></b></td>
                <td>7</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Standalone with AAD</td>
                <td><b></b></td>
                <td>7</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Standalone with AAD B2C</td>
                <td><b></b></td>
                <td>7</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Hosted with AAD</td>
                <td><b></b></td>
                <td>12</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Hosted with AAD B2C</td>
                <td><b></b></td>
                <td>13</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Hosted with Identity Server</td>
                <td><b></b></td>
                <td>10</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Additional scenarios</td>
                <td><b></b></td>
                <td>15</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">AAD groups and roles</td>
                <td><b></b></td>
                <td>6</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Blazor Server</td>
                <td><b>26</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Overview</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Threat mitigation</td>
                <td><b></b></td>
                <td>22</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="2">Additional scenarios</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Content Security Policy</td>
                <td><b></b></td>
                <td>5</td>
            </tr>
            <tr>
                <td colspan="5">Performance</td>
                <td><b>128</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Overview</td>
                <td><b></b></td>
                <td>16</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Memory and GC</td>
                <td><b></b></td>
                <td>12</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Response caching</td>
                <td><b>65</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Overview</td>
                <td><b></b></td>
                <td>8</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">In-memory cache</td>
                <td><b></b></td>
                <td>21</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Distributed caching</td>
                <td><b></b></td>
                <td>20</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Response caching middleware</td>
                <td><b></b></td>
                <td>14</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Object reuse with ObjectPool</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Response compression</td>
                <td><b></b></td>
                <td>27</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Diagnostic tools</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Load and stress testing</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Blazor WebAssembly</td>
                <td><b></b></td>
                <td>4</td>
            </tr>
            <tr>
                <td colspan="5">Globalization and localization</td>
                <td><b>62</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Overview</td>
                <td><b></b></td>
                <td>52</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Portable Object localization</td>
                <td><b></b></td>
                <td>6</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Extensibility</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Troubleshoot</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                <td colspan="5">Advanced</td>
                <td><b>244</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Model binding</td>
                <td><b></b></td>
                <td>31</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Custom model binding</td>
                <td><b></b></td>
                <td>16</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Model validation</td>
                <td><b></b></td>
                <td>35</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Compatibility version</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Write middleware</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Request and response operations</td>
                <td><b></b></td>
                <td>4</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">URL rewriting</td>
                <td><b></b></td>
                <td>32</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">File providers</td>
                <td><b></b></td>
                <td>10</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Request-feature interfaces</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Access HttpContext</td>
                <td><b></b></td>
                <td>3</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Change tokens</td>
                <td><b></b></td>
                <td>18</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Open Web Interface for .NET (OWIN)</td>
                <td><b></b></td>
                <td>5</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Background tasks with hosted services</td>
                <td><b></b></td>
                <td>14</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Hosting startup assemblies</td>
                <td><b></b></td>
                <td>29</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">ASP.NET Core in class libraries</td>
                <td><b></b></td>
                <td>9</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Microsoft.AspNetCore.App metapackage</td>
                <td><b></b></td>
                <td>4</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Microsoft.AspNetCore.All metapackage</td>
                <td><b></b></td>
                <td>3</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Logging with LoggerMessage</td>
                <td><b></b></td>
                <td>14</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Use a file watcher</td>
                <td><b></b></td>
                <td>3</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Factory-based middleware</td>
                <td><b></b></td>
                <td>4</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Factory-based middleware with third-party container</td>
                <td><b></b></td>
                <td>4</td>
            </tr>
            <tr>
                <td colspan="5">Migration</td>
                <td><b>113</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">3.1 to 5.0</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">3.0 to 3.1</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">2.2 to 3.0</td>
                <td><b></b></td>
                <td>27</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">2.1 to 2.2</td>
                <td><b></b></td>
                <td>5</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">2.0 to 2.1</td>
                <td><b></b></td>
                <td>10</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">1.x to 2.0</td>
                <td><b>16</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Overview</td>
                <td><b></b></td>
                <td>7</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Authentication and Identity</td>
                <td><b></b></td>
                <td>9</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">ASP.NET to ASP.NET Core</td>
                <td><b>49</b></td>
                <td></td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Overview</td>
                <td><b></b></td>
                <td>7</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">MVC</td>
                <td><b></b></td>
                <td>8</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Web API</td>
                <td><b></b></td>
                <td>7</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Configuration</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Authentication and Identity</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">ClaimsPrincipal.Current</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">Membership to Identity</td>
                <td><b></b></td>
                <td>6</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                <td colspan="3">HTTP modules to middleware</td>
                <td><b></b></td>
                <td>15</td>
            </tr>
            <tr>
                    <td>&nbsp;</td>
                <td colspan="4">Logging (not ASP.NET Core)</td>
                <td><b></b></td>
                <td>2</td>
            </tr>
            <tr>
                <td colspan="5">API reference</td>
                <td><b></b></td>
                <td></td>
            </tr>
            <tr>
                <td colspan="5">Contribute</td>
                <td><b></b></td>
                <td></td>
            </tr>
    </tbody>
</table>
