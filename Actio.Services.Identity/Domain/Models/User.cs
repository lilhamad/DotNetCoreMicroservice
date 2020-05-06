using System;
using Actio.Common.Exceptions;
using Actio.Services.Identity.Domain.Services;

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

        //constructor for new registration
        public User(string email, string name)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                throw new ActioException("empty_user_email", 
                    "User email can not be empty.");
            }
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ActioException("empty_user_name", 
                    "User name can not be empty.");
            }        
            Id = Guid.NewGuid();
            Email = email.ToLowerInvariant();
            Name = name;
            CreatedAt = DateTime.UtcNow;
        }

        public void SetPassword(string password, IEncrypter encrypter)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ActioException("empty_password", 
                    "Password can not be empty.");
            }             
            Salt = encrypter.GetSalt();
            Password = encrypter.GetHash(password, Salt);
        }

        public bool ValidatePassword(string password, IEncrypter encrypter)
            => Password.Equals(encrypter.GetHash(password, Salt));
    }
}
