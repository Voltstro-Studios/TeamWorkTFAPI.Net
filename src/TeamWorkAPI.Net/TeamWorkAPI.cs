using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace TeamWorkAPI.Net
{
	public sealed class TeamWorkAPI
	{
		public TeamWorkAPI(APISettings settings, HttpClient client = null)
		{
			client = client ?? new HttpClient();
			News = new News(settings, client);
		}

		/// <summary>
		/// Retrieve news articles from Team Fortress 2 related websites.
		/// </summary>
		public News News { get; }
	}
}