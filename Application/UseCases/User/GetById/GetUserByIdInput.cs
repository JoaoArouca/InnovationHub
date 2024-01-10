using MediatR;

namespace Application.UseCases.User.GetById
{
    public class GetUserByIdInput : IRequest<GetUserByIdOutput>
    {
        public Guid UserId { get; set; }

        public GetUserByIdInput(string userId)
        {
            UserId = Guid.Parse(userId);
        }
    }
}
