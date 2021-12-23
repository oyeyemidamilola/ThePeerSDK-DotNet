using System.Threading.Tasks;
using RestEase;
using ThePeer.Responses;

namespace ThePeer.Interfaces
{
	internal class ChargeLinkRequest
	{
		public decimal Amount { get; set; }
		public string Remark { get; set; }
	}

	internal class IndexUserRequest
	{
		public string Name { get; set; }
		public string Identifier { get; set; }

		public string Email { get; set; }
	}

	[Header("Content-Type", "application/json")]
	[Header("Accept","application/json")]
	internal interface IThePeerApi
	{
		[Header("x-api-key")]
		string Apikey { get; set; }

		[Post("/debit/{reference}")]
		Task<Response<AuthorizeChargeResponse>> AuthorizeDirectCharge([Path] string reference, [Body] string @event);

		[Post("/link/{linkId}/charge")]
		Task<Response<ChargeLinkResponse>> ChargeLink([Path] string linkId, [Body] ChargeLinkRequest request);

		[Delete("/users/{reference}")]
		Task<Response<DefaultResponse>> DeleteUser([Path] string reference);

		[Get("/link/{linkId}")]
		Task<Response<LinkIdResponse>> GetLink([Path] string linkId);

		[Post("/users")]
		Task<Response<IndexUserResponse>> IndexUser([Body] IndexUserRequest request);

		[Get("/users")]
		Task<Response<IndexUserResponse>> GetUser([Path] string reference);

		[Put("/users/{reference}")]
		Task<Response<UpdateUserResponse>> UpdateUser([Path] string reference, [Body] string identifier);

		[Post("/send/{reference}")]
		Task<Response<ProcessReceiptResponse>> ProcessSendReceipt([Path] string receipt, [Body] string @event);

		[Post("/send")]
		Task<Response<GetReceiptResponse>> GetSendReceipt([Path] string receipt);
	}
}