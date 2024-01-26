using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        

        public Result(bool success, string message) : this(success) 
        {
            Message = message;//get readonly bir yapıdır .get sadece constructorlar içerisinde set edilebilir .Constructor dışında set etmeyeceğiz.
        }
        public Result (bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; } 
    }
}
