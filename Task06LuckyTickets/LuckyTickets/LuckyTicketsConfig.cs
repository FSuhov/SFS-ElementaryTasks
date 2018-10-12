using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTickets
{
    public class LuckyTicketsConfig
    {
        public enum Status
        {
            NoArgs,
            InvalidArgs,
            InvalidPath,
            InvalidFileContent,
            Success
        }

        public const string USER_MANUAL = "This application counts lucky tickets";
    }
}
