using Application.Repositories;
using Application.UseCases.User.Create.Interfaces;
using Domain.Models;
using Microsoft.Extensions.Logging;

namespace Application.UseCases.User.Create
{
    internal sealed class CreateUserUseCase : ICreateUserUseCase
    {
        private const string FailedToCreate = "Failed to create user";
        private const string AlreadyExists = "user already exists";
        private const string Success = "User created with success";
        private readonly InMemoryDatabase _database;
        private readonly ILogger<CreateUserUseCase> _logger;
        public CreateUserUseCase(InMemoryDatabase database, ILogger<CreateUserUseCase> logger)
        {
            _database = database ?? throw new ArgumentNullException(nameof(database));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
        public async Task<CreateUserOutput> Handle(CreateUserInput request, CancellationToken cancellationToken)
        {
            CreateUserOutput output = new();

            UserModel? userAlreadyExists = _database.GetUserByEmail(request.Email);

            if (userAlreadyExists != null)
            {
                output.ErrorMessage = AlreadyExists;
            }

            if (userAlreadyExists == null)
            {
                try
                {
                    UserModel user = new(request.Name, request.Email, request.Password, request.Role);

                    _database.UsersDB.Add(user);
                    await _database.SaveChangesAsync(cancellationToken);

                    UserModel? createdUser = _database.GetUserById(user.Id);

                    if (createdUser == null)
                    {
                        output.ErrorMessage = FailedToCreate;
                    }

                    if (createdUser != null)
                    {
                        ResultCreateUser result = new()
                        {
                            UserId = createdUser.Id.ToString()
                        };

                        output.Result = result;
                        output.Message = Success;
                    }
                }
                catch (Exception ex)
                {
                    output.ErrorMessage = $"An error occurred: {ex.Message}";
                }
            }


            return output;
        }
    }
}
