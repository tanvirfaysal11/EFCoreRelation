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
        [HttpPost]
        public async Task<ActionResult<List<User>>> Post(AddNewUserDto user)
        {
            return (await _userRepository.AddUser(user));
        }

    }
}
