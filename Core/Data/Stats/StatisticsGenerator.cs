using System;
using System.Linq;

namespace EtteremNG.Core.Data.Stats
{

    /// <summary>This class is responsible for generating statistics related to reservations within a certain time period.</summary>
    internal class StatisticsGenerator
    {
        /// <summary>The total amount of reservations that were made indoors.</summary>
        public int IndoorsReservationsTotal;
        /// <summary>The total amount of reservations that were made outdoors.</summary>
        public int OutdoorsReservationsTotal;

        /// <summary>The total amount of customers that were placed on the waiting list during the specified time period.</summary>
        public int WaitingListCount;

        /// <summary>The total amount of indoors reservations that were successfully fullfilled.</summary>
        public int CompletedIndoorsReservations;
        /// <summary>The total amount of outdoors reservations that were successfully fullfilled.</summary>
        public int CompeltedOutdoorsReservations;

        /// <summary>The total amount of indoors reservations that were not fullfilled during opening hours.</summary>
        public int NotCompletedIndoorsReservations;
        /// <summary>The total amount of outdoors reservations that were not fullfilled during opening hours.</summary>
        public int NotCompletedOutdoorsReservations;

        /// <summary>The total amount of indoors reservations that were successfully fullfilled after previously being placed on the waiting list.</summary>
        public int LaterCompletedIndoorsReservations;
        /// <summary>The total amount of outdoors reservations that were successfully fullfilled after previously being placed on the waiting list.</summary>
        public int LaterCompletedOutdoorsReservations;

        /// <summary>The total amount of reservations that were not fulfilled at all.</summary>
        public int NotCompletedReservations;

        /// <summary>This variable is set to true if the time frame contains at least one reservation of any kind.</summary>
        public bool TimeFrameContainsReservations;

        /// <summary>Calculates statistics for a certain time period, given the start and end dates.</summary>
        /// <param name="start">The start of the time period which statistics should be generated for.</param>
        /// <param name="end">The end of the time period which statistics should be generated for.</param>
        public StatisticsGenerator(DateTime start, DateTime end)
        {
            var reservations = Globals.Reservations.Where(x => x.reservationStart >= start && x.reservationEnd < end).ToList();
            foreach (var reservation in reservations)
            {
                switch (reservation.reservationType)
                {
                    case 'F':
                        {
                            switch (reservation.tableType)
                            {
                                case 'B':
                                    IndoorsReservationsTotal++;
                                    break;
                                case 'K':
                                    OutdoorsReservationsTotal++;
                                    break;
                            }

                            if (CheckNoWaitingList(reservation))
                            {
                                switch (reservation.tableType)
                                {
                                    case 'B':
                                        CompletedIndoorsReservations++;
                                        break;
                                    case 'K':
                                        CompeltedOutdoorsReservations++;
                                        break;
                                }
                            }

                            if (reservation.onWaitingList)
                            {
                                WaitingListCount++;
                                Globals.Reservations.ForEach(x =>
                                {
                                    if (!Equals(x, reservation) || reservation.reservedTables[0].ID != -1 ||
                                        x.reservedTables[0].ID == -1 || x.reservedTables[0].ID == -2) return;
                                    switch (x.reservedTables[0].tableType)
                                    {
                                        case 'B':
                                            LaterCompletedIndoorsReservations++;
                                            break;
                                        case 'K':
                                            LaterCompletedOutdoorsReservations++;
                                            break;
                                    }
                                });
                            }
                        }
                        break;
                    case 'L':
                        switch (reservation.tableType)
                        {
                            case 'B':
                                NotCompletedIndoorsReservations++;
                                break;
                            case 'K':
                                NotCompletedOutdoorsReservations++;
                                break;
                        }
                        break;
                }

                if (reservation.reservedTables[0].ID == -2)
                {
                    NotCompletedReservations++;
                }
            }

            if (reservations.Any())
            {
                TimeFrameContainsReservations = true;
            }
            NotCompletedReservations += WaitingListCount - LaterCompletedIndoorsReservations - LaterCompletedOutdoorsReservations;
        }

        /// <summary>Test if the details of two reservation objects match.</summary>
        /// <param name="a">The first reservation.</param>
        /// <param name="b">The second reservation.</param>
        /// <returns> <c>true</c> if the reservations are the same, <c>false</c> otherwise.</returns>
        private static bool Equals(Reservation a, Reservation b)
        {
            return a.chairAmount == b.chairAmount && a.guestName == b.guestName && a.reservationStart == b.reservationStart && a.reservationEnd == b.reservationEnd && a.reservationType == b.reservationType;
        }

        /// <summary>Checks to ensure a reservation was not placed on the waiting list.</summary>
        /// <param name="reservation">The reservation to check</param>
        /// <returns><c>true</c> if the reservation was found on the waiting list, <c>false</c> otherwise.</returns>
        private static bool CheckNoWaitingList(Reservation reservation)
        {
            var f = Globals.Reservations.Where(x =>
                x.guestName == reservation.guestName && x.reservationStart == reservation.reservationStart &&
                x.reservationEnd == reservation.reservationEnd && x.chairAmount == reservation.chairAmount).ToList();
            if (f.Any())
            {
                return f.Count(x => x.onWaitingList) <= 0;
            }

            return false;
        }
    }
}