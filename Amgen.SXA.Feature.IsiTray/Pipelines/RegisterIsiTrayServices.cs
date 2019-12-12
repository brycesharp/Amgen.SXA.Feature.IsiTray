using Amgen.SXA.Feature.IsiTray.Models;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Amgen.SXA.Feature.IsiTray.Pipelines
{
    public class RegisterIsiTrayServices : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped( typeof(IIsiTrayXARepository), 
                                typeof(IsiTrayXARepository) );
        }
    }
}