using RestEase;

namespace ThePeer.Interfaces
{
	
	[Header("Content-Type", "application/json")]
	[Header("Accept","application/json")]
	internal interface IThePeerApi
	{
		[Header("x-api-key")]
		string Apikey { get; set; }
	}
}