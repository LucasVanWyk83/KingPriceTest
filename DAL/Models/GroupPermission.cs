using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KingPriceTest.DAL.Models
{
    public class GroupPermission
    {
		public int Id {get; set;}
		
		public int GroupId {get; set;}
		
        public int PermissionId { get; set; }
		
		public DateTime CreatedDateTime { get; set; }
		
		public DateTime? UpdatedDateTime { get; set; }
		
		public GroupPermission()
        {
        }
		
		public GroupPermission(int id, int groupId, int permissionId)
        {
            Id = id;
			GroupId = groupId;
			PermissionId = permissionId;
			CreatedDateTime = id ==null ? DateTime.Now : CreatedDateTime;
			UpdatedDateTime = id ==null ? null : DateTime.Now;
        }
		
		public GroupPermission(int id, int groupId, int permissionId, DateTime? createdDateTime, DateTime? updatedDateTime)
        {
            Id = id;
			GroupId = groupId;
			PermissionId = permissionId;
			CreatedDateTime = createdDateTime ==null ? CreatedDateTime : DateTime.Now;
			UpdatedDateTime = updatedDateTime ==null ? null : DateTime.Now;
		}
    }
}
