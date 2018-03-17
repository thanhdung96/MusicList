using System;
using MusicListLibrary.Models;
using MusicListLibrary.Repositories;
using System.Linq;

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
			return repo.FindOne(user) == null;
		}
		
		public bool AddUser(ref Users user)
		{
			if (!this.IsExist(user)) {
				repo.AddOne(user);
				return true;
			}
			return false;
		}
		
		public bool UpdateUser(ref Users user)
		{
			if (!this.IsExist(user)) {
				repo.UpdateOne(user);
				return true;
			}
			return false;
		}
	}
}