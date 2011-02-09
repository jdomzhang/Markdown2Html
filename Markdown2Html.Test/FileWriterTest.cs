using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.IO;

namespace Markdown2Html.Test
{
    [TestFixture]
    public class FileWriterTest
    {
        [Test]
        public void should_be_able_to_write_file_to_disk()
        {
            // Arrange
            var content = @"This is a line.\n";
            var fileName = Path.GetTempFileName();

            // Act
            new FileWriter().write(content, fileName);

            // Assert
            var result = File.ReadAllText(fileName);
            Assert.AreEqual(content, result);
        }
    }
}
