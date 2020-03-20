using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Actio.Common.Commands
{
    interface IAuthenticatedCommand
    {
        Guid UserId { get; set; }
    }
}
