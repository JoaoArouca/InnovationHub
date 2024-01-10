using Application.Repositories;
using Application.UseCases.User.Create;
using Application.UseCases.User.GetById;
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
        private readonly IValidator<string> _getUserByIdValidator;

        public UserController(InMemoryDatabase database, IMediator mediator, IValidator<CreateUserInput> createValidator, IValidator<string> getUserByIdValidator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _database = database;
            _createValidator = createValidator ?? throw new ArgumentNullException(nameof(createValidator));
            _getUserByIdValidator = getUserByIdValidator ?? throw new ArgumentNullException(nameof(getUserByIdValidator));
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
        [Route("get-user-by-id")]
        public async Task<IActionResult> GetUserById([Required] string userId)
        {
            var validation = await _getUserByIdValidator.ValidateAsync(userId);

            if (!validation.IsValid)
            {
                return BadRequest(validation.Errors);
            }
            GetUserByIdInput input = new(userId);

            GetUserByIdOutput output = await _mediator.Send(input).ConfigureAwait (false);

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