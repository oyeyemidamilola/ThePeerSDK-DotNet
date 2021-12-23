using System;

namespace ThePeer.Exceptions
{
	public class UnAuthorizedException : Exception
	{
		public UnAuthorizedException () {}
		public UnAuthorizedException(string message) : base(message) {}
	}
}