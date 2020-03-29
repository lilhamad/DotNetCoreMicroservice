using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Actio.Common.Events
{
    public class ActivityCreated : IAuthenticatedEvent
    {
        public Guid UserId { get; }
        public Guid Id { get; }
        public string Category { get; }
        public string Name { get; }
        public string Description { get; }
        public DateTime CreatedAt { get; }


        protected ActivityCreated()
        {

        }
        public ActivityCreated(Guid id, Guid userId, string name, string category)
        {
            Id = id;
            UserId = userId;
            Name = name;
            Category = category;
        }
    }
}
