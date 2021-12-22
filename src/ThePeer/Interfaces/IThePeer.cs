namespace ThePeer.Interfaces
{
	public interface IThePeer
	{
		bool ValidateSignature<T>(T payload, string signature);
	}
}