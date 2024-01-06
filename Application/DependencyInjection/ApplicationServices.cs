using Application.Repositories;
using Application.UseCases.User.Create;
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
        public static IServiceCollection AddMediator(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(CreateUserUseCase).Assembly));

            return services;
        }
    }
}
