// <copyright file="ConsoleUserAdapter.cs" company="Alex Brylov">
// Copyright (c) Alex Brylov. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Triangles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary> Contains methods for interaction with user via console input/output</summary>
    public class ConsoleUserAdapter : IUserAdapter
    {
        /// <summary> Creates and returns an instance of Shape</summary>
        /// <param name="userInput"> A string containing data for Triangle creation</param>
        /// <returns> A new instance of Triangle or null </returns>
        public Shape MakeShape(string userInput)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            string[] data = userInput.ToLower().Split(',');
            string name = data[0];
            double a, b, c;
            try
            {
                a = double.Parse(data[1].Trim());
                b = double.Parse(data[2].Trim());
                c = double.Parse(data[3].Trim());
                if (a <= 0 || b <= 0 || c <= 0)
                {
                    throw new ArgumentException();
                }

                return new Triangle(name, a, b, c);
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
            }

            return null;
        }

        /// <summary>Implements console output of shapes stored in the container</summary>
        /// <param name="shapes">Points to the container</param>
        public void PrintShapes(ShapeContainer shapes)
        {
            Console.WriteLine(shapes.ToString());
        }

        /// <summary>User interaction via console input output </summary>
        /// <param name="shapes"> Points to the container </param>
        public void Run(ShapeContainer shapes)
        {
            while (true)
            {
                Shape shape = this.MakeShape(this.GetUserInput());
                if (shape != null)
                {
                    shapes.AddShape(shape);
                }

                Console.WriteLine("Triangles entered so far:");
                this.PrintShapes(shapes);
                Console.WriteLine("Would you like to enter another triangle?=> y or yes");
                string userInput = Console.ReadLine().ToLower();
                if (!userInput.Equals("yes") && !userInput.Equals("y"))
                {
                    Console.WriteLine("Thank you for using our application...");
                    break;
                }
            }
        }

        private string GetUserInput()
        {
            Console.WriteLine("Please enter triangle data in the format:\n" +
                              "<name>,<side length>,<side length>,<side length>\n" +
                              "separated by comma=>");
            return Console.ReadLine();
        }
    }
}
