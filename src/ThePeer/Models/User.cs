using Newtonsoft.Json;

namespace ThePeer.Models
{
	internal class User
	{
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("identifier")]
		public string Identifier { get; set; }

		[JsonProperty("identifier_type")]
		public string IdentifierType { get; set; }

		[JsonProperty("email")]
		public string Email { get; set; }

		[JsonProperty("reference")]
		public string Reference { get; set; }
	}
}