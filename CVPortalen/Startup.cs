using CVPortalen.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CVPortalen
{



    //ANVÄND INTE DENNA KLASS /MAX



    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration; 
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddSingleton<Profil>();

            services.AddDbContext<ProfilContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("ProfileContext")));


            //För användar hantering
            services.AddIdentity<Anvandare, IdentityRole>()
                .AddEntityFrameworkStores<ProfilContext>()
                .AddDefaultTokenProviders();
        }


        //Konfigg skiten, vet inte riktigt hur den funkar men den funkar
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if(env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home Error FAAAAN");
                app.UseHsts();  
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{ id ?}");
            });
        }


    }
}
