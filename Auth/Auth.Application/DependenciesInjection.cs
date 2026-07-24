using Auth.Application.Abstraction;
using Auth.Application.Implementetions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auth.Application
{
    public static class DependenciesInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IRegisterService, RegisterService>();

            return services;
        }
    }
}
