using System;
using MongoDB.Bson;

namespace MusicListLibrary.Models
{
	public sealed class Users
	{
		public ObjectId Id{get;set;}
		public String Fullname{get;set;}
		public String Email{get;set;}
		public bool Gender{get;set;}
		public DateTime DOB{get;set;}
		public bool Disabled{get;set;}
		
		public Users(){
			this.DOB=DateTime.Today;
			this.Disabled=false;
		}
	}
}
