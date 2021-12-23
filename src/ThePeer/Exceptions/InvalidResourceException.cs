using System;

namespace ThePeer.Exceptions
{
	public class InvalidResourceException : Exception
	{
		public InvalidResourceException() {}
		public InvalidResourceException(string message) : base(message) {} 
	}
}