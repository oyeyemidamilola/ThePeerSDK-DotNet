using System;
using System.Data;
using System.Net;
using Newtonsoft.Json;
using RestEase;
using ThePeer.Exceptions;
using ThePeer.Responses;

namespace ThePeer.Helpers
{
	internal static class ProcessResponse
	{
		public static TResponse Process<TResponse>(Response<TResponse> response)
		{
			ErrorResponse errorResponse;
			switch (response.ResponseMessage.StatusCode)
			{
				case HttpStatusCode.OK:
				case HttpStatusCode.Created:
					return response.GetContent();

				case HttpStatusCode.Unauthorized:
					errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(response.StringContent ?? string.Empty);
					throw new UnAuthorizedException(errorResponse?.Message);
				case HttpStatusCode.Forbidden:
					errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(response.StringContent ?? string.Empty);
					throw new ForbiddenException(errorResponse?.Message);
				case HttpStatusCode.NotFound:
					errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(response.StringContent ?? string.Empty);
					throw new InvalidResourceException(errorResponse?.Message);
				case HttpStatusCode.NotAcceptable:
					errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(response.StringContent ?? string.Empty);
					throw new NoNullAllowedException(errorResponse?.Message);
				case (HttpStatusCode)422:
					var multiErrorResponse = JsonConvert.DeserializeObject<MultiErrorResponse<string>>(response.StringContent ?? string.Empty);
					throw new InvalidPayloadException(multiErrorResponse?.Errors);
				case HttpStatusCode.ServiceUnavailable:
					errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(response.StringContent ?? string.Empty);
					throw new ServerUnavailbleException(errorResponse?.Message);
				default:
					errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(response.StringContent ?? string.Empty);
					throw new ServerUnavailbleException(errorResponse?.Message);
			}
		}
	}
}