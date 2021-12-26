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
        public async Task<ActionResult<List<Character>>> GetUser(int userId)
        {
            var characters = await _context.Characters
                .Where(c => c.UserId == userId)
                .Include(c => c.Weapon)
                .Include(c => c.Skills)
                .ToListAsync();

            return characters;
        }
        public async Task<ActionResult<List<User>>> DeleteUser (int Id)
        {
            var user = await _context.Users.FindAsync(Id);
            if (user == null)
                Console.WriteLine("Id Not Found");
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
                return (await _context.Users.ToListAsync());
        }
    }
}
