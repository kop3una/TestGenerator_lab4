using System;
using System.IO;
using System.Threading.Tasks;
using TestGeneratorLib.DataStructure;

namespace TestGeneratorLib.IO
{
    public class AsyncFileWriter : IAsyncWriter
    {
        protected string directory;

        public async Task WriteTextAsync(PathToFile pathToFile)
        {
            if (pathToFile == null)
            {
                throw new ArgumentException("PathContent pair shouldn't be null");
            }
            if (!System.IO.Directory.Exists(directory))
            {
                System.IO.Directory.CreateDirectory(directory);
            }

            using (StreamWriter writer = new StreamWriter(Directory + Path.DirectorySeparatorChar + pathToFile.Path))
            {
                await writer.WriteAsync(pathToFile.Content);
            }
        }

        public string Directory
        {
            get => directory;
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Directory shouldn't be null");
                }
                directory = Path.GetFullPath(value);
            }
        }

        public AsyncFileWriter()
        {
            Directory = System.IO.Directory.GetCurrentDirectory();
        }
    }
}
