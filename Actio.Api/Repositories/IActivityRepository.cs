using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Actio.Api.Repositories
{
    public interface IActivityRepository
    {
        Task AddAsync(Activity model);
    }
}
