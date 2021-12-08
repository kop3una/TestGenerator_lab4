using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestGeneratorLib.DataStructure;

namespace TestGeneratorLib.IO
{
    public interface IAsyncWriter
    {
        Task WriteTextAsync(PathToFile pathToFile);
    }
}
