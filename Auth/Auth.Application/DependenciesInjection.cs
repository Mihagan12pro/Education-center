using Auth.Application.Abstraction;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Auth.Application.Implementations;

namespace Auth.Application
{
    public static class DependenciesInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IRegisterService, RegisterService>();

            return services;
        }
    }
}
