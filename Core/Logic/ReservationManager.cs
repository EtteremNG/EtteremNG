using EtteremNG.Core.Data;
using EtteremNG.Core.Utilities;
using System.Linq;

namespace EtteremNG.Core.Logic
{
    /// <summary>Provides functions for processing of reservations.</summary>
    internal class ReservationManager
    {
        /// <summary>Process a <see cref="Reservation" /> by attempting to assign tables to it.</summary>
        /// <param name="reservation">The <see cref="Reservation" /> to process</param>
        /// <param name="processWaitingList">If <c>true</c>, reservations on the waiting list are processed.</param>
        /// <returns>A <see cref="ReservationStatus"/> showing if the processing was successful or further actions are required from the user.<br /></returns>
        public static ReservationStatus ProcessReservation(Reservation reservation, bool processWaitingList = false)
        {
            if (reservation.onWaitingList && !processWaitingList)
            {
                // Do not modify the reservation object if the software/test asked us not to.
                Globals.Reservations.Add(reservation);
                return ReservationStatus.SUCCESS;
            }

            var tables = TableUtil.TryToAssignTables(reservation.tableType, reservation.chairAmount,
                reservation.reservationStart);

            // Failed - needs waiting list
            if (!tables.Any()) return ReservationStatus.NEEDS_WAITING_LIST;

            // Successful
            reservation.reservedTables = tables;
            if (reservation.onWaitingList) reservation.onWaitingList = false;
            Globals.Reservations.Add(reservation);
            return ReservationStatus.SUCCESS;
        }

        /// <summary>Cancel an existing <see cref="Reservation" />.</summary>
        /// <param name="reservation">The <see cref="Reservation" /> to cancel</param>
        /// <returns>A <see cref="ReservationStatus"/> indicating the process was successful.</returns>
        public static ReservationStatus ProcessReservationCancel(Reservation reservation)
        {
            var _reservation = reservation.Clone();
            _reservation.reservationType = 'L';
            Globals.Reservations.Add(_reservation);
            return ReservationStatus.SUCCESS;

        }
    }
}
