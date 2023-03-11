using EtteremNG.Core;
using EtteremNG.Core.Data;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EtteremNG.GUI
{
    /// <summary>This class is responsible for displaying the current state of all the tables.</summary>
    public partial class TableMap : UserControl
    {
        public TableMap()
        {
            InitializeComponent();
        }

        /// <summary>Updates the data shown on the table view to match the current state.</summary>
        public void UpdateTableView()
        {
            indoorReservations.Rows.Clear();
            outdoorReservations.Rows.Clear();
            foreach (var table in Globals.Tables)
            {
                var reservations = Globals.Reservations.Where(x => x.reservedTables.Contains(table) && Reservation.IsActiveReservation(x)).ToList();
                foreach (var tables in reservations.Select(reservation => reservation.reservedTables.Select(x => x.ID).ToList()))
                {
                    switch (table.tableType)
                    {
                        case 'B':
                            indoorReservations.Rows.Add(table.ID, "Foglalt", tables.Count > 1 ? $"Igen ({string.Join(", ", tables)})" : "Nem");
                            break;
                        case 'K':
                            outdoorReservations.Rows.Add(table.ID, "Foglalt", tables.Count > 1 ? $"Igen ({string.Join(", ", tables)})" : "Nem");
                            break;
                    }
                }

                if (!reservations.Any())
                {
                    switch (table.tableType)
                    {
                        case 'B':
                            indoorReservations.Rows.Add(table.ID, "Szabad", "Nem");
                            break;
                        case 'K':
                            outdoorReservations.Rows.Add(table.ID, "Szabad", "Nem");
                            break;
                    }
                }
            }
        }
    }
}
