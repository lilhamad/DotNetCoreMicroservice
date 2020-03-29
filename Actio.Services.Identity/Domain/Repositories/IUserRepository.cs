﻿using IdentityService_Microservice.Actio.Services.Identity.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityService_Microservice.Actio.Services.Identity.Domain.Repositories
{
    interface IUserRepository
    {
        Task<User> GetAsync(Guid Id);
        Task<User> GetAsync(string email);
        Task AddAsync(User user);
    }
}