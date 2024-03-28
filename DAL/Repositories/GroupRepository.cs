using KingPriceTest.BLL.Models;
using Microsoft.EntityFrameworkCore;

namespace KingPriceTest.DAL.Repositories
{
    public class GroupRepository : BaseRepository<Group>
    {
        public GroupRepository(DbContext baseContext) : base(baseContext)
        {
        }
    }
}