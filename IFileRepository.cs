using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertText
{
    public interface IFileRepository
    {
        Task<String> ReadAsync(string path);
        Task WriteAsync(string path, string content);
    }
}
