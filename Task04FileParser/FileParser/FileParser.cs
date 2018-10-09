// <copyright file="FileParser.cs" company="Oleksandr Brylov">
// Copyright (c) Oleksandr Brylov. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace FileParser
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Implementing the logic of parsing:
    /// Contains methods that find entries and replace it with another string.
    /// Contains properties required for those methods.
    /// </summary>
    public class FileParser
    {
        /// <summary> Gets or sets path to file that needs to be parsed. </summary>
        public string FilePath { get; set; }

        /// <summary> Gets or sets the string to be found in the file </summary>
        public string StringToFind { get; set; }

        /// <summary> Gets or sets the replacement string </summary>
        public string StringReplacement { get; set; }

        /// <summary> Finds all entries of StringToFind in the file. </summary>
        /// <returns> Integer number of entries found. </returns>
        public int FindEntries()
        {
            var fileStream = new FileStream(this.FilePath, FileMode.Open, FileAccess.Read);
            int entryCount = 0;

            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    if (line.Contains(this.StringToFind))
                    {
                        entryCount++;
                    }
                }
            }

            return entryCount;
        }

        /// <summary> Replaces all entries of the string </summary>
        /// <returns> Integer number of entries replaced. </returns>
        public int ReplaceEntries()
        {
            int entryCount = 0;
            string tempFileName = Path.GetDirectoryName(this.FilePath) + "\\" + Path.GetRandomFileName() + ".txt";
            var fileStream = new FileStream(this.FilePath, FileMode.Open, FileAccess.Read);
            using (var output = new StreamWriter(tempFileName))
            {
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        if (line.Contains(this.StringToFind))
                        {
                            line = line.Replace(this.StringToFind, this.StringReplacement);
                            entryCount++;
                        }

                        output.WriteLine(line);
                    }
                }
            }

            if (entryCount > 0)
            {
                try
                {
                    File.Replace(tempFileName, this.FilePath, null);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Unable to replace the original content, see details below");
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                try
                {
                    File.Delete(tempFileName);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Unable to remove temporary file, see details below");
                    Console.WriteLine(ex.Message);
                }
            }

            return entryCount;
        }
    }
}
