using System.ComponentModel.DataAnnotations;

namespace KingPriceTest.BLL.Models.Common
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
		
		public DateTime CreatedDateTime { get; set; }
		
		public DateTime? UpdatedDateTime { get; set; }
		
    }
}
