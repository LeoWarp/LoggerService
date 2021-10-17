using System;
using ASPLesson.Domain.Enum;

namespace ASPLesson.Domain.Interfaces.Services
{
    public interface ILoggerService<T>
    {
        void Log(LogLevel level, string message, short traceId = 0, Exception exception = null);
        
        void Trace(string message);
        
        void LogInformation(string message);

        void LogWarning(string message);

        void LogError(string message);

        void LogCritical(string message);
    }
}