using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Envelopes
{
    public class EnvelopesLogger
    {
        string pathToLogFile;

        public EnvelopesLogger()
        {
            pathToLogFile = Path.GetRandomFileName()+".txt";
        }

        public void Log(string userInput, float currentLength, string message)
        {
            using (StreamWriter streamWriter = new StreamWriter(pathToLogFile, true))
            {
                string msg = string.Format("{0}||User entered [{1}] || Current sideLength [{2}] || Message [{3}]",
                                            DateTime.Now, userInput, currentLength, message);
                streamWriter.WriteLine(msg);
                streamWriter.Close();
            }
        }

        public void Log(Envelope envelope1, Envelope envelope2, string result, bool isContinue)
        {
            using (StreamWriter streamWriter = new StreamWriter(pathToLogFile, true))
            {
                string msg = string.Format("{0}||Envelop 1: [{1}] || Envelope 2: [{2}] || Message [{3}] || Continue? [{4}]",
                                            DateTime.Now, envelope1.ToString(), envelope2.ToString(), result, isContinue);
                streamWriter.WriteLine(msg);
                streamWriter.Close();
            }
        }

        //    public void Log(Object source, UserInputEventArgs args)
        //    {
        //        using (StreamWriter streamWriter = new StreamWriter(pathToLogFile))
        //        {
        //            string msg = string.Format("{0}||User entered [{1}] || Current sideLength [{2}] || Message [{3}]",
        //                                        DateTime.Now, args.UserInput, args.CurrentSideLength, args.Message);
        //            streamWriter.WriteLine(msg);
        //            streamWriter.Close();
        //        }
        //    }

        //    public void Log(Object source, ComparisonResultEventArgs args)
        //    {
        //        using (StreamWriter streamWriter = new StreamWriter(pathToLogFile))
        //        {
        //            string msg = string.Format("{0}||Envelop 1: [{1}] || Envelope 2: [{2}] || Message [{3}] || Continue? [{4}]",
        //                                        DateTime.Now, args.Envelope1.ToString(), args.Envelope2.ToString(), args.Message, args.WantsToContinue);
        //            streamWriter.WriteLine(msg);
        //            streamWriter.Close();
        //        }
        //    }
        //}

        //public class UserInputEventArgs : EventArgs
        //{
        //    public float CurrentSideLength { get; set; }
        //    public string UserInput { get; set; }
        //    public string Message { get; set; }
        //}

        //public class ComparisonResultEventArgs : EventArgs
        //{
        //    public Envelope Envelope1 { get; set; }
        //    public Envelope Envelope2 { get; set; }
        //    public string Message { get; set; }
        //    public bool WantsToContinue { get; set; }
        //}
    }
}
