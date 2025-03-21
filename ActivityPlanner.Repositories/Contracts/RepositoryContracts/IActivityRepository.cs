﻿using ActivityPlanner.Entities.DTOs.Activity;
using ActivityPlanner.Entities.Enums;
using ActivityPlanner.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityPlanner.Repositories.Contracts.RepositoryContracts
{
    public interface IActivityRepository : IRepositoryBase<Activity>
    {
        Task<List<Activity>> GetAllActivitiesAsync(bool trackChanges);
        
        Task<Activity> GetOneActivityAsync(int id, bool trackChanges);
        Task<Activity> GetOneActivityAsync(string userName, string activityName,bool trackChanges);
        Task<List<Activity>> GetAllActivitiesWithUserAsync(bool trackChanges, string userName);
        void CreateOneActivitiy(Activity activity);
        void UpdateOneActivitiy(Activity activity);
        void DeleteOneActivitiy(Activity activity);

        Task ChangeActivityAttendanceStatusCountAsync(int activityId, AttendanceStatus status);

    }
}
