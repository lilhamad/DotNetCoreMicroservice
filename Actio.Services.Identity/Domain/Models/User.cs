using System;

namespace IdentityService_Microservice.Actio.Services.Identity.Domain.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public DateTime CreatedAt { get; set; }

        public User()
        {

        }

        public User(string email, string name)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                throw new ArgumentNullException("Empty email");
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Empty name");
            }
            Id = Guid.NewGuid();
            Email = email.ToLowerInvariant();
            CreatedAt = DateTime.UtcNow;

        }
    }
}
