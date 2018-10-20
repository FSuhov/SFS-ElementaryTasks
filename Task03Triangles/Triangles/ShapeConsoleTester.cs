// <copyright file="ShapeConsoleTester.cs" company="Alex Brylov">
// Copyright (c) Alex Brylov. TASK 3 - TRIANGLES
// </copyright>

namespace Triangles
{
    using System;

    /// <summary> Contains methods for interaction with user via console input/output</summary>
    internal class ShapeConsoleTester
    {
        private ShapeList shapes = new ShapeList();

        /// <summary>
        /// Implements the interaction with user via command line/console input/output.
        /// Reads command line arguments, validates it, prints result.
        /// Prompts user to continue.
        /// </summary>
        /// <param name="args"> Command line arguments provided at launch of application. </param>
        public void Run(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine(Messages.USER_MANUAL);
                if (this.IsWantToContinue())
                {
                    args = this.GetUserInput();
                    this.Run(args);
                }
            }
            else
            {
                this.AddShape(args);
                if (this.IsWantToContinue())
                {
                    args = this.GetUserInput();
                    this.Run(args);
                }
                else
                {
                    Console.WriteLine(Messages.DELIMITER);
                    Console.WriteLine(this.shapes.ToString());
                    Console.WriteLine(Messages.DELIMITER);
                    Console.WriteLine(Messages.GOODBUY_MESSAGE);
                }
            }
        }

        private bool IsWantToContinue()
        {
            Console.WriteLine(Messages.ASK_TO_CONTINUE_MESSAGE);
            string userInput = Console.ReadLine().ToLower();
            return userInput.Equals("yes") || userInput.Equals("y");
        }

        private void AddShape(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            string name = args[0];
            double a, b, c;
            try
            {
                a = double.Parse(args[1].Trim());
                b = double.Parse(args[2].Trim());
                c = double.Parse(args[3].Trim());
                if (a <= 0 || b <= 0 || c <= 0)
                {
                    throw new ArgumentException();
                }

                this.shapes.Add(new Triangle(name, a, b, c));
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Missing arguments.");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Incorrect arguments entered");
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect arguments entered, decimal ceparator is '.'");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Values must be positive");
            }
            finally
            {
                Console.ResetColor();
                Console.WriteLine("{0} triangles entered so far.", this.shapes.Count);
            }
        }

        private string[] GetUserInput()
        {
            Console.WriteLine(Messages.ASK_TO_ENTER_ARGS);
            return Console.ReadLine().Split(',');
        }
    }
}
