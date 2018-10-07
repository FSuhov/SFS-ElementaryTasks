// <copyright file="Program.cs" company="Alex Brylov">
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

    /// <summary> Contains an entry point of the application </summary>
    internal class Program
    {
        /// <summary> An entry point of application </summary>
        /// <param name="args"> Optional arguments to be passed </param>
        private static void Main(string[] args)
        {
            ShapeContainer triangles = new ShapeContainer();
            ConsoleUserAdapter userAdapter = new ConsoleUserAdapter();
            userAdapter.Run(triangles);
        }
    }
}
