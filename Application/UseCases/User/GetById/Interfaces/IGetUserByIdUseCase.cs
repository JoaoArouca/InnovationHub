using MediatR;

namespace Application.UseCases.User.GetById.Interfaces
{
    internal interface IGetUserByIdUseCase : IRequestHandler<GetUserByIdInput, GetUserByIdOutput>
    {
    }
}
