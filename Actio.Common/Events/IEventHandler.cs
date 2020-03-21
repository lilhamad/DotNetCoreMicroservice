using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Actio.Common.Events
{
    interface IEventHandler<in T> where T : IEvent
    {
        Task HandleAsync(T command);
    }
}
