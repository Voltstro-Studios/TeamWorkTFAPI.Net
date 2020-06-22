using System;
using System.IO;
using TeamWorkAPI.Net.Items;
using TeamWorkAPI.Net.Response;

namespace TeamWorkAPI.Net.Example
{
	public class Program
	{
		public static void Main()
		{
			TeamWorkAPI teamWorkAPI = new TeamWorkAPI(new APISettings(File.ReadAllText("apikey.txt")));
			ListLatestArticlesResponse response = teamWorkAPI.News.ListLatestArticles();

			foreach (NewsPost post in response.News)
			{
				Console.WriteLine($"{post.Title}  (@{post.CreatedAtInfo.Date})");
				Console.WriteLine(post.Hash);
			}

			Console.WriteLine("\n=== Getting a news post ===\n");

			//Get a news article
			NewsPost newsPost = teamWorkAPI.News.GetSpecificArticle("a60761dd5cf0ad6922fecb1ef0e3250d");
			Console.WriteLine(newsPost.Title);

			Console.WriteLine("\n=== Getting a YouTuber ===\n");

			//Get a YouTuber
			YouTuber[] youTuber = teamWorkAPI.Creators.GetYoutuber("76561198072335402");
			foreach (YouTuber item in youTuber)
			{
				Console.WriteLine($"{item.Name} ({item.YouTubeAccount})");
			}

			Console.ReadKey();
		}
	}
}