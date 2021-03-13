using OpenLeague.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenLeague.Server.Services
{
    public interface IMemberService
    {
        Task<IEnumerable<Member>> GetAllAsync();
        Task<Member> GetAsync(int id);
    }
}