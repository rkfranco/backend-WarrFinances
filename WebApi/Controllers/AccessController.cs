using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;
using WebApi.DTO;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccessController : ControllerBase
    {
        [HttpPost("Login")]
        public User Login(UserDto userDto)
        {
            UserRepository userRepository = new UserRepository();
            User user = userRepository.Login(userDto.Email, userDto.Password);
            return user;
        }
    }
}
