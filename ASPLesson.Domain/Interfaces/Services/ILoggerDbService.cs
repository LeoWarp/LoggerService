using System;
using System.Threading.Tasks;
using ASPLesson.Domain.Enum;

namespace ASPLesson.Domain.Interfaces.Services
{
    public interface ILoggerDbService<T>
    {
        Task Log(LogLevel level, string message, short traceId = 0, Exception exception = null);
    }
}