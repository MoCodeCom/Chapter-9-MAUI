using Chapter_9.ModelView.Interfaces;
using Chapter_9.ModelView.ModelViewData;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_9.ModelView.DependencyInjectionExtention
{
    static class DependencyInjector
    {
        public static IServiceCollection ConfigurationDepartment(this IServiceCollection services)
        {
            services.AddSingleton<IModelViewDepartment, ModelViewDepartment>();
            return services;
        }

        public static IServiceCollection ConfigurationTestDI(this IServiceCollection services)
        {
            services.AddTransient<ITestDI, TestDI>();
            return services;
        }

        public static IServiceCollection ConfigurationMainModel(this IServiceCollection services) 
        {
            services.AddTransient<MainPageModel>();
            return services;
        }

        public static IServiceCollection ConfigurationListPage(this IServiceCollection services)
        {
            services.AddTransient<ListPage>();
            return services;
        }




    }
}
