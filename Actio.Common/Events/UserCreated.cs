using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Actio.Common.Events
{
    public class UserCreated
    {
        public string Email { get; }
        public string Password { get; }
        public string Name { get; }

        protected UserCreated()
        {

        }
        public UserCreated(string email, string name)
        {
            Email = email;
            Name = name;
        }
    }
}
