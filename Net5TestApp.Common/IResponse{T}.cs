using System.Collections.Generic;

namespace Net5TestApp.Common
{
    public interface IResponse<T> : IResponse
    {
        public T Data { get; set; }
        public List<CustomValidationError> CustomValidationErrors { get; set; }
    }
}
