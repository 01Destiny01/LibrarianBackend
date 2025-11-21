using System;
using System.Collections.Generic;
using System.Text;

namespace Librarian.Application.Interfaces
{
    public interface IUserService
    {
        Task CreateUser(string firstName, string lastName, string email, string username, string password);
    }
}
