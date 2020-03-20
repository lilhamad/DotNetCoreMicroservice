using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_microservices.Actio.Services.Activities.Domain.Models
{
    public class Activity
    {
        public Guid Id { get; protected set; }
        public string Name { get; protected set; }
        public string Category { get; protected set; }
        public string Description { get; protected set; }
        public Guid UserId { get; protected set; }
        public DateTime CreatedAt { get; protected set; }

        public Activity()
        {

        }

        public Activity(Guid id, Category category, Guid userId, string name, string description, DateTime createdAt)
        {
            Id = id;
            Name = name;
            Category = category.Name;
            UserId = userId;
            Description = description;
            CreatedAt = createdAt;

        }
    }
}
