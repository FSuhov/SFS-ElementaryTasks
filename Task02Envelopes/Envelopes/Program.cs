using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Envelopes
{
    class Program
    {
        static void Main(string[] args)
        {
            EnvelopesLogger logger = new EnvelopesLogger();
            Action<string, float, string> userInputLogHandler = logger.Log;
            Action<Envelope, Envelope, string, bool> comparisonResultLogHandler = logger.Log;

            UserInterfaceConsole.Run(userInputLogHandler, comparisonResultLogHandler);
        }
    }
}
