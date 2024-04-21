using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertText
{
    public class FileRepository : IFileRepository
    {
        public async Task<string> ReadAsync(string path)
        {
            using var reader = new StreamReader(path);
            return await reader.ReadToEndAsync();         
        }

        public async Task WriteAsync(string path, string content)
        {
            using var writer = new StreamWriter(path);
            await writer.WriteAsync(content);          
        }
    }
}
