using EFCoreRelation.DTO;
using EFCoreRelation.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreRelation.Services
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<ActionResult<List<User>>> AddUser(AddNewUserDto request)
        {
            var item = await _context.Users.FindAsync(request.Id);
            var newuser = new User
            {
                Username = request.Username
            };
            _context.Users.Add(newuser);
            await _context.SaveChangesAsync();
            return (await _context.Users.ToListAsync());
        }


    }
}
