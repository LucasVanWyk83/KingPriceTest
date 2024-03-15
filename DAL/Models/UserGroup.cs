using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KingPriceTest.DAL.Models
{
    public class UserGroup
    {
		public int Id {get; set;}
		
		public int UserId {get; set;}
		
		public int GroupId {get; set;}
		
		public DateTime CreatedDateTime { get; set; }
		
		public DateTime? UpdatedDateTime { get; set; }
		
		public UserGroup()
        {
        }
		
		public UserGroup(int id, int userId, int groupId)
        {
            Id = id;
			UserId = userId;
			GroupId = groupId;
			CreatedDateTime = id ==null ? DateTime.Now : CreatedDateTime;
			UpdatedDateTime = id ==null ? null : DateTime.Now;
        }
		
		public UserGroup(int id, int userId, int groupId, DateTime? createdDateTime, DateTime? updatedDateTime)
        {
            Id = id;
			UserId = userId;
			GroupId = groupId;
			CreatedDateTime = createdDateTime ==null ? CreatedDateTime : DateTime.Now;
			UpdatedDateTime = updatedDateTime ==null ? null : DateTime.Now;
		}
    }
}
