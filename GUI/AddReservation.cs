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
    /// <summary>The part of the user interface responsible for creating new reservations.</summary>
    /// <seealso cref="Reservation"/>
    public partial class AddReservation : UserControl
    {
        public AddReservation()
        {
            InitializeComponent();
        }

        /// <summary>Ensures that the user can only enter numbers into the chair amount field.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs" /> instance containing the event data.</param>
        private void EnsureChairInputIsNumber(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }

        /// <summary>Creates a reservation using details input by the user.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void ProcessAdd(object sender, EventArgs e)
        {
            var start = DateUtil.RemoveSeconds(startDate.Value.Date + startTime.Value.TimeOfDay);
            var end = DateUtil.RemoveSeconds(startDate.Value.Date + endTime.Value.TimeOfDay);

            var errors = "";

            if (chairAmount.Text.Length == 0)
            {
                errors += "A székek száma nincs megadva!\n";
            }
            else if (int.TryParse(chairAmount.Text, out var s))
            {
                if (s <= 0)
                {
                    errors += "A székek száma nem lehet kevesebb mint 1!\n";
                }
            }

            if (reservationType.SelectedItem == null)
            {
                errors += "Az asztal típusa nincs kiválaszva!\n";
            }

            if (string.IsNullOrWhiteSpace(guestName.Text))
            {
                errors += "A név mező nem lehet üres!\n";
            }

            if (start > end)
            {
                errors += "A foglalás vége nem lehet hamarabbi időpont, mint a kezdete!\n";
            }

            if (!Reservation.CheckDeadline(start))
            {
                errors += "A kezdet dátum az étterem nyitvatartási idején kívül van!\n";
            }

            if (!Reservation.CheckDeadline(end))
            {
                errors += "A vég dátum az étterem nyitvatartási idején kívül van!\n";
            }

            if (errors.Length > 0)
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Font = new Font("Bookman Old Style", 16, FontStyle.Regular);
                statusLabel.Text = $"Hiba történt:\n{errors}";
                return;
            }

            var reservation = new Reservation
            {
                // ReSharper disable once PossibleNullReferenceException
                tableType = reservationType.SelectedItem.ToString()[0],
                guestName = guestName.Text,
                reservationType = 'F',
                reservationStart = start,
                reservationEnd = end,
                chairAmount = Convert.ToInt32(chairAmount.Text)
            };

            switch (ReservationDataManager.AddReservation(reservation))
            {
                case ReservationStatus.SUCCESS:
                    statusLabel.ForeColor = Color.Lime;
                    statusLabel.Font = new Font("Bookman Old Style", 21, FontStyle.Regular);
                    statusLabel.Text = "A foglalás rögzítve lett!";
                    File.AppendAllText("foglalasok.txt", $"{reservation}{Environment.NewLine}");
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
                    {
                        var res = MessageBox.Show("A foglalás jelenleg nem teljesíthető, szeretne-e a vendég várólistára kerülni?", "Várólista", MessageBoxButtons.YesNo);
                        switch (res)
                        {
                            case DialogResult.Yes:
                                reservation.onWaitingList = true;
                                reservation.reservedTables.Add(SpecialTables.WAITLIST);
                                var r = ReservationManager.ProcessReservation(reservation);
                                switch (r)
                                {
                                    case ReservationStatus.SUCCESS:
                                        statusLabel.ForeColor = Color.Green;
                                        statusLabel.Font = new Font("Bookman Old Style", 21, FontStyle.Regular);
                                        statusLabel.Text = "A foglalás várólistázva lett!";
                                        Globals.WaitingList.Add(new WaitingList(reservation.guestName, DateUtil.StringFromDate(reservation.reservationStart), reservation.tableType));
                                        File.WriteAllLines("varolista.txt", Globals.WaitingList.Select(x => x.ToString()));
                                        File.AppendAllText("foglalasok.txt", $"{reservation}{Environment.NewLine}");
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
                                        statusLabel.Font = new Font("Bookman Old Style", 16, FontStyle.Regular);
                                        statusLabel.Text = "Hiba történt:\nKijavíthatatlan hiba, vegye fel a fejlesztővel a kapcsolatot!";
                                        break;
                                }
                                break;
                            case DialogResult.No:
                                reservation.reservedTables.Add(SpecialTables.GONE);
                                File.AppendAllText("foglalasok.txt", $"{reservation}{Environment.NewLine}");
                                break;
                            case DialogResult.None:
                            case DialogResult.OK:
                            case DialogResult.Cancel:
                            case DialogResult.Abort:
                            case DialogResult.Retry:
                            case DialogResult.Ignore:
                            default:
                                break;
                        }
                        break;
                    }
                case ReservationStatus.INVALID:
                    statusLabel.ForeColor = Color.Red;
                    statusLabel.Font = new Font("Bookman Old Style", 16, FontStyle.Regular);
                    statusLabel.Text = "Hiba történt:\nEz a foglalás már létezik, vagy az adatok helytelenül lettek megadva!";
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
