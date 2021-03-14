using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenLeague.Server.Data;
using OpenLeague.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace OpenLeague.Server.Services
{
    public class MemberService : IMemberService
    {
        protected readonly ApplicationDbContext _context;

        public MemberService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Member> GetAsync(int id)
        {
            return await _context.Members.FindAsync(id);
        }

        public async Task<IEnumerable<Member>> GetAllAsync()
        {
            return await _context.Members.ToListAsync();
        }
    }
}
