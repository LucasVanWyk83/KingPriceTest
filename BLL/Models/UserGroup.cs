using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using KingPriceTest.BLL.Models.Common;

namespace KingPriceTest.BLL.Models
{
    public class UserGroup : BaseEntity
    {
		[ForeignKey("User")]
		public int UserId {get; set;}
		
		[ForeignKey("Group")]
		public int GroupId {get; set;}
    }
}
