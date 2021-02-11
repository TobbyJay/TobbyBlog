using TobbyBlog.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using TobbyBlog.Services;
using TobbyBlog.Entities;
using TobbyBlog.DataAccess.Repository.Implementation;
using TobbyBlog.DataAccess.Repository.Interface;
using TobbyBlog;

namespace FindMyCarAPI.Installers
{
    public class DbInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<TobbyBlogDbContext>(options =>
               options.UseSqlServer(
                   configuration.GetConnectionString("DBConnection")));
         
            services.AddScoped(typeof(IDatastore<>), typeof(DataStore<>));


        }
    }
}
