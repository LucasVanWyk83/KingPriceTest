using Microsoft.AspNetCore.Mvc;
using KingPriceTest.BLL.Models;
using KingPriceTest.DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace KingPriceTest.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserGroupsController : ControllerBase
    {
		private readonly ILogger<UserGroupsController> _logger;
        private readonly KingPriceTestDbContext _context;

        public UserGroupsController(KingPriceTestDbContext context, ILogger<UserGroupsController> logger)
        {
			_logger = logger;
            _context = context;
        }

        // GET: api/UsersGroups/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserGroup>> GetUserGroups(int id)
        {
            var userGroup = await _context.UserGroup.FindAsync(id);

            if (userGroup == null)
            {
                return NotFound();
            }

            return userGroup;
        }

        // PUT: api/UserGroups/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserGroup(int id, UserGroup userGroup)
        {
            if (id != userGroup.Id)
            {
                return BadRequest();
            }

            _context.Entry(userGroup).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsersGroupsExists(id))
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

        // POST: api/UserGroups
        [HttpPost]
        public async Task<ActionResult<UserGroup>> PostUserGroup(UserGroup userGroup)
        {
            _context.UserGroup.Add(userGroup);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserGroups", new { id = userGroup.Id }, userGroup);
        }

        // DELETE: api/UsersGroups/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<UserGroup>> DeleteUserGroup(int id)
        {
            var userGroup = await _context.UserGroup.FindAsync(id);
            if (userGroup == null)
            {
                return NotFound();
            }

            _context.UserGroup.Remove(userGroup);
            await _context.SaveChangesAsync();

            return userGroup;
        }

        private bool UsersGroupsExists(int id)
        {
            return _context.UserGroup.Any(e => e.Id == id);
        }
	}
}
