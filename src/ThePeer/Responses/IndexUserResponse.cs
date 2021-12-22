using Newtonsoft.Json;
using ThePeer.Models;

namespace ThePeer.Responses
{
	public class IndexUserResponse
	{
		[JsonProperty("indexed_user")]
		public User User { get; set; }
	}
}