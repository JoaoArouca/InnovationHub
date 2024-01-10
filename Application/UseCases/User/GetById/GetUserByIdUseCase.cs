using Application.Repositories;
using Application.UseCases.User.GetById.Interfaces;
using Domain.Models;

namespace Application.UseCases.User.GetById
{
    internal sealed class GetUserByIdUseCase : IGetUserByIdUseCase
    {
        private const string NotFound = "user not found";
        private const string FoundWithSuccess = "user not found";
        private readonly InMemoryDatabase _database;

        public GetUserByIdUseCase(InMemoryDatabase database)
        {
            _database = database ?? throw new ArgumentNullException(nameof(database));
        }

        public Task<GetUserByIdOutput> Handle(GetUserByIdInput request, CancellationToken cancellationToken)
        {
            GetUserByIdOutput userByIdOutput = new();

            UserModel user = _database.GetUserById(request.UserId);

            if (user == null)
            {
                userByIdOutput.ErrorMessage = NotFound;
                return Task.FromResult(userByIdOutput);
            }

            ResultGetUserByIdOutput result = new(user);

            userByIdOutput.Result = result;
            userByIdOutput.Message = FoundWithSuccess;

            return Task.FromResult(userByIdOutput);
        }
    }
}
