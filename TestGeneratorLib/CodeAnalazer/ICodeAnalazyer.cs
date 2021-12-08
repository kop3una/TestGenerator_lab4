using TestGeneratorLib.DataStructure;

namespace TestGeneratorLib.CodeAnalazer
{
    public interface ICodeAnalazyer
    {
        TestFileInfo Analyze(string code);
    }
}
