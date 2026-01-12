using Librarian.Domain.Entities;
using Librarian.Infrastucture.Data;
using Librarian.Infrastucture.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Librarian.Domain.Services
{
    public class UserService: IUserService
    {
        private readonly LibrarianDbContext _context;
        public UserService(LibrarianDbContext context)
        {
            _context = context;
        }

        public async Task CreateUser(string firstName, string lastName, string email, string username, string password)
        {
            // TODO: Añadir FluentValidations para crear validaciones del usuario.
            // TODO: Encriptar las contraseñas también.
            User user = new User
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Username = username,
                Password = password,
                CreatedAt = DateTime.UtcNow,
                Active = false // Se inicia como false ya que tiene que verificar el correo. Esto igual se puede cambiar por un "email_verified" o algo similar.
            };

            // TODO: Mandar correo al usuario para verificar, tambien comprobar si el correo es válido.
            
        }

        public async Task<List<User>> GetUsers()
        {
            return _context.Users.ToList();
        }
    }
}
