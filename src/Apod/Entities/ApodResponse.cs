﻿using Apod.Logic.Net.Dtos;

namespace Apod
{
    public class ApodResponse
    {
        public readonly ApodStatusCode StatusCode;
        public readonly ApodContent[] AllContent;
        public readonly ApodContent Content;
        public readonly ApodError Error;

        public ApodResponse(ApodStatusCode statusCode, ApodContent[] allContent = null, ApodError error = null)
        {
            StatusCode = statusCode;
            AllContent = allContent;
            // Set the Content to the latest entry from AllContent
            Content = AllContent?[AllContent.Length > 1 ? AllContent.Length - 1 : 0];
            Error = error;
        }
    }
}
