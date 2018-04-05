using System;
using System.Linq;
using MusicListLibrary.Models;
using MusicListLibrary.Repositories;

namespace MusicListLibrary.Controllers
{
	public sealed class UsersController
	{
		private readonly UsersRepository repo;
		
		public UsersController()
		{
			repo = new UsersRepository();
		}
		
		public bool IsExist(Users user)
		{
			Users find = new Users(user);
			find.Password = null;
			return repo.FindOne(find) != null;
		}
		
		public Users Login(ref Users user)
		{
			return repo.FindOne(user);
		}
		
		public bool AddUser(ref Users user)
		{
			if (!this.IsExist(user)) {
				repo.AddOne(ref user);
				return true;
			}
			return false;
		}
		
		public void UpdateUser(ref Users user)
		{
			repo.UpdateOne(ref user);
		}
	}
}