using System;
using Newtonsoft.Json;

namespace ThePeer.Interfaces
{
	internal interface IAuditable
	{
		[JsonProperty("created_at")]
		DateTime CreatedAt { get; set; }

		[JsonProperty("updated_at")]
		DateTime UpdatedAt { get; set; }
	}
}