using Newtonsoft.Json;

namespace ThePeer.Models
{
	public class Meta
	{
		[JsonProperty("user")]
		public string User { get; set; }

		[JsonProperty("location")]
		public string Location { get; set; }
	}
}