using Librarian.Domain.Entities;
using Librarian.Infrastucture.Data;
using Librarian.Infrastucture.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Librarian.Infrastucture.Repositories
{
    public class UserRepository: IUserRepository
    {
        private readonly LibrarianDbContext _context;
        public UserRepository(LibrarianDbContext context) 
        {
            _context = context;
        }

        public async Task AddUser(User user)
        {
            _context.Users.Add(user);
        }
    }
}
