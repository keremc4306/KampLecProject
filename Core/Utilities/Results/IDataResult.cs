using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IDataResult<T>:IResult
    {
        bool Success { get; }
        string Message { get; }
        T Data { get; }
    }
}
