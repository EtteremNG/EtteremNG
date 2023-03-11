using EtteremNG.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EtteremNG.Core.Utilities
{
    /// <summary>Contains utility functions for working with <see cref="Table"/> objects.</summary>
    internal class TableUtil
    {
        /// <summary>Returns the Table associated with an identifier.</summary>
        /// <param name="ID">The identifier of the table to get.</param>
        /// <returns>The <see cref="Table"/> object associated with the specified identifier.</returns>
        public static Table GetTableByID(int ID)
        {
            switch (ID)
            {
                case -1:
                    return SpecialTables.WAITLIST;
                case -2:
                    return SpecialTables.GONE;
                default:
                    return Globals.Tables.First(x => x.ID == ID);
            }
        }

        /// <summary>Try to assign tables matching a criteria to a reservation.</summary>
        /// <param name="type">The type of table to assign.</param>
        /// <param name="requiredCapacity">The total amount of people to fit at the table(s).</param>
        /// <param name="startTime">The starting time of the reservation.</param>
        /// <returns>A <see cref="List{Table}">list of tables</see> that meet the criteria, if assigning tables fails, an empty list is returned.</returns>
        public static List<Table> TryToAssignTables(char type, int requiredCapacity, DateTime startTime)
        {
            // Tables that are already taken by another reservation - these should not be assigned.
            var busyTables = new List<Table>();
            var l = Globals.Reservations.Where(x =>
                x.tableType == type && x.reservationType == 'F' && !CheckIfCancelled(x) && CheckTimeCollision(x.reservationEnd, startTime)).ToList();
            l.ForEach(x => x.reservedTables.ForEach(y =>
            {
                busyTables.Add(y);
            }));

            return GetFilteredTableList(busyTables, requiredCapacity, type);
        }

        public static bool CheckIfCancelled(Reservation reservation)
        {
            var f = Globals.Reservations.Where(x =>
                x.guestName == reservation.guestName && x.reservationType == 'L' &&
                x.reservationStart == reservation.reservationStart && x.reservationEnd == reservation.reservationEnd);
            return f.Any();
        }

        private static bool CheckTimeCollision(DateTime endTime, DateTime startTime)
        {
            if (endTime.Ticks == startTime.Ticks)
            {
                return true;
            }

            return endTime.AddMinutes(10).Ticks >= startTime.Ticks;
        }

        /// <summary>Get a list of tables matching a specific criteria, excluding busy tables.</summary>
        /// <param name="busyTables">A list of tables that are currently taken by another reservation.</param>
        /// <param name="requiredCapacity">The required amount of seats.</param>
        /// <param name="type">The type of table required (indoors or outdoors).</param>
        /// <returns>A <see cref="List{Table}">list of tables</see> that meet the criteria, if assigning tables fails, an empty list is returned.</returns>
        private static List<Table> GetFilteredTableList(ICollection<Table> busyTables, int requiredCapacity, char type)
        {
            var tables = new List<Table>();
            // First, try to find a table with exactly "requiredCapacity" seats.
            var oneTable = Globals.Tables.Where(x => x.tableType == type && x.maxCapacity >= requiredCapacity && !busyTables.Contains(x)).ToArray();
            if (!oneTable.Any())
            {
                // If that failed, try to push together multiple tables.
                var potentialTables = Globals.Tables.Where(x => x.tableType == type && !busyTables.Contains(x)).ToArray();
                var pushedTogetherTables = new List<Table>();
                foreach (var table in potentialTables)
                {
                    pushedTogetherTables.Add(table);
                    if (CalculateMergedSum(pushedTogetherTables) >= requiredCapacity)
                    {
                        break;
                    }
                }

                if (CalculateMergedSum(pushedTogetherTables) >= requiredCapacity)
                {
                    return pushedTogetherTables;
                }
            }
            else
            {
                tables.Add(oneTable.First());
                return tables;
            }

            // Failed - Return empty list
            return new List<Table>();
        }

        /// <summary>Calculate how many people can be seated at a table that has been pushed together with other tables.</summary>
        /// <param name="pushedTogetherTables">List of pushed together tables</param>
        /// <returns>A <see cref="int">number</see> representing the total amount of available seats.<br /></returns>
        private static int CalculateMergedSum(IReadOnlyCollection<Table> pushedTogetherTables)
        {
            return pushedTogetherTables.Sum(x => x.maxCapacity) - (pushedTogetherTables.Count - 1) * 2;
        }
    }
}
