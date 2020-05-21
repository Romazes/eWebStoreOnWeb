using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebStore.Core.Entities.Auth;
using WebStore.Core.Interfaces;
using WebStore.Infrastructure.Data;
using WebStore.Infrastructure.Data.Repositories;

namespace WebStore.UI
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
            services.AddDbContext<AppDbContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("AppDBContext")));

            services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<AppDbContext>();

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = $"/Identity/Account/Login";
                options.LogoutPath = $"/Identity/Account/Logout";
                options.AccessDeniedPath = $"/Manage/Account/AccessDenied";
            });

            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<ShoppingCartRepository>(sp => ShoppingCartRepository.GetCart(sp));
            services.AddHttpContextAccessor();

            //Claims-based
            services.AddAuthorization(options =>
            {
                options.AddPolicy("AdministratorOnly", policy => policy.RequireRole("Administrator"));
                options.AddPolicy("CreateCategoryPolicy", policy => policy.RequireClaim("Create Category", "Create Category"));
                options.AddPolicy("DeleteCategoryPolicy", policy => policy.RequireClaim("Delete Category", "Delete Category"));
            });

            //services.AddAuthorization(options =>
            //{
            //    options.AddPolicy("CreateCategoryPolicy",
            //        policy => policy.RequireClaim("Create Category"));

            //    options.AddPolicy("UpdateCategoryPolicy",
            //        policy => policy.RequireClaim("Update Category"));

            //    options.AddPolicy("DeleteCategoryPolicy",
            //        policy => policy.RequireClaim("Create Category")
            //                        .RequireClaim("Delete Category"));
            //});

            //options.AddPolicy("DeleteCategoryPolicy", policy => policy.RequireClaim("Create Category", "Create Category")
            //                                                          .RequireClaim("Delete Category", "Delete Category"));



            services.AddSession();
            services.AddControllersWithViews();
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();                   // Should be executed befor UseRouting
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            // app.UseMvcWithDefaultRoute(); // Default route implementation
            // Expanded route implementation
            app.UseEndpoints(endpoints =>
            {

                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "categoryFilter",
                    pattern: "product/{action}/{category?}",
                    defaults: new { controller = "Product", action = "List" });

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapRazorPages();
            });
        }
    }
}
