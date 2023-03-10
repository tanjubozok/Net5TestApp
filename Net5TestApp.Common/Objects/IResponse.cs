using Net5TestApp.Common.Enums;

namespace Net5TestApp.Common.Objects
{
    public interface IResponse
    {
        string Message { get; set; }
        ResponseType ResponseType { get; set; }
    }
}
