using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VegaIDE_V2.Server.Data;
using VegaIDE_V2.Server.Models;

[assembly: HostingStartup(typeof(VegaIDE_V2.Server.Areas.Identity.IdentityHostingStartup))]
namespace VegaIDE_V2.Server.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}