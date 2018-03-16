using System;
using MusicListLibrary.Models;
using MusicListLibrary.Repositories;
using System.Linq;

namespace MusicListLibrary.Database
{
	internal class DbContext
	{
		public readonly UsersRepository Users;
		
		public DbContext(){
			Users = new UsersRepository();
		}
	}
}
