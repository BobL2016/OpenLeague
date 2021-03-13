using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenLeague.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using OpenLeague.Shared.Models;

namespace OpenLeague.Server.Services
{
    public class MemberServiceMock : IMemberService
    {
        public async Task<IEnumerable<Member>> GetAllAsync()
        {
            return await Task.FromResult(Seeds.Members.ToList<Member>());
        }

        public async Task<Member> GetAsync(int id)
        {
            return await Task.FromResult(Seeds.Members.Where(member => member.ID == id).FirstOrDefault());
        }
    }
}
