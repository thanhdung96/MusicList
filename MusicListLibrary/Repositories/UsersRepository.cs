using System;
using System.Linq;
using System.Collections.Generic;
using MusicListLibrary.Models;

namespace MusicListLibrary.Repositories
{
	public sealed class UsersRepository
	{
		private readonly MongoRepository MongoRepository;
		
		public UsersRepository()
		{
				MongoRepository = new MongoRepository();
		}
		
		public List<Users> All()
		{
			return MongoRepository.All<Users>().ToList();
		}
		
		public Users FindOne(Users user)
		{
			return MongoRepository.FindOne<Users>(u => u.Email == user.Email);
		}
		
		public void AddOne(Users user)
		{
			MongoRepository.AddOne<Users>(user);
		}
		
		public void UpdateOne(Users user)
		{
			
		}
	}
}
