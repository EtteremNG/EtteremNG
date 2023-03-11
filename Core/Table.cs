using System;

namespace EtteremNG.Core
{
    /// <summary>Contains information related to a table.</summary>
    public class Table
    {
        #region Public variables
        /// <summary>The table's unique identifier.</summary>
        public int ID;

        /// <summary>Maximum amount of people that can be seated at the table.</summary>
        public int maxCapacity;

        /// <summary>Type of table (indoors or outdoors)</summary>
        public char tableType;
        #endregion

        #region Function Overrides
        /// <summary>Converts the table object into a string.</summary>
        /// <returns>A <see cref="string" /> which represents the table.</returns>
        public override string ToString()
        {
            return $"{ID};{maxCapacity};{tableType}";
        }

        /// <summary>Converts a string containing details about a table into a <see cref="Table"/> object.</summary>
        /// <returns>A <see cref="Table" /> object.</returns>
        public static Table FromString(string tableData)
        {
            var tableDataPieces = tableData.Split(';');
            return new Table
            {
                ID = Convert.ToInt32(tableDataPieces[0]),
                maxCapacity = Convert.ToInt32(tableDataPieces[1]),
                tableType = tableDataPieces[2][0]
            };
        }

        #endregion
    }
}
