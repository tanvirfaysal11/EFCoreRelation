using EFCoreRelation.DTO;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreRelation.Repository
{
    public interface IUserRepository
    {
        public Task<ActionResult<List<User>>> AddUser(AddNewUserDto user);
        public Task<ActionResult<List<User>>> DeleteUser(int Id);
        public Task<ActionResult<List<Character>>> GetUser(int userId);
    }
}
