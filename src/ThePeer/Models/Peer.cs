using Newtonsoft.Json;

namespace ThePeer.Models
{
	public class Peer
	{
		[JsonProperty("user")]
		public User User { get; set; }

		[JsonProperty("business")]
		public Business Business { get; set; }
	}
}