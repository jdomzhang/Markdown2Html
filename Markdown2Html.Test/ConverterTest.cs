using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Markdown2Html.Test
{
    [TestFixture]
    public class ConverterTest
    {
        [Test]
        public void should_convert_markdown_text_2_html()
        {
            var converter = new Converter();

            var html = converter.Convert("*Hello* markdown!");

            var expect = "<p><em>Hello</em> markdown!</p>\n";

            Assert.AreEqual(expect, html);
        }
    }
}
