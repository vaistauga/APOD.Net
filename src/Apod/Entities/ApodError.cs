﻿namespace Apod
{
    public class ApodError
    {
        public readonly ApodErrorCode ErrorCode;
        public readonly string ErrorMessage;

        public ApodError(ApodErrorCode errorCode, string errorMessage = "")
        {
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
        }

        public ApodResponse ToApodResponse()
            => new ApodResponse(ApodStatusCode.Error, error: this);
    }
}