using System.Collections.Generic;

namespace Support.DTOs
{
    public class ApiResponse<T>
    {

        public ApiResponse()
        {
            Success = true;
            Errors = new List<string>();
        }
        public ApiResponse(T data, string message = null)
        {
            Success = true;
            Message = message;
            Data = data;
            Errors = new List<string>();
        }
        public ApiResponse(string message)
        {
            Success = false;
            Message = message;
            Errors = new List<string>();
        }
        public bool Success { get; set; }
        public string Message { get; set; }
        public List<string> Errors { get; set; }
        public T Data { get; set; }
    }
}
