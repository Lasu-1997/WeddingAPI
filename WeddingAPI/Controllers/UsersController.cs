using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Utilities;
using WeddingAPI.Models;
using WeddingAPI.Repository;

namespace WeddingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsers usersRepository;

        public UsersController(IUsers userRepository)
        {
            usersRepository = userRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Users>>> GetUsers()
        {
            return Ok(usersRepository.GetUsers());
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Users>> GetUser(int id)
        {
            var result = await usersRepository.GetUser(id);

            return Ok(result);
        }
        [HttpPost]
        public async Task<ActionResult<Users>> AddUsers(Users users)
        {
            usersRepository.AddUsers(users);
            return await Task.FromResult(users);
        }
    }
}
