using System;

namespace ThePeer.Exceptions
{
	public class ServerErrorException : Exception
	{
		public ServerErrorException() {}
		public ServerErrorException(string message) : base(message) {}
	}
}