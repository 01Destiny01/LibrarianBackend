using Librarian.Domain.Entities;
using Librarian.Infrastucture.Repositories.Interfaces;
using Librarian.Infrastucture.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Librarian.Domain.Services
{
    public class UserService: IUserService
    {
        IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
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
            return await _userRepository.GetUsers();
        }
    }
}
