using Newtonsoft.Json;
using ThePeer.Models;

namespace ThePeer.Responses
{
	public class AuthorizeChargeResponse
	{
		[JsonProperty("transaction")]
		public Transaction Transaction { get; set; }
	}
}