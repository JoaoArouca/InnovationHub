namespace Domain.Models
{
    public class UserModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public DateTime CreatedAt { get; set; }

        public UserModel(Guid id, string name, string email, string password, Role role)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            Role = role;
            CreatedAt = DateTime.Now;
        }
    }

    public enum Role
    {
        CUSTOMER,
        ADMIN,
        INTERNAL
    }
}
