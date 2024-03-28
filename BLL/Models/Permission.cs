using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using KingPriceTest.BLL.Models.Common;

namespace KingPriceTest.BLL.Models
{
    public class Permission : BaseEntity
    {
		[MaxLength(100)]
        public string Name { get; set; }
    }
}
