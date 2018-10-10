
namespace NumberToText
{
    using System;

    public class ConsoleNumberToWordsConverter : IUserInterface
    {
        private int number;
        public string Words { get; set; }
        public InputStatus Status { get; set; }

        public enum InputStatus
        {
            noArgs,
            invalidArgs,
            validArgs
        }

        private const string USER_MANUAL = "This application converts numeric input into text output.\n" +
                                           "It is limited to integer numbers, so the range varies from –2,147,483,648 to 2,147,483,647\n" +
                                           "You may launch it from command line by entering the number after the .exe file name:\n" +
                                           "on Windows 10:\n" +
                                           "1. look up for cmd and launch it\n" +
                                           "2. navigate to directory with .exe file: cd d:\\REPOS\\Elementarytasks\\Task04NumberToText\\NumberToText\\bin\\debug" +
                                           "3. print: NumberToText.exe followed by space and the number to convert";

        public void Run(string [] args)
        {
            ReadAndValidateNumber(args);
            switch (this.Status)
            {
                case InputStatus.noArgs:
                    Console.WriteLine(USER_MANUAL);
                    Console.WriteLine("===================================================================");
                    Console.WriteLine("The command line argument has not been submitted");
                    RepeatEntry();
                    break;
                case InputStatus.invalidArgs:
                    Console.WriteLine(USER_MANUAL);
                    Console.WriteLine("===================================================================");
                    Console.WriteLine("Invalid command line argument has been submitted");
                    RepeatEntry();
                    break;
                default:
                    ConvertNumberToWords();
                    Console.WriteLine(Words);
                    RepeatEntry();
                    break;
            }
        }

        public void ConvertNumberToWords()
        {
            Words = NumberToWordsConverter.Convert(number);
        }

        public void ReadAndValidateNumber(string[] args)
        {
            if(args.Length == 0)
            {
                this.Status = InputStatus.noArgs;
            }
            else
            {
                if (int.TryParse(args[0], out number))
                {
                    this.Status = InputStatus.validArgs;
                }
                else
                {
                    this.Status = InputStatus.invalidArgs;
                }
            }
            
        }

        private void RepeatEntry()
        {
            Console.WriteLine("Would you like to enter another number manually=> (y) or exit=> (any other key)?");
            if (Console.ReadLine() == "y")
            {
                Console.WriteLine("Please enter an Integer number followed by enter key");
                string userInput = Console.ReadLine();
                Run(new string[] { userInput });
            }
        }
    }
}
