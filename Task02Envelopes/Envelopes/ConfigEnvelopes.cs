using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Envelopes
{
    public static class ConfigEnvelopes
    {
        public const string manual = "This application determines whether one of two envelopes given can be placed into another.\n" +
                               "You will be asked for two consecutive float numbers " +
                               "for first and second envelope respectively.";
        public const string errorMessage = "Wrong parameters entered";
        public const string firstCanBePlaced = "First envelope can be placed inside second one";
        public const string secondCanBePlaced = "Second envelope can be placed inside first one";
        public const string nonCanBePlaced = "Neither envelope can be placed inside another";
        public static string delimiter = "============================================";

        public static string[] askUser =
        {
            "Enter width of Envelope 1",
            "Enter height of Envelope 1",
            "Enter width of Envelope 2",
            "Enter height of Envelope 2"
        };

        public static string wrongNumberMessage = "Wrong data. Number most be positive, the decimal separator is \'.\'";

        public static string askToContinueMessage = "Would you like to continue? => yes or y";
    }
}
