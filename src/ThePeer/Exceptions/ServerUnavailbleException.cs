using System;

namespace ThePeer.Exceptions
{
	public class ServerUnavailbleException : Exception
	{
		public ServerUnavailbleException () {}
		public  ServerUnavailbleException (string message) : base(message) {}
	}
}