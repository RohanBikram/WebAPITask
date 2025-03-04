using Microsoft.Extensions.DependencyInjection;

namespace StudentManager.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureDI(this IServiceCollection services)
        {
            return services;
        }
    }
}

// this dependency Injection is the major reason for the error in the code as the generating Migration should be
// in the Infrastructure but the connection done in API and migration created in Infra is having the problem I think
// the reason is due to the misalignment in the DependencyInjection.cs file of the API (Presentation) layer.

// HandCrafted By Rohan Thapa.