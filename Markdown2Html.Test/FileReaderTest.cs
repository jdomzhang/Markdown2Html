using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.IO;

namespace Markdown2Html.Test
{
    [TestFixture]
    public class FileReaderTest
    {
        [Test]
        public void should_be_able_to_read_file_from_disk()
        {
            var content = @"This is a temporary content!!!";
            var tempFile = Path.GetTempFileName();

            File.WriteAllText(tempFile, content);

            var result = new FileReader().Read(tempFile);

            Assert.AreEqual(content, result);
        }
    }
}
