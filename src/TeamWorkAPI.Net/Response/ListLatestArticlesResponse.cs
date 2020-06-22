using System.Collections.Generic;

namespace TeamWorkAPI.Net.Response
{
	public sealed class ListLatestArticlesResponse
	{
		public ListLatestArticlesResponse(List<NewsPost> news)
		{
			News = news;
		}

		public List<NewsPost> News { get; }
	}
}