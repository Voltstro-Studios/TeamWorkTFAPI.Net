using System;
using System.Net.Http;
using Newtonsoft.Json;
using TeamWorkAPI.Net.Extensions;
using TeamWorkAPI.Net.Items;

namespace TeamWorkAPI.Net
{
	public sealed class Creators
	{
		internal Creators(APISettings settings, HttpClient client)
		{
			this.settings = settings;
			this.client = client;
		}

		private readonly APISettings settings;

		private readonly HttpClient client;

		private string FindYouTubeCreatorAPIEndpoint => $"https://teamwork.tf/api/v1/youtube-creator/steamid/%steamid%?key={settings.ApiKey}";

		/// <summary>
		/// Search for a specific YouTube creator that is listed on the website based on their SteamID64
		/// </summary>
		/// <param name="steamId"></param>
		/// <returns></returns>
		public YouTuber[] GetYoutuber(string steamId)
		{
			string jsonResult = client.GetJsonData(FindYouTubeCreatorAPIEndpoint.Replace("%steamid%", steamId));
			try
			{
				YouTuber[] result = JsonConvert.DeserializeObject<YouTuber[]>(jsonResult);
				return result;
			}
			catch (JsonSerializationException)
			{
				throw new Exception("Json deserialization failed! This could be because of malformed data or the API key is incorrect!");
			}
		}
	}
}