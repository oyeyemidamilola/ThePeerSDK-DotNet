using Newtonsoft.Json;
using ThePeer.Models;

namespace ThePeer.Responses
{
	public class ChargeLinkResponse
	{
		[JsonProperty("transaction")]
		public Transaction Transaction { get; set; }
	}
}