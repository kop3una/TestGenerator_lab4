using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGeneratorLib.DataStructure
{
    public class TypeInfo
    {
        public string Typename
        { get; protected set; }

        public bool IsInterface
        { get; protected set; }

        public TypeInfo(string typename)
        {
            Typename = typename ?? throw new ArgumentException("Typename shouldn't be null");
            IsInterface = typename.StartsWith("I");
        }
    }
}
