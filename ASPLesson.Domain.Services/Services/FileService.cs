using System;
using System.IO;
using System.Threading.Tasks;
using ASPLesson.Domain.Interfaces.Services;

namespace ASPLesson.Domain.Services.Services
{
    public sealed class FileService : IFileService
    {
        private const string PATH = @"C:\Users\leowa\Desktop\ASPLesson\MyLog.txt";

        public async Task WriteLog(string message)
        {
            using (StreamWriter sw = new StreamWriter(PATH, true, System.Text.Encoding.Default))
            {
                await sw.WriteLineAsync(message);
            }
        }
        
        public async Task ReadLogs()
        {
            using (StreamReader sr = new StreamReader(PATH))
            {
                Console.WriteLine(await sr.ReadToEndAsync());
            }
        }
    }
}