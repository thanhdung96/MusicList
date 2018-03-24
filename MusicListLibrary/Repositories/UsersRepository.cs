using System;
using System.Linq;
using MusicListLibrary.Models;

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
			if(user.Password!=null)
				return MongoRepository.FindOne<Users>(u => u.Email == user.Email && u.Password == user.Password);
			else
				return MongoRepository.FindOne<Users>(u => u.Email == user.Email);
		}
		
		public void AddOne(ref Users user)
		{
			MongoRepository.AddOne<Users>(user);
		}
		
		public void UpdateOne(ref Users user)
		{
			MongoRepository.UpdateOne<Users>(user);
		}
	}
}
