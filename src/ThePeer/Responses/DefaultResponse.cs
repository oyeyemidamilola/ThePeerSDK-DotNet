using Newtonsoft.Json;

namespace ThePeer.Responses
{
	public class DefaultResponse
	{
		[JsonProperty("message")]
		public string Message { get; set; }
	}
}