// <copyright file="Program.cs" company="Oleksandr Brylov">
// Copyright (c) Oleksandr Brylov. Task 06, LuckyTickets.
// </copyright>

namespace LuckyTickets
{
    /// <summary> Contains an entry point of the application. </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] localArgs = { "input.txt", "6" };
            ConsoleLuckyTicketCounter ticketCounter = new ConsoleLuckyTicketCounter();
            ticketCounter.SetStatus(localArgs);
            ticketCounter.ShowResult();
        }
    }
}
