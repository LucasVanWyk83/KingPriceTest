using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KingPriceTest.DAL.Models
{
    public class Permission
    {
		public int Id {get; set;}
		
		[MaxLength(100)]
        public string Name { get; set; }
		
		public DateTime CreatedDateTime { get; set; }
		
		public DateTime? UpdatedDateTime { get; set; }
		
		public Permission()
        {
        }

        public Permission(int id, string name)
        {
            Id = id;
			Name = name;
			CreatedDateTime = id ==null ? DateTime.Now : CreatedDateTime;
			UpdatedDateTime = id ==null ? null : DateTime.Now;
			
        }
		
		public Permission(int id, string name, DateTime? createdDateTime, DateTime? updatedDateTime)
        {
            Id = id;
			Name = name;
			
			CreatedDateTime = createdDateTime ==null ? CreatedDateTime : DateTime.Now;
			UpdatedDateTime = updatedDateTime ==null ? null : DateTime.Now;
        }
    }
}
