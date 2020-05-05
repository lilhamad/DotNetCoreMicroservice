using Actio.Services.Activities.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Actio.Services.Activities.Domain.Repositories
{
    public interface ICategoryRepository
    {
        //get a category of a particular name
        Task<Category> GetAsync(string name);
        //returns all available category
        Task<IEnumerable<Category>> BrowseAsync();
        //save a category to a database
        Task AddAsync(Category category);

    }
}
