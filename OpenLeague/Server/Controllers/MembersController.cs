using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OpenLeague.Server.Data;
using OpenLeague.Shared.Models;
using OpenLeague.Server.Services;
using Microsoft.AspNetCore.Authorization;

namespace OpenLeague.Server.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController : ControllerBase
    {
        private readonly IMemberService _memberService;

        public MembersController(IMemberService memberService)
        {
            _memberService = memberService;
        }

        // GET: api/Members
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Member>>> GetMembers()
        {
            return new ObjectResult(await _memberService.GetAllAsync());
            //return await _context.Members.ToListAsync();
        }

        // GET: api/Members/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Member>> GetMember(int id)
        {

            var member = await _memberService.GetAsync(id);

            if (member == null)
            {
                return NotFound();
            }

            return new ObjectResult(Task.FromResult(member));
        }

        //// PUT: api/Members/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutMember(int id, Member member)
        //{
        //    if (id != member.ID)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(member).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!MemberExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Members
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Member>> PostMember(Member member)
        //{
        //    _context.Members.Add(member);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetMember", new { id = member.ID }, member);
        //}

        //// DELETE: api/Members/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteMember(int id)
        //{
        //    var member = await _context.Members.FindAsync(id);
        //    if (member == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Members.Remove(member);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        private bool MemberExists(int id)
        {

            return Seeds.Members.Any(e => e.Id == id);
            //return _context.Members.Any(e => e.ID == id);
        }
    }
}
