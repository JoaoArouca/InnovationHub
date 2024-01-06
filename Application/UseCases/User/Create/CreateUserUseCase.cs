using Application.Repositories;
using Application.UseCases.User.Create.Interfaces;
using Domain.Models;
using Microsoft.Extensions.Logging;

namespace Application.UseCases.User.Create
{
    internal sealed class CreateUserUseCase : ICreateUserUseCase
    {
        private readonly InMemoryDatabase _database;
        private readonly ILogger<CreateUserUseCase> _logger;
        public CreateUserUseCase(InMemoryDatabase database, ILogger<CreateUserUseCase> logger)
        {
            _database = database ?? throw new ArgumentNullException(nameof(database));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
        public Task<CreateUserOutput> Handle(CreateUserInput request, CancellationToken cancellationToken)
        {
            CreateUserOutput output = new();

            UserModel user = new(request.Name, request.Email, request.Password, request.Role);
            
            _database.UsersDB.Add(user);
            _database.SaveChanges();

            ResultCreateUser result = new()
            {
                UserId = "TODO: add user createdId"
            };

            output.Result = result;
            output.Message = "User created with success";

            return Task.FromResult(output);
        }
    }
}
