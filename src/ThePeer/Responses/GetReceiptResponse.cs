using Newtonsoft.Json;
using ThePeer.Models;

namespace ThePeer.Responses
{
	public class GetReceiptResponse
	{
		[JsonProperty("receipt")]
		public Receipt Receipt { get; set; }
	}
}