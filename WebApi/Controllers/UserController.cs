using Application.Repositories;
using Application.UseCases.User.Create;
using Domain.Models;
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

        public UserController(InMemoryDatabase database, IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _database = database;
        }

        [HttpPost]
        [Route("create-user")]
        public async Task<IActionResult> CreateUser([Required] string name, [Required] string email, [Required] string password, [Required] Role role)
        {
            CreateUserInput input = new(name, password, email, role);

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