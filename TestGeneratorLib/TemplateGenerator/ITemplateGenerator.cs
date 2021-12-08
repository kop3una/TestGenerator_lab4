using System.Collections.Generic;
using TestGeneratorLib.DataStructure;

namespace TestGeneratorLib.TemplatesGenerator
{
    public interface ITemplateGenerator
    {
        IEnumerable<PathFile> Generate(string source);
    }
}
