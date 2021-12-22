using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json;
using ThePeer.Interfaces;
using static System.Convert;

namespace ThePeer
{
	public class ThePeer :  ThePeerBase, IThePeer
	{
		public ThePeer(string secretKey): base(secretKey) { }


		public static ThePeer CreateClient(string secretKey)
		{
			return new ThePeer(secretKey);
		}

		public bool ValidateSignature<T>(T payload, string signature)
		{
			var keyBytes = Encoding.UTF8.GetBytes(_secretkey);
			var encodedPayload = JsonConvert.SerializeObject(payload);
			var payloadBytes = Encoding.UTF8.GetBytes(encodedPayload);
			using (var hash = new HMACSHA1(keyBytes))
			{
				var hashedMessage = hash.ComputeHash(payloadBytes);
				return ToBase64String(hashedMessage) == signature;
			}
		}
	}
}