using Newtonsoft.Json;
using ThePeer.Models;

namespace ThePeer.Responses
{
	public class UpdateUserResponse
	{
		[JsonProperty("indexed_user")]
		public User User { get; set; }
	}
}