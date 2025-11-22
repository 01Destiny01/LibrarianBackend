using Librarian.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Librarian.Infrastucture.Interfaces
{
    public interface IUserRepository
    {
        Task AddUser(User user);
        Task<List<User>> GetUsers();
    }
}
