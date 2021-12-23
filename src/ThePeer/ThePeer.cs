using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ThePeer.Helpers;
using ThePeer.Interfaces;
using ThePeer.Responses;
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

		public async Task<AuthorizeChargeResponse> AuthorizeDirectCharge(string reference, string @event)
		{	
				var response = await _thePeerApi.AuthorizeDirectCharge(reference, @event);
				return ProcessResponse.Process(response);
		}

		public async Task<ChargeLinkResponse> ChargeLink(string linkId, decimal amount, string remark)
		{
			var response = await _thePeerApi.ChargeLink(linkId, new ChargeLinkRequest
			{
				Amount = amount,
				Remark = remark
			});
			return ProcessResponse.Process(response);
		}

		public async Task<DefaultResponse> DeleteUser(string reference)
		{
			var response = await _thePeerApi.DeleteUser(reference);
			return ProcessResponse.Process(response);
		}

		public async Task<LinkIdResponse> GetLink(string linkId)
		{
			var response = await _thePeerApi.GetLink(linkId);
			return ProcessResponse.Process(response);
		}

		public async Task<IndexUserResponse> IndexUser(string name, string identifier, string email)
		{
			var response = await _thePeerApi.IndexUser(new IndexUserRequest
			{
				Name = name,
				Identifier = identifier,
				Email = email
			});
			return ProcessResponse.Process(response);
		}

		public async Task<IndexUserResponse> GetUser(string reference)
		{
			var response = await _thePeerApi.GetUser(reference);
			return ProcessResponse.Process(response);
		}

		public async Task<UpdateUserResponse> UpdateUser(string reference, string identifier)
		{
			var response = await _thePeerApi.UpdateUser(reference, identifier);
			return ProcessResponse.Process(response);
		}

		public async Task<ProcessReceiptResponse> ProcessSendReceipt(string receipt, string @event)
		{
			var response = await _thePeerApi.ProcessSendReceipt(receipt, @event);
			return ProcessResponse.Process(response);
		}

		public async Task<GetReceiptResponse> GetSendReceipt(string receipt)
		{
			var response = await _thePeerApi.GetSendReceipt(receipt);
			return ProcessResponse.Process(response);
		}
	}
}