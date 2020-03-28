using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Actio.Common.Commands
{
    public interface ICommandHandler<in T> where T: ICommand
    {
        Task HandleAsync(T command);
    }
}
