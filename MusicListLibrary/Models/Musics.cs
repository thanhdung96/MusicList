using System;
using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MusicListLibrary.Models
{
	[BsonIgnoreExtraElements]
	[Serializable]
	public sealed class Musics
	{
		[BsonRequired]
		[BsonIdAttribute]
		public ObjectId Id{get;set;}
		[BsonRequired]
		[BsonDefaultValue(null)]
		public BsonString SongName{get;set;}
		[BsonRequired]
		[BsonDefaultValue(null)]
		public BsonArray Singers{get;set;}
		[BsonRequired]
		[BsonDefaultValue(0)]
		public BsonInt32 Listens{get;set;}
		[BsonRequired]
		[BsonDefaultValue(null)]
		public BsonString URLId{get;set;}
		[BsonRequired]
		[BsonDefaultValue(null)]
		public BsonString URLWeb{get;set;}
		[BsonDefaultValue(null)]
		public BsonString URLData{get;set;}
		
		[BsonConstructor]
		public Musics()
		{
			
		}
	}
}
