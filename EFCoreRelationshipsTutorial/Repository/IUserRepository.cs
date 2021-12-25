using EFCoreRelation.DTO;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreRelation.Repository
{
    public interface IUserRepository
    {
        public Task<ActionResult<List<User>>> AddUser(AddNewUserDto user);
    }
}
