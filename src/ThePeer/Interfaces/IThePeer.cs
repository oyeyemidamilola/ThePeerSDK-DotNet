using System.Threading.Tasks;
using ThePeer.Responses;

namespace ThePeer.Interfaces
{
	public interface IThePeer
	{
		bool ValidateSignature<T>(T payload, string signature);
		Task<AuthorizeChargeResponse> AuthorizeDirectCharge(string reference, string @event);
		Task<ChargeLinkResponse> ChargeLink(string linkId, decimal amount, string remark);
		Task<DefaultResponse> DeleteUser(string reference);
		Task<LinkIdResponse> GetLink(string linkId);
		Task<IndexUserResponse> IndexUser(string name, string identifier, string email);
		Task<IndexUserResponse> GetUser(string reference);
		Task<UpdateUserResponse> UpdateUser(string reference, string identifier);
		Task<ProcessReceiptResponse> ProcessSendReceipt(string receipt, string @event);
		Task<GetReceiptResponse> GetSendReceipt(string receipt);
	}
}