using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Actio.Common.Events
{
    interface IAuthenticatedEvent : IEvent
    {
        Guid UserId { get; set; }
    }
}
