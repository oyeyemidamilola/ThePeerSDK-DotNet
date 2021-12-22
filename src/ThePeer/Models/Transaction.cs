using System;
using Newtonsoft.Json;
using ThePeer.Interfaces;

namespace ThePeer.Models
{
	internal class Transaction : IAuditable
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("remark")]
		public string Remark { get; set; }

		[JsonProperty("amount")]
		public int Amount { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("status")]
		public string Status { get; set; }

		[JsonProperty("status")]
		public User User { get; set; }

		[JsonProperty("mode")]
		public string Mode { get; set; }

		[JsonProperty("mode")]
		public Meta Meta { get; set; }

		[JsonProperty("reference")]
		public string Reference { get; set; }

		[JsonProperty("peer")]
		public Peer Peer { get; set; }

		public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set; }
	}
}