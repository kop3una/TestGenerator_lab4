using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGeneratorLib.DataStructure
{
    public class PathToFile
    {
        public string Path
        { get; protected set; }

        public string Content
        { get; protected set; }

        public PathToFile(string path, string content)
        {
            if ((path == null) || (content == null))
            {
                throw new ArgumentException("Arguments shouldn't be null");
            }
            this.Path = path;
            this.Content = content;
        }
    }
}
