using InvoiceManagementBlazor.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceManagementBlazor.Server.Interfaceas
{
   public interface IUserRepository
    {
        Task<Guid> CreateUser(User user);
        Task<User> GetUser(string Username, string password);
    }
}
