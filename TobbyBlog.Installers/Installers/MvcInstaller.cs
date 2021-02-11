using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.OpenApi.Models;
using TobbyBlog.Options;
using TobbyBlog;

namespace FindMyCarAPI.Installers
{
    public class MvcInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllersWithViews();
            services.AddRazorPages();
           
            services.AddSwaggerGen(gen =>
            {
                gen.SwaggerDoc("v1", new OpenApiInfo {
                    
                    Title = "Tobby's Blog API", 
                    Version = "v1",
                    Description = $"© Copyright {DateTime.Now.Year}. All rights reserved."

                });

            });

            ////set-up JWT authentication middleware
            //var jwtSettings = new JwtSettings();
            //configuration.Bind(nameof(jwtSettings), jwtSettings);
            //services.AddSingleton(jwtSettings);

            //services.AddAuthentication(auth =>
            //{
            //    auth.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            //    auth.DefaultScheme = JwtBearerDefaults.AuthenticationScheme; ;
            //    auth.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            //}).AddJwtBearer(bearer=> 
            //{
            //    bearer.SaveToken = true;

            
            //});

        }
    }
}
