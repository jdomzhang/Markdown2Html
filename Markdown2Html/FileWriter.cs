using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Markdown2Html
{
    public class FileWriter
    {
        public void write(string content, string fileName)
        {
            if (!fileName.Contains("://"))
            {
                WriteToDisk(content, fileName);
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        private static void WriteToDisk(string content, string fileName)
        {
            File.WriteAllText(fileName, content);
        }
    }
}
