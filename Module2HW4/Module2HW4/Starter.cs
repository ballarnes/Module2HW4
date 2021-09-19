using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Module2HW4.Providers.Abstractions;
using Module2HW4.Services.Abstractions;
using Module2HW4.Providers;
using Module2HW4.Services;
using Module2HW4.Services.SearchServices;

namespace Module2HW4
{
    public class Starter
    {
        public void Run()
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IAnimalProvider, AnimalProvider>()
                .AddSingleton<ISectionProvider, SectionProvider>()
                .AddTransient<ISectionService, SectionService>()
                .AddTransient<ICountService, CountService>()
                .AddTransient<ISearchService, SearchByNameService>()
                .AddTransient<AppStarter>()
                .BuildServiceProvider();

            var start = serviceProvider.GetService<AppStarter>();
            start.Start();
        }
    }
}
