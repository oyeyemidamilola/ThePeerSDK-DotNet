using Newtonsoft.Json;

namespace ThePeer.Models
{
	internal class Peer
	{
		[JsonProperty("user")]
		public User User { get; set; }

		[JsonProperty("business")]
		public Business Business { get; set; }
	}
}