using System;
using System.Linq;
using MusicListLibrary.Models;
using MusicListLibrary.Repositories;

namespace MusicListLibrary.Controllers
{
	public sealed class MusicsController
	{
		private readonly MusicsRepository repo;
		
		public MusicsController()
		{
			repo = new MusicsRepository();
		}
		
		public bool IsExist(Musics music)
		{
			return repo.FindOne(music) != null;
		}
		
		public void AddMusic(ref Musics music){
			repo.AddOne(ref music);
		}
		
		public void UpdateOne(ref Musics music){
			repo.UpdateOne(ref music);
		}
	}
}