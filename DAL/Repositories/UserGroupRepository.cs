using KingPriceTest.BLL.Models;
using Microsoft.EntityFrameworkCore;

namespace KingPriceTest.DAL.Repositories
{
    public class UserGroupRepository : BaseRepository<UserGroup>
    {
        public UserGroupRepository(DbContext baseContext) : base(baseContext)
        {
        }
    }
}