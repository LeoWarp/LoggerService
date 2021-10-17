using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using ASPLesson.Domain.Entity;
using ASPLesson.Domain.Enum;
using ASPLesson.Domain.Interfaces.Repositories;
using ASPLesson.Domain.Interfaces.Services;

namespace ASPLesson.Domain.Services.Services
{
    public sealed class LoggerDbService<T> : ILoggerDbService<T>
    {
        private readonly ILogRepository _logRepository;

        private readonly string _nameSpace;

        private readonly string _currentTime = DateTime.Now.ToLongTimeString();
        
        private List<string> Parameters { get; set; }
        
        public LoggerDbService(ILogRepository logRepository)
        {
            _logRepository = logRepository;
            _nameSpace = typeof(T).FullName;
        }

        private async Task CastMessage(string message, LogLevel logLevel, short traceId, Exception exception)
        {
            var test = exception != null
                ? $"{_currentTime}|{traceId}|{_nameSpace}|{logLevel}|{message}{exception}"
                : $"{_currentTime}|{traceId}|{_nameSpace}|{logLevel}|{message}";
            Parameters = test.Split('|').ToList();
            var level = System.Enum.Parse<LogLevel>(Parameters[3]);
            var log = new Log()
            {
                CurrentTime = DateTime.Parse(Parameters[0], CultureInfo.InvariantCulture),
                Level = level,
                NameSpace = Parameters[2],
                Message = Parameters[4],
                Exception = exception?.Message
            };
            await Create(log);
        }

        private async Task Create(Log log)
        {
            await _logRepository.Create(log);
        }

        public async Task Log(LogLevel level, string message, short traceId = 0, Exception exception = null)
        {
            await CastMessage(message, level, traceId, exception);
        }
    }
}