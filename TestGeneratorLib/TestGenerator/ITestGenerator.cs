using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGeneratorLib.TestGenerator
{
    public interface ITestGenerator
    {
        Task Generate();
    }
}
