using Newtonsoft.Json;

namespace ThePeer.Models
{
	public class Peerable
	{
		[JsonProperty("peer")]
		public Peer Peer { get; set; }
	}
}