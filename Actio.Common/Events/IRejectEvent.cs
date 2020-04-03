using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Actio.Common.Events
{
    interface IRejectEvent: IEvent
    {
        string Email { get; }
        string Reason { get; }
        string Code { get; }
    }
}
