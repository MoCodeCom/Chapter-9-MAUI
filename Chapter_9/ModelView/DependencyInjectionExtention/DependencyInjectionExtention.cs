using Chapter_9.ModelView.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_9.ModelView.DependencyInjectionExtention
{
    static class DependencyInjectionExtention
    {
        public static IServiceProvider ServiceProvider { get; set; }
        public static IServiceProvider Init()
        {
            var server = new ServiceCollection()
                //.AddSingleton<IModelViewDepartment, ModelViewDepartment>()
                .ConfigurationMainModel()
                .AddTransient<MainPageModel>()
                .ConfigurationListPage()
                .ConfigurationDepartment()
                .ConfigurationTestDI()
                .BuildServiceProvider();
            ServiceProvider = server;
            return server;
        }

    }
}
