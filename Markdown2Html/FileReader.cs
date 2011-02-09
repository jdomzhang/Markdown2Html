using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Markdown2Html
{
    public class FileReader
    {
        public string Read(string fileName)
        {
            if (!fileName.Contains("://"))
            {
                return ReadTextFileFromDisk(fileName);
            }

            throw new NotImplementedException();
        }

        private static string ReadTextFileFromDisk(string fileName)
        {
            return File.ReadAllText(fileName);
        }
    }
}
