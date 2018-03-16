using System;
using System.Linq;
using MusicListLibrary.Models;

namespace MusicListLibrary.Repositories
{
	public class UsersRepository
	{
		private readonly MongoRepository MongoRepository;
		
		public UsersRepository()
		{
			MongoRepository = new MongoRepository();
		}
		
		public IQueryable All(){
			return MongoRepository.All<Users>();
		}
		
		public Users FindOne(Users user){
			return MongoRepository.FindOne<Users>(u => u.Email == user.Email);
		}
		
		public void AddOne(Users user){
			MongoRepository.AddOne<Users>(user);
		}
		
		public void UpdateOne(Users user){
			
		}
	}
}
