namespace EtteremNG.Core.Data
{
    /// <summary>The state of a <see cref="Reservation"/>.</summary>
    internal enum ReservationStatus
    {
        /// <summary>The reservation was successfully processed.</summary>
        SUCCESS,
        /// <summary>Further action is required from the user.</summary>
        NEEDS_WAITING_LIST,
        /// <summary>Processing of the reservation failed.</summary>
        INVALID
    }
}