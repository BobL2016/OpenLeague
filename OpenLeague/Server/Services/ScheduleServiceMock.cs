using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenLeague.Shared.Models;
using OpenLeague.Server.Data;

namespace OpenLeague.Server.Services
{
    public class ScheduleServiceMock : IScheduleItemService
    {
        public async Task<ScheduleItem> GetAsync(int id)
        {
            return await Task.FromResult(Seeds.ScheduleItems.Where(scheduleItem => scheduleItem.ID == id).FirstOrDefault());
        }

        public async Task<IEnumerable<ScheduleItem>> GetAllAsync()
        {
            return await Task.FromResult(Seeds.ScheduleItems.ToList());
        }
    }
}
