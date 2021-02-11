using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace TobbyBlog.Installers
{
    public static class InstallerExtensions
    {
        public static void InstallServicesInAssembly(this IServiceCollection services, IConfiguration configuration)
        {

            //var installers = typeof(StartUp).Assembly.ExportedTypes
            //    .Where(installerType => typeof(IInstaller)
            //    .IsAssignableFrom(installerType) && !installerType.IsInterface && !installerType.IsAbstract).Select(Activator.CreateInstance).Cast<IInstaller>().ToList();


            //installers.ForEach(installer => installer.InstallServices(services, configuration));


        }
    }
}
