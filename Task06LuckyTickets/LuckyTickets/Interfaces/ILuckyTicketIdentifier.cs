// <copyright file="ILuckyTicketIdentifier.cs" company="Oleksandr Brylov">
// Copyright (c) Oleksandr Brylov. Task 06, LuckyTickets.
// </copyright>

namespace LuckyTickets
{
    /// <summary>
    /// Represents an interface of counting the lucky tickets.
    /// To be implemented with specific algorithm-defined logic.
    /// </summary>
    public interface ILuckyTicketIdentifier
    {
        /// <summary>
        /// Proptotype of method that implements the logic
        /// if identifying the lucky ticket depending on algorithm selected.
        /// </summary>
        /// <param name="ticket">The instance of ticket, containing serial number. </param>
        /// <returns> Evaluation of whether ticket is lucky or not. </returns>
        bool IsLuckyTicket(Ticket ticket);
    }
}
