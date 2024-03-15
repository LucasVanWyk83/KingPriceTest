using KingPriceTest.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace KingPriceTest.DAL.Repositories
{
    public class UserRepository : BaseRepository<User>
    {
        public UserRepository(DbContext baseContext) : base(baseContext)
        {
        }
    }
}