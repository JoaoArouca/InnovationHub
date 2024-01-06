using Domain.Models;
using MediatR;

namespace Application.UseCases.User.Create
{
    public class CreateUserInput : IRequest<CreateUserOutput>
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Role Role { get; set; }

        public CreateUserInput(string name, string password, string email, Role role)
        {
            Name = name;
            Password = password;
            Email = email;
            Role = role;
        }
    }
}
