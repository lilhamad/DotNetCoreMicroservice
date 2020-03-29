using net_microservices.Actio.Services.Activities.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_microservices.Actio.Services.Activities.Domain.Repositories
{
    interface ICategoryRepository
    {
        Task<Category> GetAsync(string name);
        Task<IEnumerable<Category>> BrowseAsync(string name);
        Task AddAsync(string category);

    }
}
