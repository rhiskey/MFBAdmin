using MFBAdminMBlazorServer.Data;
using MFBAdminMBlazorServer.Models;
using MFBAdminMBlazorServer.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Server.IISIntegration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MudBlazor.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MFBAdminMBlazorServer
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
    public void ConfigureServices(IServiceCollection services)
    {

      IConfigurationRoot Configuration = new ConfigurationBuilder()
        .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
        .AddJsonFile("appsettings.json")
        .Build();
      string connStr = Configuration.GetConnectionString("DefaultConnection");
      services.AddDbContext<web_nprtsContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

      services.AddRazorPages();
      services.AddServerSideBlazor();

      services.AddSingleton<WeatherForecastService>();

      services.AddScoped<IFirstPartItemService, FirstPartItemService>();
      services.AddScoped<IFirstPartItemListService, FirstPartItemListService>();
      services.AddScoped<ISecondPartItemService, SecondPartItemService>();

      services.AddMudServices();
      services.AddControllersWithViews();
      services.AddAuthorizationCore();

      services.AddAuthentication(IISDefaults.AuthenticationScheme); //new
   //   services.AddAuthentication(NegotiateDefaults.AuthenticationScheme)
   //.AddNegotiate();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }
      else
      {
        app.UseExceptionHandler("/Error");
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
      }

      app.UseHttpsRedirection();
      app.UseStaticFiles();

      app.UseRouting();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapBlazorHub();
        endpoints.MapFallbackToPage("/_Host");
      });
      app.UseAuthentication();
    }
  }
}
