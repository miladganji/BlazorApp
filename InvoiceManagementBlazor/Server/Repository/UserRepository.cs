using InvoiceManagementBlazor.Server.Data;
using InvoiceManagementBlazor.Server.Interfaceas;
using InvoiceManagementBlazor.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceManagementBlazor.Server.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public UserRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public async Task<Guid> CreateUser(User user)
        {
            var res = await applicationDbContext.AddAsync(user);
            await applicationDbContext.SaveChangesAsync();
            return res.Entity.Id;
        }

        public async Task<User> GetUser(string Username, string password)
        {
            var user =await applicationDbContext.User.FirstOrDefaultAsync(a => a.UserName == Username && a.Password == password);
            if (user is null)
            {
                return null;
            }

            return user;
        }
    }
}
