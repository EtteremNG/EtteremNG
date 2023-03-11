using EtteremNG.Core;
using EtteremNG.Core.Data;
using EtteremNG.GUI;
using System;
using System.IO;
using System.Windows.Forms;

namespace EtteremNG
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Init(true, true, true);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }

        /// <summary>Initialize the datasets used by the application.</summary>
        /// <param name="initTables">If <c>true</c>, table data will be loaded from file.</param>
        /// <param name="initReservations">If <c>true</c>, reservation data will be loaded from file.</param>
        /// <param name="initWaitingList">If <c>true</c>, waiting list data will be loaded from file.</param>
        public static void Init(bool initTables, bool initReservations, bool initWaitingList)
        {

            if (initWaitingList)
            {
                foreach (var waitingListItem in File.ReadAllLines("varolista.txt"))
                {
                    Globals.WaitingList.Add(WaitingList.FromString(waitingListItem));
                }
            }

            if (initTables)
            {
                foreach (var table in File.ReadAllLines("asztalok.txt"))
                {
                    Globals.Tables.Add(Table.FromString(table));
                }
            }

            if (!initReservations) return;
            foreach (var reservation in File.ReadAllLines("foglalasok.txt"))
            {
                Globals.Reservations.Add(Reservation.FromString(reservation));
            }
        }
    }
}
