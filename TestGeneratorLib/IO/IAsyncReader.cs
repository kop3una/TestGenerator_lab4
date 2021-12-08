using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGeneratorLib.IO
{
    public interface IAsyncReader
    {
        Task<string> ReadTextAsync(string path);
    }
}
