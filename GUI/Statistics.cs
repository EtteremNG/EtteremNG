using EtteremNG.Core.Data.Stats;
using System;
using System.Windows.Forms;

namespace EtteremNG.GUI
{
    /// <summary>The part of the user interface responsible for displaying statistics.</summary>
    public partial class Statistics : UserControl
    {
        public Statistics()
        {
            InitializeComponent();
        }
        /// <summary>Specifies if statistics should be generated.</summary>
        private bool statisticsEnabled;
        /// <summary>Recalculates the statistics when the Calculate button is pressed.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void CalculateStatistics(object sender, EventArgs e)
        {
            statisticsEnabled = true;
            UpdateStatistics();
        }

        /// <summary>Parses the data received from <see cref="StatisticsGenerator">the statistics generator</see>, and adds it to the statistics view for display.</summary>
        private void UpdateStatistics()
        {
            if (!statisticsEnabled) return;
            var StartDate = new DateTime(startDate.Value.Year, startDate.Value.Month, startDate.Value.Day, 00, 00, 00);
            var EndDate = new DateTime(endDate.Value.Year, endDate.Value.Month, endDate.Value.Day, 23, 59, 59);
            var Statistics = new StatisticsGenerator(StartDate, EndDate);
            StatisticsView.Nodes.Clear();
            if (Statistics.TimeFrameContainsReservations)
            {
                StatisticsView.Nodes.Add("belter", "Beltéri");
                StatisticsView.Nodes.Add("kulter", "Kültéri");
                StatisticsView.Nodes.Add("generic", "Általános");

                StatisticsView.Nodes[0].Nodes.Add($"Igények száma: {Statistics.IndoorsReservationsTotal}");
                StatisticsView.Nodes[0].Nodes.Add($"Sikeresen teljesített igények száma: {Statistics.CompletedIndoorsReservations}");
                StatisticsView.Nodes[0].Nodes
                    .Add($"Sikeresen teljesített várólistázott igények száma: {Statistics.LaterCompletedIndoorsReservations}");
                StatisticsView.Nodes[0].Nodes.Add($"Lemondott igények száma: {Statistics.NotCompletedIndoorsReservations}");

                StatisticsView.Nodes[1].Nodes.Add($"Igények száma: {Statistics.OutdoorsReservationsTotal}");
                StatisticsView.Nodes[1].Nodes.Add($"Sikeresen teljesített igények száma: {Statistics.CompeltedOutdoorsReservations}");
                StatisticsView.Nodes[1].Nodes
                    .Add($"Sikeresen teljesített várólistázott igények száma: {Statistics.LaterCompletedOutdoorsReservations}");
                StatisticsView.Nodes[1].Nodes.Add($"Lemondott igények száma: {Statistics.NotCompletedOutdoorsReservations}");

                StatisticsView.Nodes[2].Nodes.Add($"Várólistázott igények száma: {Statistics.WaitingListCount}");
                StatisticsView.Nodes[2].Nodes.Add($"Nem teljesített igények száma: {Statistics.NotCompletedReservations}");
            }
            else
            {
                StatisticsView.Nodes.Add("error", "A megadott időszakban nem volt foglalás!");
            }
            StatisticsView.ExpandAll();
        }

        /// <summary>Clear statistics if statistics tab is no longer focused.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnLeave(object sender, EventArgs e)
        {
            statisticsEnabled = false;
            StatisticsView.Nodes.Clear();
        }
    }
}
