using net_microservices.Actio.Services.Activities.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_microservices.Actio.Services.Activities.Domain.Repositories
{
    interface IActivityRepository
    {
        Task<Activity> GetAsync(string name);
        Task AddAsync(string category);
    }
}
