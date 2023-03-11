using EtteremNG.Core.Data;
using EtteremNG.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using static EtteremNG.Core.Utilities.DateUtil;

namespace EtteremNG.Core
{
    /// <summary>Contains information related to a reservation.</summary>
    public class Reservation
    {
        #region Public variables
        /// <summary>The name of the guest.</summary>
        public string guestName;

        /// <summary>Type of reservation (new or cancelled).</summary>
        public char reservationType;

        /// <summary>Start date of the reservation.</summary>
        public DateTime reservationStart;

        /// <summary>End date of the reservation.</summary>
        public DateTime reservationEnd;

        /// <summary>Amount of chairs requested.</summary>
        public int chairAmount;

        /// <summary>Type of table requested (indoors or outdoors)</summary>
        public char tableType;

        /// <summary>List of tables related to the reservation.</summary>
        public List<Table> reservedTables = new List<Table>();

        /// <summary>Specifies if the reservation has been placed on a waiting list.</summary>
        public bool onWaitingList;
        #endregion

        #region Function Overrides
        /// <summary>Converts the reservation object into a string.</summary>
        /// <returns>A <see cref="string" /> which represents the reservation.</returns>
        public override string ToString()
        {
            return $"{guestName};{reservationType};{reservationStart:MM-dd HH:mm};{reservationEnd:HH:mm};{chairAmount};{string.Join(";", reservedTables.Select(x => x.ID))}";
        }

        #endregion

        #region Public Functions

        /// <summary>Converts a string containing details about a reservation into a Reservation object.</summary>
        /// <returns>A <see cref="Reservation" /> object.</returns>
        public static Reservation FromString(string reservationData)
        {
            var reservationDataPieces = reservationData.Split(';');
            var reservation = new Reservation
            {
                guestName = reservationDataPieces[0],
                reservationType = reservationDataPieces[1][0],
                reservationStart = DateTimeFromString(reservationDataPieces[2]),
                reservationEnd = DateTimeFromString(reservationDataPieces[2], reservationDataPieces[3]),
                chairAmount = Convert.ToInt32(reservationDataPieces[4]),
            };

            foreach (var table in reservationDataPieces.Skip(5).Select(x => Convert.ToInt32(x)))
            {
                if (table == -1)
                {
                    reservation.onWaitingList = true;
                }

                reservation.reservedTables.Add(TableUtil.GetTableByID(table));
            }

            reservation.tableType = reservation.onWaitingList
                ? Globals.WaitingList
                    .First(x => x.guestName == reservation.guestName && x.reservationStart == reservation.reservationStart)
                    .tableType
                : reservation.reservedTables[0].tableType;

            return reservation;
        }
        #endregion

        /// <summary>Clones this instance.</summary>
        /// <returns>A Reservation object with the same details.</returns>
        public Reservation Clone()
        {
            return new Reservation
            {
                reservedTables = reservedTables,
                reservationStart = reservationStart,
                tableType = tableType,
                reservationEnd = reservationEnd,
                chairAmount = chairAmount,
                reservationType = reservationType,
                onWaitingList = onWaitingList,
                guestName = guestName
            };
        }

        /// <summary>Determines whether the specified reservation is currently active.</summary>
        /// <param name="reservation">The reservation to check</param>
        /// <returns>
        ///   <c>true</c> if the reservation is active, otherwise <c>false</c>
        /// </returns>
        public static bool IsActiveReservation(Reservation reservation)
        {
            return DateTime.Now.Ticks > reservation.reservationStart.Ticks && DateTime.Now.Ticks < reservation.reservationEnd.Ticks;
        }

        /// <summary>Checks if a reservation is within the operating hours of the restaurant.</summary>
        /// <param name="time">The time to check.</param>
        /// <returns><c>true</c> if the reservation is within the operating hours, otherwise <c>false</c></returns>
        public static bool CheckDeadline(DateTime time)
        {
            if (time.Hour == 22 && time.Minute != 00 || time.Hour > 22) return false;
            return time.Hour >= 06 || time.Minute < 00;
        }
    }
}
