using Newtonsoft.Json;

namespace ThePeer.Models
{
	internal class Business
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("email")]
		public string Email { get; set; }

		[JsonProperty("logo")]
		public string Logo { get; set; }

		[JsonProperty("identifier_type")]
		public string IdentifierType { get; set; }
	}
}