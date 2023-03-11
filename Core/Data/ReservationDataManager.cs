using System.Linq;
using static EtteremNG.Core.Logic.ReservationManager;

namespace EtteremNG.Core.Data
{
    internal class ReservationDataManager
    {
        /// <summary>Check if a reservation is valid, then send it for processing.</summary>
        /// <param name="reservation">The reservation to process.</param>
        /// <returns>A <see cref="ReservationStatus"/> representing the state of the operation.</returns>
        public static ReservationStatus AddReservation(Reservation reservation)
        {
            return Globals.Reservations.Count(x =>
                x.guestName == reservation.guestName && x.reservationStart == reservation.reservationStart) > 0 ? ReservationStatus.INVALID : ProcessReservation(reservation);
        }

        /// <summary>Check if a reservation exists, then send it for cancellation.</summary>
        /// <param name="reservation">The reservation to cancel.</param>
        /// <returns>A <see cref="ReservationStatus"/> representing the state of the operation.</returns>
        public static ReservationStatus RemoveReservation(Reservation reservation)
        {
            var _reservations = Globals.Reservations.Where(x =>
                x.guestName == reservation.guestName && x.reservationStart == reservation.reservationStart).ToList();

            return !_reservations.Any() ? ReservationStatus.INVALID : ProcessReservationCancel(_reservations.First());
        }
    }
}
