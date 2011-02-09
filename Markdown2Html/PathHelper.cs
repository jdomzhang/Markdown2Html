using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Markdown2Html
{
    public class PathHelper
    {
        public static void CreateFolderIfNotExisting(string fileName)
        {
            var pathToCreate = new List<string>();
            var path = Path.GetDirectoryName(fileName);

            while (!Directory.Exists(path))
            {
                pathToCreate.Insert(0, path);

                path = Directory.GetParent(path).FullName;
            }

            foreach (var x in pathToCreate)
            {
                Directory.CreateDirectory(x);
            }
        }
    }
}
