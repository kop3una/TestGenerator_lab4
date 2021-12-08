using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGeneratorLib.DataStructure
{
   public class ConstructorInfo
    {
        public List<ParameterInfo> Parameters
        { get; protected set; }

        public ConstructorInfo()
        {
            Parameters = new List<ParameterInfo>();
        }
    }
}
