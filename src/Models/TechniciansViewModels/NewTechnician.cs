using System;

namespace KalahariTickets.Models.TechniciansViewModels
{
    /// <summary>
    /// For adding a new technician
    /// </summary>
    public class NewTechnician : Technician
    {
        /// <summary>
        /// The password of the technician
        /// </summary>
        public string Password { get; set; }
    }
}