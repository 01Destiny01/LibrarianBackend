namespace Librarian.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; } //LAM -> TODO: Encriptar contraseña


        // LAM -> TODO: Hablar con el equipo para ver como queremos hacer el tema entidades.
        public DateTime CreatedAt { get; set; }
        public DateTime? DisabledAt { get; set; }
        public bool Active { get; set; }
    }
}
