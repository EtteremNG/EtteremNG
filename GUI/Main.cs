using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace EtteremNG.GUI
{
    /// <summary>The "Main" form, which contains buttons that go to the other parts of the program.</summary>
    public partial class Main : Form
    {
        private static bool drag;
        private Point startPoint = new Point(0, 0);
        public int posY;
        public Main()
        {
            InitializeComponent();
            SelectedTabMarker.Location = new Point(2, 30);
            AddReservationPage.BringToFront();
        }

        /// <summary>Asks the user if they actually want to quit when the exit button is clicked.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnExitButtonClick(object sender, EventArgs e)
        {
            var doExit = MessageBox.Show("Biztosan ki szeretne lépni?", "Kilépés", MessageBoxButtons.YesNo);
            // ReSharper disable once SwitchStatementMissingSomeEnumCasesNoDefault
            switch (doExit)
            {
                case DialogResult.Yes:
                    Application.Exit();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        /// <summary>Handles all click events coming from the buttons on the sidebar, opening the appropriate pages of the application.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void GenericButtonClickHandler(object sender, EventArgs e)
        {
            var selectedButton = (Button)sender;
            switch (selectedButton.Text)
            {
                case "Foglalás felvétel":
                    AddReservationPage.BringToFront();
                    break;
                case "Foglalás lemondás":
                    CancelReservationPage.BringToFront();
                    break;
                case "Statisztika":
                    StatisticsPage.BringToFront();
                    break;
                case "Asztal térkép":
                    TableMapPage.BringToFront();
                    break;
                case "Névjegy":
                    AboutPage.BringToFront();
                    break;
            }

            posY = selectedButton.Location.Y;
            buttonAnimationHandler.Start();
        }

        /// <summary>Manages the item selection animation for the sidebar.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void MoveSelectedItem(object sender, EventArgs e)
        {
            var panelPosY = SelectedTabMarker.Location.Y - 1;
            var speedVector = Math.Abs((posY - panelPosY) / 8);

            if (panelPosY >= posY)
            {
                SelectedTabMarker.Location = new Point(0, panelPosY - speedVector);
            }
            else if (panelPosY <= posY)
            {
                SelectedTabMarker.Location = new Point(0, panelPosY + speedVector);
            }
            else
            {
                buttonAnimationHandler.Stop();
            }
        }

        /// <summary>Sets the current time to be displayed when the application is first loaded.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnLoad(object sender, EventArgs e)
        {
            currentTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        /// <summary>Updates the time displayed.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void UpdateTime(object sender, EventArgs e)
        {
            currentTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        /// <summary>Handles dragging of the window title bar.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="MouseEventArgs" /> instance containing the event data.</param>
        public void BackgroundMoveStart(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        /// <summary>Handles dragging of the window title bar.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="MouseEventArgs" /> instance containing the event data.</param>
        public void BackgroundMoveEnd(object sender, MouseEventArgs e)
        {
            startPoint = e.Location;
            drag = true;
        }

        /// <summary>Handles dragging of the window title bar.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="MouseEventArgs" /> instance containing the event data.</param>
        public void BackgroundMove(object sender, MouseEventArgs e)
        {
            if (!drag) return;
            var p1 = new Point(e.X, e.Y);
            var p2 = PointToScreen(p1);
            var p3 = new Point(p2.X - startPoint.X, 
                p2.Y - startPoint.Y);
            Location = p3;
        }

        /// <summary>Processes a command key.</summary>
        /// <param name="msg">A <see cref="T:System.Windows.Forms.Message">Message</see>, passed by reference, that represents the Win32 message to process.</param>
        /// <param name="keyData">One of the <see cref="T:System.Windows.Forms.Keys">Keys</see> values that represents the key to process.</param>
        /// <returns>
        ///   <c>true</c> if the keystroke was processed and consumed by the control; otherwise, <c>false</c> to allow further processing.</returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData != Keys.F1) return base.ProcessCmdKey(ref msg, keyData);
            new Process
            {
                StartInfo = new ProcessStartInfo(Path.Combine(Directory.GetCurrentDirectory(), "userdocs/index.html"))
                {
                    UseShellExecute = true
                }
            }.Start();
            return true;
        }
    }
}