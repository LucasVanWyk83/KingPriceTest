using KingPriceTest.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace KingPriceTest.DAL.Repositories
{
    public class PermissionRepository : BaseRepository<Permission>
    {
        public PermissionRepository(DbContext baseContext) : base(baseContext)
        {
        }
    }
}