using Newtonsoft.Json;
using ThePeer.Models;

namespace ThePeer.Responses
{
	public class ProcessReceiptResponse
	{
		[JsonProperty("transaction")]
		public Transaction Transaction { get; set; }
	}
}