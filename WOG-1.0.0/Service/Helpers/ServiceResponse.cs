﻿namespace WOG_1._0._0.Service.Helpers
{
    public class ServiceResponse<T>
    {
        public bool Success { get; private set; }
        public T Data { get; private set; }
        public string Error { get; private set; }

        public ServiceResponse(bool success, T data, string error)
        {
            Success = success;
            Data = data;
            Error = error;
        }

        public static ServiceResponse<T> GenerateResponse(
            bool isValid,
            T? data = default,
            string errorMsg = "Could not process request")
        {
            if (isValid)
            {
                if (data != null)
                {
                    return ReturnSuccess(data);
                }
            }
            return ReturnError(errorMsg);
        }


        private static ServiceResponse<T> ReturnSuccess(T data)
        {
            return new ServiceResponse<T>(true, data, null!);
        }

        private static ServiceResponse<T> ReturnError(string errorMessage)
        {
            return new ServiceResponse<T>(false, default!, errorMessage);
        }
    }
}
