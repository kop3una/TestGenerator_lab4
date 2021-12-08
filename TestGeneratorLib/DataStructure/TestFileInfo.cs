using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGeneratorLib.DataStructure
{
   public class TestFileInfo
    {
        public List<string> Usings
        { get; protected set; }

        public List<TestClassInfo> Classes
        { get; protected set; }

        public TestFileInfo()
        {
            Usings = new List<string>();
            Classes = new List<TestClassInfo>();
        }
    }
}
