using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using TeamWorkAPI.Net.Response;

namespace TeamWorkAPI.Net
{
	/// <summary>
	/// Retrieve news articles from Team Fortress 2 related websites.
	/// </summary>
	public sealed class News
	{
		internal News(APISettings settings, HttpClient client)
		{
			this.settings = settings;
			this.client = client;
		}

		private readonly APISettings settings;

		private readonly HttpClient client;

		private string ArticlesApiEndpoint => $"https://teamwork.tf/api/v1/news?key={settings.ApiKey}";

		/// <summary>
		/// Get an overview of the last 20 news items posted
		/// <para>All these news items are also displayed on the site at news</para>
		/// </summary>
		/// <exception cref="Exception">Occurs when the Json deserialization fails.</exception>
		public ListLatestArticlesResponse ListLatestArticles()
		{
			//Get a response from the server
			HttpResponseMessage responseMessage = client.GetAsync(ArticlesApiEndpoint).Result;
			string jsonResult = responseMessage.Content.ReadAsStringAsync().Result;

			try
			{
				List<NewsPost> searchResponse =
					JsonConvert.DeserializeObject<List<NewsPost>>(jsonResult);

				ListLatestArticlesResponse response = new ListLatestArticlesResponse(searchResponse);

				return response;
			}
			catch (JsonSerializationException)
			{
				throw new Exception("Json deserialization failed! This could be because of malformed data or the API key is incorrect!");
			}
		}
	}
}