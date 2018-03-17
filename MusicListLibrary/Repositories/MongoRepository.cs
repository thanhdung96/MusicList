using System;
using System.Configuration;
using MusicListLibrary.Database;
using System.Collections.Generic;
using MongoDB.Driver;
using System.Linq;
using System.Linq.Expressions;
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
			return typeof(T) != typeof(Users) ? db.GetCollection<T>("Playlists").AsQueryable() : db.GetCollection<T>("Users").AsQueryable();
		}
		
		public T FindOne<T>(Expression<Func<T, bool>> expression) where T:class, new()
		{
			return All<T>().Where(expression).SingleOrDefault();
		}
		
		public void AddOne<T>(T item) where T:class, new()
		{
			String collectionName = item is Users ? "Users" : "Playlists";
			db.GetCollection<T>(collectionName).InsertOne(item);
		}
		
		public void AddMany<T>(IEnumerable<T> items) where T:class, new()
		{
			String collectionName = typeof(T) == typeof(Users) ? "Users" : "Playlists";
			db.GetCollection<T>(collectionName).InsertMany(items);
		}
		
		public void DeleteOne<T>(T item) where T:class, new()
		{
			String collectionName = item is Users ? "Users" : "Playlists";
			var filter = Builders<T>.Filter.Eq("Id", item.GetType().GetProperty("Id").GetValue(item, null));
			db.GetCollection<T>(collectionName).DeleteOne(filter);
		}
		
		public void DeleteMany<T>(Expression<Func<T, bool>> expression) where T:class, new()
		{
			IQueryable items = All<T>().Where(expression);
			String collectionName = typeof(T) == typeof(Users) ? "Users" : "Playlists";
			foreach (T item in items) {
				this.DeleteOne(item);
			}
		}

		public void UpdateOne<T>(T item) where T:class, new()
		{
			String collectionName = item is Users ? "Users" : "Playlists";
			var filter = Builders<T>.Filter.Eq("Id", item.GetType().GetProperty("Id").GetValue(item, null));
			db.GetCollection<T>(collectionName).FindOneAndReplace(filter, item);
		}
		
		public void Dispose()
		{
			
		}
	}
}
