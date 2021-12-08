using System;
using System.Collections.Generic;
using TestGeneratorLib;
using TestGeneratorLib.IO;

namespace TestGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            TestsGeneratorConfig config = new TestsGeneratorConfig
            {
                ReadPaths = new List<string>
                {
                    "C:\\Users\\kiril\\OneDrive\\Рабочий стол\\Учеба\\3 курс\\СПП\\lab4\\TestGenerator\\ConsoleOutput.cs",
                    "C:\\Users\\kiril\\OneDrive\\Рабочий стол\\Учеба\\3 курс\\СПП\\lab4\\TestGenerator\\FooBar.cs",
                },
                Writer = new AsyncFileWriter()
                {
                    Directory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                },
                ReadThreadCount = 2,
                WriteThreadCount = 2,
                processThreadCount = 2

            };

            new TestGeneratorLib.TestGenerator.TestGenerator(config).Generate().Wait();
            Console.WriteLine("Generation completed");
            Console.ReadKey();
        }
    }
}
