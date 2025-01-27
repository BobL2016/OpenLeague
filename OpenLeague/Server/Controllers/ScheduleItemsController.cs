﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OpenLeague.Server.Data;
using OpenLeague.Shared.Models;
using OpenLeague.Server.Services;

namespace OpenLeague.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScheduleItemsController : ControllerBase
    {
        private readonly IScheduleItemService _scheduleItemService;

        public ScheduleItemsController(IScheduleItemService scheduleItemService)
        {
            _scheduleItemService = scheduleItemService;
        }

        // GET: api/ScheduleItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ScheduleItem>>> GetScheduleItems()
        {
            return new ObjectResult(await _scheduleItemService.GetAllAsync());
        }

        // GET: api/ScheduleItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ScheduleItem>> GetScheduleItem(int id)
        {
            //var scheduleItem = await _context.ScheduleItems.FindAsync(id);

            var scheduleItem = await _scheduleItemService.GetAsync(id);

            if (scheduleItem == null)
            {
                return NotFound();
            }

            return new ObjectResult(scheduleItem);
        }

        //// PUT: api/ScheduleItems/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutScheduleItem(int id, ScheduleItem scheduleItem)
        //{
        //    if (id != scheduleItem.ID)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(scheduleItem).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ScheduleItemExists(id))
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

        //// POST: api/ScheduleItems
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<ScheduleItem>> PostScheduleItem(ScheduleItem scheduleItem)
        //{
        //    _context.ScheduleItems.Add(scheduleItem);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetScheduleItem", new { id = scheduleItem.ID }, scheduleItem);
        //}

        //// DELETE: api/ScheduleItems/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteScheduleItem(int id)
        //{
        //    var scheduleItem = await _context.ScheduleItems.FindAsync(id);
        //    if (scheduleItem == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.ScheduleItems.Remove(scheduleItem);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        private bool ScheduleItemExists(int id)
        {
            //return _context.ScheduleItems.Any(e => e.ID == id);
            return Seeds.ScheduleItems.Any(scheduleItem => scheduleItem.Id == id);
        }
    }
}
