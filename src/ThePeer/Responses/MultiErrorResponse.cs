using Newtonsoft.Json;

namespace ThePeer.Responses
{
	public class MultiErrorResponse<T>
	{
		[JsonProperty("message")]
		public string Message { get; set; }

		[JsonProperty("errors")]
		public T Errors { get; set; }
	}
}