using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KingPriceTest.DAL.Models
{
    public class User
    {
		public int Id {get; set;}
		
		[MaxLength(100)]
        public string FirstName { get; set; }
        
		[MaxLength(100)]
        public string LastName { get; set; }
		
		[MaxLength(100)]
        public string Email { get; set; }
		
		[MaxLength(50)]
        public string Password { get; set; }
 
        public bool Approved { get; set; } = false;
		
        public DateTime CreatedDateTime { get; set; }
		
		public DateTime? UpdatedDateTime { get; set; }
		
        [NotMapped]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
		
		public User()
        {
        }

        public User(int id, string firstName, string lastName, string email, string password, bool approved)
        {
            Id = id;
			FirstName = firstName;
			LastName = lastName;
			Email = email;
			Password = password;
			Approved = approved;
			CreatedDateTime = id ==null ? DateTime.Now : CreatedDateTime;
			UpdatedDateTime = id ==null ? null : DateTime.Now;
        }
		
		public User(int id, string firstName, string lastName, string email, string password, bool approved, DateTime createdDateTime, DateTime? updatedDateTime)
        {
            Id = id;
			FirstName = firstName;
			LastName = lastName;
			Email = email;
			Password = password;
			Approved = approved;
			CreatedDateTime = createdDateTime;
			UpdatedDateTime = updatedDateTime == null ? null : DateTime.Now;
        }
    }
}
