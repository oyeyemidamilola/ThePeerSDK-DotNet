using System;
using Newtonsoft.Json;
using ThePeer.Interfaces;

namespace ThePeer.Models
{
	public class Link : Peerable, IId, IAuditable
	{
		public string Id { get; set; }

		[JsonProperty("user")]
		public User User { get; set; }

		public DateTime CreatedAt { get; set; }

		public DateTime UpdatedAt { get; set; }
	}
}