using System;

namespace ThePeer.Exceptions
{
	public class NotAcceptableException : Exception
	{
		public NotAcceptableException() {}
		public NotAcceptableException(string message) : base(message) {}
	}
}