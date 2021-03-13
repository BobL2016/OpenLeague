using OpenLeague.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenLeague.Server.Services
{
    public interface IScheduleItemService
    {
        Task<IEnumerable<ScheduleItem>> GetAllAsync();
        Task<ScheduleItem> GetAsync(int id);
    }
}