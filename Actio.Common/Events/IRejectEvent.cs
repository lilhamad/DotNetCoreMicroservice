using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Actio.Common.Events
{
    interface IRejectEvent: IEvent
    {
        public string Email { get; }
        public string Reason { get; }
        public string Code { get; }
    }
}
