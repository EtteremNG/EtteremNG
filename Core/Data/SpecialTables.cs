namespace EtteremNG.Core.Data
{
    /// <summary>Represents special <see cref="Table"/> objects used internally by the software.</summary>
    internal class SpecialTables
    {
        /// <summary>A <see cref="Table"/> object to be assigned to a <see cref="Reservation"/> where the guest had refused to be put on the waiting list.</summary>
        public static Table GONE =>
            new Table
            {
                ID = -2,
                maxCapacity = 0,
                tableType = 'Y'
            };
        /// <summary>A <see cref="Table"/> object to be assigned to a <see cref="Reservation"/> where the guest has been put onto the waiting list.</summary>
        public static Table WAITLIST =>
            new Table
            {
                ID = -1,
                maxCapacity = 0,
                tableType = 'X'
            };
    }
}