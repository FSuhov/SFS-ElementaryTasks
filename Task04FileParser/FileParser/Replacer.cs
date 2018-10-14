// <copyright file="Replacer.cs" company="Oleksandr Brylov">
// Copyright (c) Oleksandr Brylov. Task 4 - File Parser
// </copyright>

namespace FileParser
{
    using System.IO;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Implementing the logic of parsing:
    /// Contains method that find entries and replace it with another string.
    /// Contains fields required for that method.
    /// </summary>
    public class Replacer : IFileParser
    {
        private string _path;
        private string _find;
        private string _replacement;

        /// <summary>
        /// Initializes a new instance of the <see cref="Replacer"/> class.
        /// </summary>
        /// <param name="path"> Path to the file to parse. </param>
        /// <param name="find"> String to find in the file. </param>
        /// <param name="replace"> String to be replaced on. </param>
        public Replacer(string path, string find, string replace)
        {
            this._path = path;
            this._find = find;
            this._replacement = replace;
        }

        /// <summary>
        /// Replaces all entries of the string.
        /// Throws custom exceptions if failed to manage files.
        /// </summary>
        /// <returns> Total number of entries replaced. </returns>
        public int ParseFile()
        {
            int entryCount = 0;
            string tempFileName = Path.GetDirectoryName(this._path) + "\\" + Path.GetRandomFileName() + ".txt";

            using (StreamWriter output = new StreamWriter(tempFileName))
            {
                using (StreamReader reader = new StreamReader(this._path))
                {
                    StringBuilder line;
                    while (!reader.EndOfStream)
                    {
                        line = new StringBuilder(reader.ReadLine());
                        entryCount += this.ReplaceEntriesInString(line);
                        output.WriteLine(line);
                    }
                }
            }

            if (entryCount > 0)
            {
                try
                {
                    File.Replace(tempFileName, this._path, null);
                }
                catch
                {
                    throw new FailedToReplaceFileException(this._path);
                }
            }
            else
            {
                try
                {
                    File.Delete(tempFileName);
                }
                catch
                {
                    throw new FailedToDeleteTempFileException(tempFileName);
                }
            }

            return entryCount;
        }

        private int ReplaceEntriesInString(StringBuilder text)
        {
            MatchCollection matches = Regex.Matches(text.ToString(), this._find);

            if (matches.Count > 0)
            {
                text.Replace(this._find, this._replacement);
            }

            return matches.Count;
        }
    }
}
