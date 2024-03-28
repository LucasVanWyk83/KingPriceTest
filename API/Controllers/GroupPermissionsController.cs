using Microsoft.AspNetCore.Mvc;
using KingPriceTest.BLL.Models;
using KingPriceTest.DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace KingPriceTest.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GroupPermissionsController : ControllerBase
    {
		private readonly ILogger<GroupPermissionsController> _logger;
        private readonly KingPriceTestDbContext _context;

        public GroupPermissionsController(KingPriceTestDbContext context, ILogger<GroupPermissionsController> logger)
        {
			_logger = logger;
            _context = context;
        }

        // GET: api/GroupPermissions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GroupPermission>> GetGroupPermissions(int id)
        {
            var groupPermission = await _context.GroupPermission.FindAsync(id);

            if (groupPermission == null)
            {
                return NotFound();
            }

            return groupPermission;
        }

        // PUT: api/GroupPermissions/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserGroup(int id, GroupPermission groupPermission)
        {
            if (id != groupPermission.Id)
            {
                return BadRequest();
            }

            _context.Entry(groupPermission).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GroupPermissionExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/GroupPermissions
        [HttpPost]
        public async Task<ActionResult<GroupPermission>> PostGroupPermission(GroupPermission groupPermission)
        {
            _context.GroupPermission.Add(groupPermission);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserGroups", new { id = groupPermission.Id }, groupPermission);
        }

        // DELETE: api/GroupPermissions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<GroupPermission>> DeleteGroupPermission(int id)
        {
            var groupPermission = await _context.GroupPermission.FindAsync(id);
            if (groupPermission == null)
            {
                return NotFound();
            }

            _context.GroupPermission.Remove(groupPermission);
            await _context.SaveChangesAsync();

            return groupPermission;
        }

        private bool GroupPermissionExists(int id)
        {
            return _context.GroupPermission.Any(e => e.Id == id);
        }
	}
}
