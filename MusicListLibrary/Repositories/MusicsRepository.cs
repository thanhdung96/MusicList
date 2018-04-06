using System;
using System.Linq;
using MusicListLibrary.Models;

namespace MusicListLibrary.Repositories
{
	
	/*
	 * NOTE: no delete method
	 */
	public sealed class MusicsRepository
	{
		private readonly MongoRepository MongoRepository;
		
		public MusicsRepository()
		{
			MongoRepository = new MongoRepository();
		}
		
		public Musics FindOne(Musics music)
		{
			return MongoRepository.FindOne<Musics>(m => m.URLId.Equals(music.URLId));
		}
		
		public void AddOne(ref Musics music)
		{
			MongoRepository.AddOne<Musics>(music);
		}
		
		public void UpdateOne(ref Musics music)
		{
			MongoRepository.UpdateOne<Musics>(music);
		}
	}
}

