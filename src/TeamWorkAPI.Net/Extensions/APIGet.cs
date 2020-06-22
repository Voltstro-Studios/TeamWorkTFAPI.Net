using System.Net.Http;

namespace TeamWorkAPI.Net.Extensions
{
	internal static class APIGet
	{
		internal static string GetJsonData(this HttpClient client, string url)
		{
			HttpResponseMessage responseMessage = client.GetAsync(url).Result;
			string jsonResult = responseMessage.Content.ReadAsStringAsync().Result;

			return jsonResult;
		}
	}
}