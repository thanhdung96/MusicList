using System;
using MongoDB.Bson;

namespace MusicListLibrary.Models
{
	public sealed class Users
	{
		public ObjectId Id{ get; set; }
		public BsonString Fullname{ get; set; }
		public BsonString Email{ get; set; }
		public BsonString Password{ get; set; }
		public BsonBoolean Gender{ get; set; }
		public BsonDateTime DOB{ get; set; }
		public BsonBoolean Disabled{ get; set; }
		public BsonDateTime TimeStamp{ get; set; }
		
		public Users()
		{
			this.DOB = DateTime.Today;
			this.Disabled = false;
		}
		
		public Users(Users user)
		{
			this.Id = user.Id;
			this.Fullname = user.Fullname;
			this.Email = user.Email;
			this.Password = user.Password;
			this.Gender = user.Gender;
			this.DOB = user.DOB;
			this.Disabled = user.Disabled;
			this.TimeStamp = user.TimeStamp;
		}
	}
}
