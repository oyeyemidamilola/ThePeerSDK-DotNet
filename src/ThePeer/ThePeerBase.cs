using RestEase;
using ThePeer.Constant;
using ThePeer.Interfaces;
using ThePeer.Models;

namespace ThePeer
{
	public abstract class ThePeerBase
	{
		internal readonly IThePeerApi _thePeerApi;
		internal readonly string _secretkey;

		internal ThePeerBase(string secretKey)
		{
			_secretkey = secretKey;
			_thePeerApi = RestClient.For<IThePeerApi>(Config.BASE_API_URL);
			_thePeerApi.Apikey = secretKey;
		}
	}
}