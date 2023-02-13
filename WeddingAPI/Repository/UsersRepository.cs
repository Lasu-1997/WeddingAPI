using Microsoft.EntityFrameworkCore;
using System;
using WeddingAPI.Models;

namespace WeddingAPI.Repository
{
    public class UsersRepository : IUsers
    {
        private readonly WeddingDbContext weddingDbContext_context;

        public UsersRepository(WeddingDbContext weddingDbContext_context)
        {
            this.weddingDbContext_context = weddingDbContext_context;
        }
        public async Task<IEnumerable<Users>> GetUsers()
        {
            return await weddingDbContext_context.Users.ToListAsync();
        }
        public async Task<Users> GetUser(int id)
        {
            return await weddingDbContext_context.Users.FindAsync(id);
        }
        public async Task<Users> AddUsers(Users users)
        {
            await weddingDbContext_context.Users.AddAsync(users);

            weddingDbContext_context.SaveChanges();

            return users;
        }
        public async Task<Users> UpdateUsers(Users users)
        {
            weddingDbContext_context.Entry(users).State = EntityState.Modified;

            await weddingDbContext_context.SaveChangesAsync();

            return users;

        }

        public async void DeleteUsers(int id)
        {
            var user = weddingDbContext_context.Users.FindAsync(id);

            weddingDbContext_context.Entry(user).State= EntityState.Deleted;

            await weddingDbContext_context.SaveChangesAsync();
        }   
    }
}
