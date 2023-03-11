using EtteremNG.Core.Utilities;
using System;

namespace EtteremNG.Core.Data
{
    /// <summary>Contains information related to a waiting list item.</summary>
    internal class WaitingList
    {
        /// <summary>The name of the guest.</summary>
        public string guestName;

        /// <summary>Start date of the associated reservation.</summary>
        public DateTime reservationStart;

        /// <summary>Type of table requested (indoors or outdoors)</summary>
        public char tableType;

        /// <summary>A string representation of the reservation start date.</summary>
        private readonly string _reservationStart;

        /// <summary>Initializes a new instance of the <see cref="WaitingList" /> class.</summary>
        /// <param name="guestName">Name of the guest.</param>
        /// <param name="reservationStart">The start date of the reservation.</param>
        /// <param name="tableType">Type of table requested (indoors or outdoors).</param>
        public WaitingList(string guestName, string reservationStart, char tableType)
        {
            this.guestName = guestName;
            this.reservationStart = DateUtil.DateTimeFromString(reservationStart);
            _reservationStart = reservationStart;
            this.tableType = tableType;
        }

        /// <summary>Converts the waiting list item into a string.</summary>
        /// <returns>A <see cref="string" /> which represents the waiting list item.</returns>
        public override string ToString()
        {
            return $"{guestName};{_reservationStart};{tableType}";
        }

        /// <summary>Converts a string containing details about a waiting list item into a <see cref="WaitingList"/> object.</summary>
        /// <returns>A <see cref="WaitingList" /> object.</returns>
        public static WaitingList FromString(string waitingListItem)
        {
            var res = waitingListItem.Split(';');
            return new WaitingList(res[0], res[1], res[2][0]);
        }
    }
}