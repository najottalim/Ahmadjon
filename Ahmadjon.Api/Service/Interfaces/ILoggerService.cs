using System;

namespace Ahmadjon.Api.Service.Interfaces
{
    public interface ILoggerService
    {
        void Error(Exception exception, string message);
        void Information(string message);
        void Warning(string message);
    }
}
