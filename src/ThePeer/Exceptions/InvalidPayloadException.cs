using System;

namespace ThePeer.Exceptions
{
	public class InvalidPayloadException : Exception
	{
		public InvalidPayloadException() {}
		public InvalidPayloadException(string message) : base(message) {}
	}
}