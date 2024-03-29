﻿using Application.Repositories;
using Application.UseCases.User.Create;
using Application.UseCases.User.GetById;
using Application.Validators.User;
using FluentValidation;
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

        public static IServiceCollection AddValidators(this IServiceCollection services)
        {
            services.AddScoped<IValidator<CreateUserInput>, CreateUserValidator>();
            services.AddTransient<IValidator<string>, GetUserByIdValidator>();
            return services;
        }
        public static IServiceCollection AddMediator(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(CreateUserUseCase).Assembly));
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(GetUserByIdUseCase).Assembly));

            return services;
        }
    }
}
