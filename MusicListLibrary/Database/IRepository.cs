using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MusicListLibrary.Database
{
	internal interface IRepository:IDisposable
	{
		IQueryable<T> All<T>() where T:class, new();
		T FindOne<T>(Expression<Func<T, bool>> expression) where T:class, new();
		void AddOne<T>(T item) where T:class, new();
		void AddMany<T>(IEnumerable<T> items) where T:class, new();
		void DeleteOne<T>(T item) where T:class, new();
		void DeleteMany<T>(Expression<Func<T, bool>> expression) where T:class, new();
		void UpdateOne<T>(T item) where T:class, new();
	}
}
