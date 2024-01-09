using Application.Repositories;
using Application.UseCases.User.Create;
using Domain.Models;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly InMemoryDatabase _database;
        private readonly IValidator<CreateUserInput> _createValidator;

        public UserController(InMemoryDatabase database, IMediator mediator, IValidator<CreateUserInput> createValidator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _database = database;
            _createValidator = createValidator ?? throw new ArgumentNullException(nameof(createValidator));
        }

        [HttpPost]
        [Route("create-user")]
        public async Task<IActionResult> CreateUser([Required] string name, [Required] string email, [Required] string password, [Required] Role role)
        {
            CreateUserInput input = new(name, password, email, role);

            var validation = await _createValidator.ValidateAsync(input);

            if (!validation.IsValid)
            {
                return BadRequest(validation.Errors);
            }

            CreateUserOutput output = await _mediator.Send(input).ConfigureAwait(false);

            if (output.Result != null)
            {
                return Ok(output);
            }

            return BadRequest(output);
        }

        [HttpGet]
        [Route("get-all-users")]
        public List<UserModel> GetUsers()
        {
            return _database.UsersDB.ToList();
        }
    }
}