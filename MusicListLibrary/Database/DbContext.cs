using System;
using MusicListLibrary.Repositories;
using System.Linq;

namespace MusicListLibrary.Database
{
	internal sealed class DbContext
	{
		public readonly UsersRepository Users;
		
		public DbContext(){
			Users = new UsersRepository();
		}
	}
}
