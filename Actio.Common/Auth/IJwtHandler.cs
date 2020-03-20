using Microsoft.IdentityModel.JsonWebTokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Actio.Common.Auth
{
    interface IJwtHandler
    {
        JsonWebToken Create(Guid userId);
    }
}
