using System;
using System.Threading.Tasks;
using Actio.Common.Exceptions;
using net_microservices.Actio.Services.Activities.Domain.Models;
using net_microservices.Actio.Services.Activities.Domain.Repositories;

namespace Actio.Services.Activities.Services
{
    // this class is to store activities
    public class ActivityService : IActivityService
    {
        private readonly IActivityRepository _activityRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ActivityService(IActivityRepository activityRepository,
            ICategoryRepository categoryRepository)
        {
            _activityRepository = activityRepository;
            _categoryRepository = categoryRepository;
        }

        public async Task AddAsync(Guid id, Guid userId, string category,
            string name, string description, DateTime createdAt)
        {
            var activityCategory = await _categoryRepository.GetAsync(category);
            //check if activityCategory exist else create a new one
            if (activityCategory == null)
            {
                throw new ActioException("category_not_found",
                    $"Category: '{category}' was not found.");
            }
            //create a new Activity object
            var activity = new Activity(id, activityCategory, userId,
                name, description, createdAt);
            //add the new Activity object
            await _activityRepository.AddAsync(activity);
        }
    }
}