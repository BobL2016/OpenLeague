using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenLeague.Server.Data;
using OpenLeague.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace OpenLeague.Server.Services
{
    public class ScheduleItemService : IScheduleItemService
    {
        public readonly ApplicationDbContext _context;

        public ScheduleItemService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ScheduleItem> GetAsync(int id)
        {
            return await _context.ScheduleItems.FindAsync(id);
        }

        public async Task<IEnumerable<ScheduleItem>> GetAllAsync()
        {
            return await _context.ScheduleItems.ToListAsync();
        }

    }
}
