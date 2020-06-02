using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Actio.Api.Repositories;
using Actio.Common;
using Actio.Common.Events;

namespace Actio.Api.Handlers
{
    public class ActivityCreatedHandler : IEventHandler<ActivityCreated>
    {
        private readonly IActivityRepository _activityRepository;
        public ActivityCreatedHandler(IActivityRepository activityRepository)
        {
            _activityRepository = activityRepository;
        }
        public async Task HandleAsync(ActivityCreated @event)
        {
            await Task.CompletedTask;
            await _activityRepository.AddAsync();
            Console.WriteLine($"Activity created: {@event.Name}.");
        }
    }
}
