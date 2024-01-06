using Application.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Application.DependencyInjection
{
    public static class ApplicationServices
    {
        public static IServiceCollection AddInMemoryDatabase(this IServiceCollection services)
        {
            services.AddDbContext<InMemoryDatabase>();
            return services;
        }

        //public static IServiceCollection AddValidators(this IServiceCollection services)
        //{
        //    services.AddTransient<IModelValidator<input>, output>().
        //}

        public static IServiceCollection AddMediatR(this IServiceCollection services)
        {
            services.AddMediatR();
            return services;
        }
    }
}
