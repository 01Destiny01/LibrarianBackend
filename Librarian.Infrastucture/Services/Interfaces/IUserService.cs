using Librarian.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Librarian.Infrastucture.Services.Interfaces
{
    public interface IUserService
    {
        Task CreateUser(string firstName, string lastName, string email, string username, string password);
        Task<List<User>> GetUsers();
    }
}
