using EFCoreRelation.DTO;
using EFCoreRelation.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreRelation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        [HttpPost("AddNewUser")]
        public async Task<ActionResult<List<User>>> Post(AddNewUserDto user)
        {
            return (await _userRepository.AddUser(user));
        }  

        [HttpGet]
        public async Task<ActionResult<List<Character>>> GetUser(int userId)
        {
            return (await _userRepository.GetUser(userId));
        }
        [HttpDelete("UserDelete")]
        public async Task<ActionResult<List<User>>> DeleteUser(int Id)
        {
            return (await _userRepository.DeleteUser(Id));
        }
        

    }
}
