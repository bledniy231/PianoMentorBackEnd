﻿using Microsoft.Net.Http.Headers;

namespace PianoMentor.BLL.Services.MultipartRequestHelper
{
	public interface IMultipartRequestHelper
	{
		public bool IsMultipartContentType(string contentType);
		public string? GetBoundary(MediaTypeHeaderValue headerValue, int lengthLimit);
		public bool HasFileContentDisposition(ContentDispositionHeaderValue contentDisposition);
	}
}
