using System;
using Newtonsoft.Json;
using ThePeer.Interfaces;

namespace ThePeer.Models
{
	public class Receipt: Peerable, IId, IAuditable
	{
		public string Id { get; set; }

		[JsonProperty("amount")]
		public decimal Amount { get; set; }

		[JsonProperty("user")]
		public User User { get; set; }

		[JsonProperty("meta")]
		public Meta Meta { get; set; }

		public DateTime CreatedAt { get; set; }

		public DateTime UpdatedAt { get; set; }
	}
}