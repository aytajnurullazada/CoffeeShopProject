using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Repository.Data;
using AutoMapper;
using Repository.Repositories.ShoppingRepositories;
using Repository.Repositories.RecipeRepository;
using WebApplication1.Libs;

namespace WebApplication1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddMvc(
                config =>
                {
                    config.Filters.Add(new GlobalToken());
                });

            services.AddAutoMapper(typeof(Startup));

            services.AddDbContext<CafenodDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("Default"),
            x => x.MigrationsAssembly("Repository")));

            services.AddTransient<IDepartmentRepository, DepartmentRepository>();
            services.AddTransient<IRecipeRepository, RecipeRepository>();
            services.AddTransient<IProductRepository, ProductRepositroy>();
            services.AddTransient<IBasketRepository, BasketRepository>();


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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
