using Newtonsoft.Json;

namespace ThePeer.Models
{
	internal class Meta
	{
		[JsonProperty("user")]
		public string User { get; set; }

		[JsonProperty("location")]
		public string Location { get; set; }
	}
}