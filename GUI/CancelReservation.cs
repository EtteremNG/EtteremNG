using EtteremNG.Core;
using EtteremNG.Core.Data;
using EtteremNG.Core.Logic;
using EtteremNG.Core.Utilities;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace EtteremNG.GUI
{
    /// <summary>The part of the user interface responsible for cancelling existing reservations.</summary>
    /// <seealso cref="Reservation"/>
    public partial class CancelReservation : UserControl
    {
        public CancelReservation()
        {
            InitializeComponent();
        }

        /// <summary>Processes the cancellation using details input by the user.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void ProcessCancellation(object sender, EventArgs e)
        {
            var adjusteDateTime = new DateTime(startDate.Value.Year, startDate.Value.Month, startDate.Value.Day, startTime.Value.Hour, startTime.Value.Minute, 00);
            var reservations = Globals.Reservations.Where(x => x.guestName == guestName.Text && !TableUtil.CheckIfCancelled(x) && x.reservationStart == adjusteDateTime).ToList();
            if (!reservations.Any())
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "Hiba történt:\nNem található foglalás ezzel az adatokkal!";
            }
            else
            {
                switch (ReservationDataManager.RemoveReservation(reservations.First()))
                {
                    case ReservationStatus.SUCCESS:
                        statusLabel.ForeColor = Color.Lime;
                        statusLabel.Text = "Foglalás sikeresen lemondva!";
                        var cancelledReservation = reservations.First();
                        cancelledReservation.reservationType = 'L';
                        File.AppendAllText("foglalasok.txt", $"{cancelledReservation}{Environment.NewLine}");
                        if (cancelledReservation.onWaitingList)
                        {
                            Globals.WaitingList.Remove(Globals.WaitingList.First(reservation => reservation.guestName == cancelledReservation.guestName && reservation.reservationStart == cancelledReservation.reservationStart &&
                                                         reservation.tableType == cancelledReservation.tableType));
                            File.WriteAllLines("varolista.txt", Globals.WaitingList.Select(x => x.ToString()));
                        }

                        foreach (var o in from o in Globals.Reservations.Where(x => x.onWaitingList && !TableUtil.CheckIfCancelled(x)).ToList() let r = ReservationManager.ProcessReservation(o, true) where r == ReservationStatus.SUCCESS select o)
                        {
                            File.AppendAllText("foglalasok.txt", $"{reservations}{Environment.NewLine}");
                            Globals.WaitingList.Remove(Globals.WaitingList.First(x => x.guestName == o.guestName && x.reservationStart == o.reservationStart));
                            File.WriteAllLines("varolista.txt", Globals.WaitingList.Select(item => item.ToString()));
                        }

                        new Thread(() =>
                        {
                            Thread.Sleep(5000);
                            statusLabel.BeginInvoke((MethodInvoker)delegate
                            {
                                statusLabel.Text = "";
                            });
                        }).Start();
                        break;
                    case ReservationStatus.NEEDS_WAITING_LIST:
                    case ReservationStatus.INVALID:
                    default:
                        statusLabel.ForeColor = Color.Red;
                        statusLabel.Text = "Hiba történt:\nKijavíthatatlan hiba, vegye fel a fejlesztővel a kapcsolatot!";
                        break;
                }
            }
        }
    }
}
