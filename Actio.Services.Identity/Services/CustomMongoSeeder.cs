using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Actio.Common.Mongo;
using MongoDB.Driver;
using Actio.Services.Identity.Domain.Repositories;
using Actio.Services.Identity.Domain.Models;

namespace Actio.Services.Identity.Services
{
    public class CustomMongoSeeder : MongoSeeder
    {
        private readonly IUserRepository _userRepository;

        public CustomMongoSeeder(IMongoDatabase database,
            IUserRepository userRepository)
            : base(database)
        {
            _userRepository = userRepository;
        }

        protected override async Task CustomSeedAsync()
        {
            //var user = new List<string>
            //{
            //    "work",
            //    "sport",
            //    "hobby"
            //};
            var user = new User();
            user.Name = "Admin";
            user.Email = "admin@admin.com";
            user.Password = "secret";
            await _userRepository.AddAsync(user);
            //await Task.WhenAll(user.Select(x => _userRepository
            //            .AddAsync(new User(x))));
        }
    }
}