// <copyright file="IUserAdapter.cs" company="Alex Brylov">
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

    /// <summary> Contains prototypes of methods for user interaction class </summary>
    public interface IUserAdapter
    {
        /// <summary> A methods prototype that will create and return
        /// an instance of Shape class based on user input </summary>
        /// <param name="input"> User input, containing data for Shape contstructor </param>
        /// <returns>a new instance of Shape </returns>
        Shape MakeShape(string input);

        /// <summary> A method prototype for generating an output of shapes </summary>
        /// <param name="shapes"> A pointer to shapes container </param>
        void PrintShapes(ShapeContainer shapes);
    }
}
