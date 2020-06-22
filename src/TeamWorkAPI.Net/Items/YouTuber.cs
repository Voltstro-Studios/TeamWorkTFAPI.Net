using Newtonsoft.Json;

namespace TeamWorkAPI.Net.Items
{
	public sealed class YouTuber
	{
		/// <summary>
		/// The ID of the YouTuber
		/// </summary>
		[JsonProperty("id")] public readonly int Id;

		/// <summary>
		/// A link to this YouTuber's Teamwork.tf profile
		/// </summary>
		[JsonProperty("link")] public readonly string Link;

		/// <summary>
		/// The name of this YouTuber
		/// </summary>
		[JsonProperty("name")] public readonly string Name;

		/// <summary>
		/// The type of content this YouTuber does
		/// </summary>
		[JsonProperty("type")] public readonly string Type;

		/// <summary>
		/// Who does this YouTuber main?
		/// </summary>
		[JsonProperty("main")] public readonly string Main;

		/// <summary>
		/// This YouTuber's YouTube account
		/// </summary>
		[JsonProperty("youtube_acc")] public readonly string YouTubeAccount;

		/// <summary>
		/// This YouTuber's Twitch account
		/// </summary>
		[JsonProperty("twitch_acc")] public readonly string TwitchAccount;

		/// <summary>
		/// This YouTuber's Twitter account
		/// </summary>
		[JsonProperty("twitter_acc")] public readonly string TwitterAccount;

		/// <summary>
		/// This YouTuber's Steam account
		/// </summary>
		[JsonProperty("steam_acc")] public readonly string SteamAccount;

		/// <summary>
		/// This YouTuber's Discord server
		/// </summary>
		[JsonProperty("discord_group")] public readonly string DiscordServer;

		/// <summary>
		/// This YouTuber's Steam Group
		/// </summary>
		[JsonProperty("steam_group")] public readonly string SteamGroup;

		/// <summary>
		/// This YouTuber's profile picture/thumbnail
		/// </summary>
		[JsonProperty("thumbnail_url")] public readonly string ThumbnailUrl;
	}
}