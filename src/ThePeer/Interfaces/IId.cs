using Newtonsoft.Json;

namespace ThePeer.Interfaces
{
	public interface IId
	{
		[JsonProperty("id")]
		string Id { get; set; }
	}
}