using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using KingPriceTest.BLL.Models.Common;

namespace KingPriceTest.BLL.Models
{
    public class User : BaseEntity
    {
		[MaxLength(100)]
        public string FirstName { get; set; }
        
		[MaxLength(100)]
        public string LastName { get; set; }
		
		[MaxLength(100)]
        public string Email { get; set; }
		
		[MaxLength(50)]
        public string Password { get; set; }
 
        public bool Approved { get; set; } = false;
		
       
        [NotMapped]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}
