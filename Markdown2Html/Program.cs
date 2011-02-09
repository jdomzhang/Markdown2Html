using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Markdown2Html
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                ShowUsage();
                return;
            }

            ConvertIt(args[0], args[1]);
        }

        private static void ConvertIt(string inputFile, string outputFile)
        {
            var markdown = new FileReader().Read(inputFile);
            var html = new Converter().Convert(markdown);

            new FileWriter().write(html, outputFile);
        }

        private static void ShowUsage()
        {
            Console.WriteLine(@"
Usage:
    Markdown2Html inputfile outputfile
");
        }
    }
}
