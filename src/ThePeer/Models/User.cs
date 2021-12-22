using System;
using Newtonsoft.Json;
using ThePeer.Interfaces;

namespace ThePeer.Models
{
	public class User : IAuditable
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

		public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set; }
	}
}