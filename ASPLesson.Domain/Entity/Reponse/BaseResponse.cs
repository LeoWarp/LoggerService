using System.Net;
using ASPLesson.Domain.Enum;

namespace ASPLesson.Domain.Entity.Reponse
{
    public class BaseResponse
    {
        public string Message { get; set; }
        
        public ErrorCode StatusCode { get; set; }
        
        public object Data { get; set; }
    }
}