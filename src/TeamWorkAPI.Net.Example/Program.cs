using System;
using System.IO;
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
			}

			Console.ReadKey();
		}
	}
}