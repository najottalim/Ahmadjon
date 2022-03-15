using Ahmadjon.Api.Service.Interfaces;
using System;
using System.IO;

namespace Ahmadjon.Api.Service.Services
{
    public class LoggerService : ILoggerService
    {
        private readonly string LOG_PATH = "Logs/ErrorMessage.txt";
        public void Error(Exception exception, string message)
        {
            File.AppendAllText(LOG_PATH, DateTime.Now + "\t" + exception + "\t"  + message + "\n");
        }

        public void Information(string message)
        {
            throw new NotImplementedException();
        }

        public void Warning(string message)
        {
            throw new NotImplementedException();
        }
    }
}
