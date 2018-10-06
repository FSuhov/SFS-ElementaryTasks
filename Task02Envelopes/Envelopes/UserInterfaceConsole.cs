using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Envelopes
{
    public static class UserInterfaceConsole
    {

        public static void Run(Action<string, float, string> userInputLogHandler,
                               Action<Envelope, Envelope, string, bool> comparisonResultLogHandler)
        {
            Console.WriteLine(ConfigEnvelopes.manual);
            while (true)
            {
                Console.WriteLine(ConfigEnvelopes.delimiter);
                int i = 0;
                float a = ReadEnvelopeSideLength(ConfigEnvelopes.askUser[i++], userInputLogHandler);
                float b = ReadEnvelopeSideLength(ConfigEnvelopes.askUser[i++], userInputLogHandler);
                float c = ReadEnvelopeSideLength(ConfigEnvelopes.askUser[i++], userInputLogHandler);
                float d = ReadEnvelopeSideLength(ConfigEnvelopes.askUser[i], userInputLogHandler);
                Envelope envelope1 = new Envelope(a, b);
                Envelope envelope2 = new Envelope(c, d);
                int result = envelope1.CompareTo(envelope2);
                Console.WriteLine("Comparing envelopes: " +
                                  "\n Envelope 1: {0}\n Envelope 2: {1}\n", 
                                  envelope1.ToString(), envelope2.ToString());
                switch ((ComparisonResult)result)
                {
                    case ComparisonResult.FirstToSecond:
                        Console.WriteLine(ConfigEnvelopes.firstCanBePlaced);
                        break;
                    case ComparisonResult.SecondToFirst:
                        Console.WriteLine(ConfigEnvelopes.secondCanBePlaced);
                        break;
                    case ComparisonResult.Non:
                        Console.WriteLine(ConfigEnvelopes.nonCanBePlaced);
                        break;
                    default:
                        break;
                }
                Console.WriteLine(ConfigEnvelopes.askToContinueMessage);
                string userInput = Console.ReadLine().ToLower();                
                if (!userInput.Equals("yes") && !userInput.Equals("y"))
                {
                    Console.WriteLine("Thank you for using our application...");
                    comparisonResultLogHandler(envelope1, envelope2, ((ComparisonResult)result).ToString(), false);
                    break;
                }
                comparisonResultLogHandler(envelope1, envelope2, ((ComparisonResult)result).ToString(), true);
            }
        }


        public static float ReadEnvelopeSideLength(string queryUser, Action<string, float, string>logHandler)
        {
            float length = -1;
            bool IsValidInput = false;
            while (!IsValidInput)
            {
                Console.WriteLine(queryUser);
                string userInput = Console.ReadLine();
                if (float.TryParse(userInput, out length) && length > 0)
                {
                    IsValidInput = true;
                    logHandler(userInput, length, "success");
                }
                else
                {
                    Console.WriteLine(ConfigEnvelopes.wrongNumberMessage);
                    logHandler(userInput, length, "error");
                }
            }
            return length;
        }

        public enum ComparisonResult
        {
            FirstToSecond = -1,
            Non,
            SecondToFirst
        }

        //protected virtual void OnUserLengthSubmitted(float length, string input, string msg)
        //{
        //    UserLengthSubmitted?.Invoke(this, new UserInputEventArgs
        //                               { CurrentSideLength = length, UserInput = input, Message = msg });
        //}

        //protected virtual void OnEnvelopesComparisonDone(Envelope  envelope1, Envelope envelope2, string result, bool wantsToContinue)
        //{
        //    EnvelopesComparisonDone?.Invoke(this, new ComparisonResultEventArgs
        //                                    { Envelope1 = envelope1, Envelope2 = envelope2,
        //                                      Message = result, WantsToContinue = wantsToContinue });
        //}

    }

    
}
