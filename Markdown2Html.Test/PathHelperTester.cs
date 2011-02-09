using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.IO;

namespace Markdown2Html.Test
{
    [TestFixture]
    public class PathHelperTester
    {
        [Test]
        public void should_be_able_to_create_non_existing_folder_for_path()
        {
            var folder = Path.GetTempPath() + DateTime.Now.Ticks;

            var fileName = string.Join(Path.DirectorySeparatorChar.ToString()
                , folder
                , DateTime.Today.Year
                , DateTime.Today.Month
                , DateTime.Today.Day
                , "file.temp"
            );

            Console.WriteLine(fileName);

            PathHelper.CreateFolderIfNotExisting(fileName);
            
            Assert.True(Directory.Exists(Path.GetDirectoryName(fileName)));

            Directory.Delete(folder, true);
        }
    }
}
