using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTickets
{
    class ConsoleLuckyTicketCounter
    {
        ILuckyTicketIdentifier luckyTicketIdentifier;

        LuckyTicketsConfig.Status status;

        public void Init(string[] args)
        {
            switch (args.Length)
            {
                case 0:
                    status = LuckyTicketsConfig.Status.NoArgs;
                    break;
                case 1:
                    status = InitLuckyTicket(args[0]);
                    break;
                case 2:
                    status = InitLuckyTicket(args[0], args[1]);
                    break;
                default:
                    status = LuckyTicketsConfig.Status.InvalidArgs;
                    break;
            }            
        }

        public void ShowResult()
        {
            if (this.status == LuckyTicketsConfig.Status.Success)
            {
                int result = this.luckyTicketIdentifier.CountNumberOfLuckyTickets();
                Console.WriteLine(result);
            }
            else
            {
                switch (this.status)
                {
                    case LuckyTicketsConfig.Status.NoArgs:
                        Console.WriteLine("No command line arguments provided");
                        break;
                    case LuckyTicketsConfig.Status.InvalidPath:
                        Console.WriteLine("Unable to locate file");
                        break;
                    case LuckyTicketsConfig.Status.InvalidFileContent:
                        Console.WriteLine("Unable to idetnify the algorythm (wrong data in the file");
                        break;
                    case LuckyTicketsConfig.Status.InvalidArgs:
                        Console.WriteLine("Wrong second command line argument");
                        break;
                    default:
                        break;
                }
            }
        }

        private string ReadFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                return reader.ReadLine();
            } 
        }

        private LuckyTicketsConfig.Status InitLuckyTicket(string path)
        {
            string mode = ReadFile(path).Trim();
            LuckyTicketsConfig.Status status = LuckyTicketsConfig.Status.Success;
            switch (mode)
            {
                case "Moscow":
                    this.luckyTicketIdentifier = new LuckyTicketMoscow();
                    break;
                case "Piter":
                    this.luckyTicketIdentifier = new LuckyTicketPeter();
                    break;
                default:
                    status = LuckyTicketsConfig.Status.InvalidFileContent;
                    break;
            }
            return status;
        }

        private LuckyTicketsConfig.Status InitLuckyTicket(string path, string digits)
        {
            LuckyTicketsConfig.Status status;
            string mode = ReadFile(path).Trim();
            int parsedDigits = 0;
            if (int.TryParse(digits, out parsedDigits))
            {
                switch (mode)
                {
                    case "Moscow":
                        this.luckyTicketIdentifier = new LuckyTicketMoscowExtended(parsedDigits);
                        status = LuckyTicketsConfig.Status.Success;
                        break;
                    case "Piter":
                        this.luckyTicketIdentifier = new LuckyTicketPeter();
                        status = LuckyTicketsConfig.Status.Success;
                        break;
                    default:
                        status = LuckyTicketsConfig.Status.InvalidFileContent;
                        break;
                }
            }
            else
            {
                status = LuckyTicketsConfig.Status.InvalidArgs;
            }
            return status;
        }
    }
}
