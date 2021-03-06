using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuctionProject.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Identity;

namespace AuctionProject
{
    public class Startup
    {
        //   F i e l d s  &  P r o p e r t i e s

            private IConfiguration configuration { get;}

        //   C o n s t r u c t o r s

        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer
                (configuration.GetConnectionString("DefaultConnection")));

            services.AddDefaultIdentity<IdentityUser>()
                .AddEntityFrameworkStores<AppDbContext>();
            services.AddScoped<IAuctionRepository, EfAuctionRepository>();
            services.AddScoped<IAuctionBidRepository, EfAuctionBidRepository>();
            //services.AddScoped<IUserRepository, EfUserRepository>();
            services.AddControllersWithViews();
            services.AddRazorPages();
            services.AddHttpContextAccessor();
            services.AddMemoryCache();
            services.AddSession();

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
                app.UseExceptionHandler("/Auction/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseSession();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Auction}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
