using Newtonsoft.Json;

namespace ThePeer.Responses
{
	public class ErrorResponse
	{
		[JsonProperty("message")]
		public string Message { get; set; }
	}
}