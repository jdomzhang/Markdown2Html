using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MarkdownSharp;

namespace Markdown2Html
{
    public class Converter
    {
        public string Convert(string markdown)
        {
            var md = new Markdown();

            return md.Transform(markdown);
        }
    }
}
