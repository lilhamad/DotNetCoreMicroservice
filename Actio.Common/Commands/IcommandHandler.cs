using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Actio.Common.Commands
{
    interface IcommandHandler<in T> where T: Icommand
    {
        Task HandleAsync(T command);
    }
}
