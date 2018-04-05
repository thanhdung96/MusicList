using System;
using System.Collections.Generic;
using System.Linq;
using HtmlAgilityPack;
using MusicListLibrary.Models;

namespace WebCrawler
{
	public class MusicCrawler
	{
		private readonly string AddressIndex = "http://m.nhaccuatui.com/tim-kiem/bai-hat?page={0}";
		//replace {0} space with '+'
		private readonly string AddressSongFind = "http://m.nhaccuatui.com/tim-kiem?q={0}";
		private readonly string AddressSingerFind = "http://m.nhaccuatui.com/tim-kiem?q={0}&b=singer&page={1}";
		HtmlWeb web;
		HtmlDocument htmlDoc;
		
		public MusicCrawler()
		{
			web = new HtmlWeb();
			htmlDoc = web.Load(AddressIndex);
		}
		
		public IEnumerable<Musics> GetIndex(int page = 1)
		{
			htmlDoc = web.Load(string.Format(AddressIndex, page));
			return ParseToMusicsObjects();
		}
		
		public IEnumerable<Musics> GetMusicsBySinger(string singer, int page = 1)
		{
			List<Musics> ret = new List<Musics>();
			htmlDoc = web.Load(string.Format(AddressSingerFind, singer.Replace(' ', '+'), page));
			
			return ParseToMusicsObjects();
		}
		
		public IEnumerable<Musics> GetMusicsByName(string name, int page=1){
			List<Musics> ret = new List<Musics>();
			htmlDoc = web.Load(string.Format(AddressSongFind, name.Replace(' ', '+'), page));
			
			return ParseToMusicsObjects();
		}
		
		private IEnumerable<Musics> ParseToMusicsObjects()
		{
			List<Musics> ret = new List<Musics>();
			HtmlNodeCollection MusicItems = this.htmlDoc.DocumentNode.SelectNodes(@"//div[contains(@class,'bgmusic')]");
			foreach (HtmlNode node in MusicItems) {
				Musics MusicItem = new Musics();
				MusicItem.SongName = node.SelectSingleNode(@".//h3/a").InnerText;
				MusicItem.URLWeb = node.SelectSingleNode(@".//h3/a").Attributes["href"].Value;
				MusicItem.URLId = MusicItem.URLWeb.ToString().Split('.').Reverse().ToArray()[1];
				MusicItem.Singers = new MongoDB.Bson.BsonArray();
				StringReformat(ref MusicItem, node.SelectSingleNode(@".//p").InnerText);
				ret.Add(MusicItem);
			}
			return ret.AsEnumerable();
		}
		
		private void StringReformat(ref Musics music, string StringToReformat)
		{
			List<String> split = StringToReformat.Split(' ').ToList();
			//List<string> singers = new List<string>();
			split.RemoveAll(t => t == "");

			//apply listen value to music then remove from list
			music.Listens = int.Parse(split.Last(), System.Globalization.NumberStyles.AllowThousands);
			split.RemoveAt(split.Count - 1);
			
			string singer = "";
			for (int i = 0; i < split.Count; i++) {
				if (i == split.Count - 1 || split[i][split[i].Length - 1] == ',') {		//if í last index in array
					singer += split[i][split[i].Length - 1] == ',' ? " " + split[i].Substring(0, split[i].Length - 1) : " " + split[i];
					//singer += " " + split[i];
					singer = singer.Substring(1);
					music.Singers.Add(singer);
					singer = "";
				} else {		//if lát character in current is , add to list
					singer += " " + split[i];
				}
			}
			//music.Singers.AddRange(singers);
		}
	}
}