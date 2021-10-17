using System;
using System.Threading.Tasks;

namespace ASPLesson.Domain.Interfaces.Services
{
    public interface IFileService
    {
        Task WriteLog(string message);
    }
}