using KalahariTickets.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KalahariTickets.Data
{
    /// <summary>
    /// The context for the KalahariTickets Api
    /// </summary>
    public class KalahariTicketsContext : IdentityDbContext<Technician>
    {
        /// <summary>
        /// The collection of clients
        /// </summary>
        public DbSet<Client> Clients { get; set; }

        /// <summary>
        /// The collection of tickets
        /// </summary>
        public DbSet<Ticket> Tickets { get; set; }

        /// <summary>
        /// The collection of TechnicianTicket pivot models
        /// </summary>
        public DbSet<TechnicianTicketTime> TechnicianTicketTimes { get; set; }

        /// <summary>
        /// The constructor for this context
        /// </summary>
        /// <param name="options">The options to create the context around</param>
        /// <returns>A new instance of this context</returns>
        public KalahariTicketsContext(DbContextOptions<KalahariTicketsContext> options) : base(options)
        { }
    }
}