using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using MongoDB.Driver;
using MusicListLibrary.Database;
using MusicListLibrary.Models;

namespace MusicListLibrary.Repositories
{
	internal sealed class MongoRepository:IRepository
	{
		private MongoClient client;
		private IMongoDatabase db;
		string connString;
		
		public MongoRepository()
		{
			connString = "mongodb://client:17247914@ds036617.mlab.com:36617/anipurei";
			client = new MongoClient(connString);
			db = client.GetDatabase("anipurei");
		}
		
		public IQueryable<T> All<T>() where T:class, new()
		{
			String collection = "";
			if(typeof(T) == typeof(Users))
			   collection = "Users";
			else
				collection = typeof(T)==typeof(Musics) ? "Musics" : "Playlist";
			return db.GetCollection<T>(collection).AsQueryable();
		}
		
		public T FindOne<T>(Expression<Func<T, bool>> expression) where T:class, new()
		{
			return All<T>().Where(expression).SingleOrDefault();
		}
		
		public void AddOne<T>(T item) where T:class, new()
		{
			String collection = "";
			if (item is Users)
				collection = "Users";
			else
				collection = item is Musics ? "Musics" : "Playlist";
			db.GetCollection<T>(collection).InsertOne(item);
		}
		
		public void AddMany<T>(IEnumerable<T> items) where T:class, new()
		{
			String collection = "";
			if(typeof(T) == typeof(Users))
			   collection = "Users";
			else
				collection = typeof(T)==typeof(Musics) ? "Musics" : "Playlist";
			db.GetCollection<T>(collection).InsertMany(items);
		}
		
		public void DeleteOne<T>(T item) where T:class, new()
		{
			String collection = "";
			if (item is Users)
				collection = "Users";
			else
				collection = item is Musics ? "Musics" : "Playlist";
			var filter = Builders<T>.Filter.Eq("Id", item.GetType().GetProperty("Id").GetValue(item, null));
			db.GetCollection<T>(collection).DeleteOne(filter);
		}
		
		public void DeleteMany<T>(Expression<Func<T, bool>> expression) where T:class, new()
		{
			IQueryable items = All<T>().Where(expression);
			foreach (T item in items) {
				this.DeleteOne(item);
			}
		}

		public void UpdateOne<T>(T item) where T:class, new()
		{
			String collection = "";
			if (item is Users)
				collection = "Users";
			else
				collection = item is Musics ? "Musics" : "Playlist";
			var filter = Builders<T>.Filter.Eq("Id", item.GetType().GetProperty("Id").GetValue(item, null));
			db.GetCollection<T>(collection).FindOneAndReplace(filter, item);
		}
		
		public void Dispose()
		{
			
		}
	}
}
