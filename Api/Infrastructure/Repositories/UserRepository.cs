using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Data;
using Backend.Domain.Entities;
using Backend.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Backend.Infrastructure.Repositories
{
    public class UserRepository : IRepositoryReadOnly<User>, IRepositoryWrite<User>
    {
        
        private readonly UserContext _context;

        public UserRepository(UserContext context)
        {
            _context = context;
        }

        public Task<User> Delete(User user)
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<User>> GetAll()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetById(object id)
        {
            return await _context.Users.FirstOrDefaultAsync(user => user.Id.Equals(id));
        }

        public async Task<User> Insert(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user;            
        }

        public Task<User> Update(User t)
        {
            throw new System.NotImplementedException();
        }
    }
}