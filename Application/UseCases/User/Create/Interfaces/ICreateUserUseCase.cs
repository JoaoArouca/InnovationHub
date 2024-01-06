using MediatR;

namespace Application.UseCases.User.Create.Interfaces
{
    internal interface ICreateUserUseCase : IRequestHandler<CreateUserInput, CreateUserOutput>
    {
    }
}
