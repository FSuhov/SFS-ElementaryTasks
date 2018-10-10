using System;
namespace NumberToText
{
    class Program
    {
        static void Main(string[] args)
        {           
            ConsoleNumberToWordsConverter converter = new ConsoleNumberToWordsConverter();
            converter.Run(args);
        }
    }
}
