using System;

namespace TeamWorkAPI.Net
{
	/// <summary>
	/// Provides API settings for the library to use
	/// </summary>
	/// <exception cref="ArgumentNullException">Occurs when the API key passed in is null or white space</exception>
	public sealed class APISettings
	{
		public APISettings(string apiKey)
		{
			if(string.IsNullOrWhiteSpace(apiKey))
				throw new ArgumentNullException(nameof(apiKey), "The API key cannot be null or white space!");

			ApiKey = apiKey;
		}

		/// <summary>
		/// API Key to use
		/// </summary>
		public string ApiKey { get; }
	}
}