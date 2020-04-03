using System;

namespace Actio.Common.Auth
{
    interface IJwtHandler
    {
        JsonWebToken Create(Guid userId);
    }
}
