﻿using RegistanFerghanaLC.Service.Intefaces.Common;

namespace RegistanFerghanaLC.Web.Configuration.LayerConfigurations
{
    public static class ServiceLayerConfiguration
    {
        public static void AddService(this IServiceCollection services)
        {
            services.AddScoped<IIdentityService, IdentityService>();
        }
    }
}
