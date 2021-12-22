using Newtonsoft.Json;
using ThePeer.Models;

namespace ThePeer.Responses
{
	public class LinkIdResponse
	{
		[JsonProperty("link")]
		public Link Link { get; set; }
	}
}