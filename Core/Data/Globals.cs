using System.Collections.Generic;

namespace EtteremNG.Core.Data
{
    /// <summary>Global variables used by the software.</summary>
    internal class Globals
    {
        /// <summary>A <see cref="List{Table}">list of all tables</see> that can be used.</summary>
        public static List<Table> Tables = new List<Table>();

        /// <summary>A <see cref="List{Reservation}">list of all reservations</see> currently known to the program.</summary>
        public static List<Reservation> Reservations = new List<Reservation>();

        /// <summary>A <see cref="List{WaitingList}">list of waiting list itemss</see> currently known to the program.</summary>
        public static List<WaitingList> WaitingList = new List<WaitingList>();
    }
}
