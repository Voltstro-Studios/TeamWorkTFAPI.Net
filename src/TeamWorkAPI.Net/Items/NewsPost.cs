using Newtonsoft.Json;

namespace TeamWorkAPI.Net.Items
{
	/// <summary>
	/// Represents a news post
	/// </summary>
	public sealed class NewsPost
	{
		/// <summary>
		/// Hash of the post
		/// </summary>
		[JsonProperty("hash")] public readonly string Hash;

		/// <summary>
		/// Who provided the post?
		/// </summary>
		[JsonProperty("provider")] public readonly string Provider;

		/// <summary>
		/// The type of this post
		/// </summary>
		[JsonProperty("type")] public readonly string Type;

		/// <summary>
		/// The title of this post
		/// </summary>
		[JsonProperty("title")] public readonly string Title;

		/// <summary>
		/// The link to this post
		/// </summary>
		[JsonProperty("link")] public readonly string Link;

		/// <summary>
		/// Created at info
		/// </summary>
		[JsonProperty("created_at")] public readonly CreatedAt CreatedAtInfo;

		public struct CreatedAt
		{
			/// <summary>
			/// The date
			/// </summary>
			[JsonProperty("date")] public readonly string Date;

			/// <summary>
			/// Timezone type
			/// </summary>
			[JsonProperty("timezone_type")] public readonly string TimezoneType;

			/// <summary>
			/// The timezone
			/// </summary>
			[JsonProperty("timezone")] public readonly string Timezone;
		}
	}
}