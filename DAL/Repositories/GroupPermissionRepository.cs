using KingPriceTest.BLL.Models;
using Microsoft.EntityFrameworkCore;

namespace KingPriceTest.DAL.Repositories
{
    public class GroupPermissionRepository : BaseRepository<GroupPermission>
    {
        public GroupPermissionRepository(DbContext baseContext) : base(baseContext)
        {
        }
    }
}