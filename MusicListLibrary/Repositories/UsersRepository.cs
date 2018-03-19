using System;
using System.Linq;
using System.Collections.Generic;
using MusicListLibrary.Models;
using System.Linq.Expressions;

namespace MusicListLibrary.Repositories
{
	public sealed class UsersRepository
	{
		/*
		 * NOTE: UserRepository has no Delete Functions
		 */
		private readonly MongoRepository MongoRepository;
		
		public UsersRepository()
		{
				MongoRepository = new MongoRepository();
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
			MongoRepository.UpdateOne<Users>(user);
		}
	}
}
