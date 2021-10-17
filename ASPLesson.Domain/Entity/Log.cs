using System;
using ASPLesson.Domain.Enum;

namespace ASPLesson.Domain.Entity
{
    public class Log
    {
        public int Id { get; set; }
        
        public string NameSpace { get; set; }
        
        public DateTime CurrentTime { get; set; }
        
        public string Exception { get; set; }
        
        public string Message { get; set; }
        
        public LogLevel Level { get; set; }
    }
}