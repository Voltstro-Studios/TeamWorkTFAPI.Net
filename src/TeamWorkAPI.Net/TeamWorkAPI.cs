using System.Net.Http;

namespace TeamWorkAPI.Net
{
	public sealed class TeamWorkAPI
	{
		public TeamWorkAPI(APISettings settings, HttpClient client = null)
		{
			client = client ?? new HttpClient();
			News = new News(settings, client);
			Creators = new Creators(settings, client);
		}

		/// <summary>
		/// Retrieve news articles from Team Fortress 2 related websites.
		/// </summary>
		public News News { get; }

		/// <summary>
		/// Retrieve information about creators from Teamwork.tf.
		/// </summary>
		public Creators Creators { get; }
	}
}