using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Assigment_4_Code.Authentication;
using Assigment_4_Code.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Components.Authorization;

namespace Assigment_4_Code
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
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<IAdultServiceA, AdultServiceA>();
            services.AddScoped<IUserService, InMemoryUserService>();
            services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
            services.AddAuthorization(options =>
            {
                options.AddPolicy("LogIn", a => 
                    a.RequireAuthenticatedUser().RequireClaim("Level", "2"));
                
                options.AddPolicy("SecurityLevel2", a => a.RequireAuthenticatedUser().RequireAssertion(context =>
                {
                    Claim levelClaim = context.User.FindFirst(claim => claim.Type.Equals("Level"));
                    if (levelClaim == null) return false;
                    return int.Parse(levelClaim.Value) >= 2;
                }));
                
                options.AddPolicy("SecurityLevel3", a => a.RequireAuthenticatedUser().RequireAssertion(context =>
                {
                    Claim levelClaim = context.User.FindFirst(claim => claim.Type.Equals("Level"));
                    if (levelClaim == null) return false;
                    return int.Parse(levelClaim.Value) >= 3;
                }));
            });
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
        }
    }
}