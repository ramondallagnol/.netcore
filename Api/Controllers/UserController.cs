using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Backend.Domain.Entities;
using Backend.Infrastructure.Repositories;

namespace Backend.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        private readonly UserRepository _userRepository;
        public UserController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Create([FromBody] User user)
        {
            await _userRepository.Insert(user);
            return Ok(user);
        }
    }
}