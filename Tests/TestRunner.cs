using EtteremNG.Core;
using EtteremNG.Core.Data;
using EtteremNG.Core.Data.Stats;
using EtteremNG.Core.Logic;
using EtteremNG.Core.Utilities;
using System.Linq;
using Xunit;

namespace EtteremNG.Tests
{
    /// <summary>Executes tests to ensure the software is working as intended by the developer.</summary>
    public class TestRunner
    {
        /// <summary>The reservation data to be used for running tests, this is a static value and is not affected by the data loaded at runtime.</summary>
        private const string Reservations = "Példa Tibor;F;12-02 10:30;14:00;5;1;2\r\nPélda1 Tibor;F;12-02 15:30;20:00;2;-2\r\nPélda2 Tibor;F;12-02 20:15;21:00;10;2;5\r\nPélda3 Tibor;L;12-02 21:00;22:00;5;1;2\r\nPélda4 Tibor;F;12-03 14:30;16:00;4;-1\r\nPélda5 Tibor;L;12-03 14:00;20:00;8;6\r\nPélda6 Tibor;F;12-03 20:00;22:00;9;1;7\r\nPélda7 Tibor;F;12-04 18:00;22:00;11;1;2\r\nPélda8 Tibor;F;12-04 11:00;13:00;3;-1\r\nPélda4 Tibor;F;12-03 14:30;16:00;4;3";

        /// <summary>The table data to be used for running tests, this is a static value and is not affected by the data loaded at runtime.</summary>
        private const string Tables = "1;4;B\r\n2;4;B\r\n3;8;K\r\n4;6;K\r\n5;8;B\r\n6;4;K\r\n7;6;B\r\n8;6;K\r\n9;8;B\r\n10;4;K\r\n11;6;K\r\n12;6;B\r\n13;8;K\r\n14;4;K\r\n15;6;B\r\n16;8;K\r\n17;8;B\r\n18;6;K\r\n19;4;B\r\n20;8;K\r\n21;4;K\r\n22;6;B";

        /// <summary>The waiting list data to be used for running tests, this is a static value and is not affected by the data loaded at runtime.</summary>
        private const string WaitingList =
            "Példa3 Tibor;12-02 21:00;B\r\nPélda4 Tibor;12-02 16:00;B\r\nPélda4 Tibor;12-03 14:30;K\r\nPélda8 Tibor;12-04 11:00;K";

        /// <summary>Loads the necessary data required before a test is executed.</summary>
        /// <param name="initTables">if set to <c>true</c>, table data is loaded.</param>
        /// <param name="initReservations">if set to <c>true</c>, reservation data is loaded.</param>
        /// <param name="initWaitingList">if set to <c>true</c> waiting list data is loaded..</param>
        private static void InitTest(bool initTables, bool initReservations, bool initWaitingList)
        {

            if (initWaitingList)
            {
                foreach (var WaitingListItem in WaitingList.Split('\n'))
                {
                    Globals.WaitingList.Add(Core.Data.WaitingList.FromString(WaitingListItem));
                }
            }

            if (initTables)
            {
                foreach (var Table in Tables.Split('\n'))
                {
                    Globals.Tables.Add(Core.Table.FromString(Table));
                }
            }

            if (!initReservations) return;
            foreach (var Reservation in Reservations.Split('\n'))
            {
                Globals.Reservations.Add(Core.Reservation.FromString(Reservation));
            }
        }

        /// <summary>This test ensures the table data parser is working properly.</summary>
        /// <param name="value">A <c>string</c> containing information about a table.</param>
        [Theory]
        [InlineData("1;4;B")]
        [InlineData("2;4;B")]
        [InlineData("3;8;K")]
        [InlineData("4;6;K")]
        [InlineData("5;8;B")]
        [InlineData("6;4;K")]
        [InlineData("7;6;B")]
        [InlineData("8;6;K")]
        [InlineData("9;8;B")]
        [InlineData("10;4;K")]
        public void TableParserTest(string value)
        {
            Assert.Equal(value, Table.FromString(value).ToString());
        }

        /// <summary>This test ensures the reservation data parser is working properly.</summary>
        /// <param name="value">A <c>string</c> containing information about a reservation.</param>
        [Theory]
        [InlineData("Példa Tibor;F;12-02 10:30;14:00;5;1;2")]
        [InlineData("Példa1 Tibor;F;12-02 15:30;20:00;2;1")]
        [InlineData("Példa2 Tibor;F;12-02 20:15;21:00;10;2;5")]
        [InlineData("Példa3 Tibor;L;12-02 21:00;22:00;5;1;2")]
        [InlineData("Példa4 Tibor;F;12-03 14:30;16:00;4;1")]
        [InlineData("Példa5 Tibor;L;12-03 14:00;20:00;8;5")]
        [InlineData("Példa6 Tibor;F;12-03 20:00;22:00;9;1;7")]
        [InlineData("Példa7 Tibor;F;12-04 18:00;22:00;11;1;2")]
        [InlineData("Példa8 Tibor;F;12-04 11:00;13:00;3;6")]
        public void ReservationParserTest(string value)
        {
            InitTest(true, false, false);
            Assert.Equal(value, Reservation.FromString(value).ToString());
        }

        /// <summary>This test ensures that the software assigns the correct tables to a reservation.</summary>
        /// <param name="value">A <c>string[]</c> containing information about a reservation, and the type of table which was requested.</param>
        [Theory]
        [InlineData("Példa1 Tibor;F;12-02 15:30;20:00;2;1", "B")]
        [InlineData("Példa4 Tibor;F;12-03 14:30;16:00;4;3", "K")]
        [InlineData("Példa8 Tibor;F;12-04 11:00;13:00;3;1", "B")]
        [InlineData("Példa9 Tibor;F;12-05 12:00;13:00;2;3", "K")]
        [InlineData("Példa10 Tibor;F;12-05 14:00;15:00;8;5", "B")]
        [InlineData("Példa11 Tibor;F;12-05 14:00;15:00;8;3", "K")]
        public void ReserveTablesSingleReservationTest(params string[] value)
        {
            InitTest(true, false, false);
            Globals.Reservations.Clear();
            var reservation = Reservation.FromString(value[0]);
            reservation.tableType = value[1][0];
            reservation.reservedTables.Clear();

            ReservationManager.ProcessReservation(reservation);
            Assert.Equal(value[0], Globals.Reservations.First().ToString());
        }

        /// <summary>This test ensures that the software assigns the correct tables to a series of reservations.</summary>
        /// <param name="value">A <c>string[]</c> containing information about multiple reservations.</param>
        [Theory]
        [InlineData("Példa1 Tibor;F;12-02 15:30;20:00;2;1", "Példa2 Tibor;F;12-02 21:00;22:00;2;1")]
        [InlineData("Példa4 Tibor;F;12-03 14:30;16:00;4;1", "Példa4 Tibor;F;12-03 16:30;17:00;4;1")]
        [InlineData("Példa8 Tibor;F;12-04 11:00;13:00;3;1", "Példa8 Tibor;F;12-04 13:00;14:00;3;2")]
        [InlineData("Példa8 Tibor;F;12-04 11:00;13:00;3;1", "Példa8 Tibor;F;12-04 13:00;14:00;3;2", "Példa8 Tibor;F;12-04 13:00;15:00;3;5")]
        public void ReserveTablesMultipleReservationsTest(params string[] value)
        {
            InitTest(true, false, false);
            Globals.Reservations.Clear();
            foreach (var s in value)
            {
                var reservation = Reservation.FromString(s);
                reservation.tableType = 'B';
                reservation.reservedTables.Clear();

                ReservationManager.ProcessReservation(reservation);
            }

            Assert.Equal(value, Globals.Reservations.Select(x => x.ToString()));
        }

        /// <summary>This test ensures that the software assigns the correct tables to a reservation where pushing together multiple tables is required.</summary>
        /// <param name="value">A <c>string[]</c> containing information about a reservation, and the type of table which was requested.</param>
        [Theory]
        [InlineData("Példa1 Tibor;F;12-02 15:30;20:00;11;3;4", "K")]
        public void ReserveMultipleTablesSingleReservationsTest(params string[] value)
        {
            InitTest(true, false, false);
            Globals.Reservations.Clear();
            var reservation = Reservation.FromString(value[0]);
            reservation.tableType = value[1][0];
            reservation.reservedTables.Clear();

            ReservationManager.ProcessReservation(reservation);
            Assert.Equal(value[0], Globals.Reservations.First().ToString());
        }

        /// <summary>This test ensures that the software assigns the correct tables to a series of reservations where pushing together multiple tables is required (The type of table requested is assumed to be outdoors).</summary>
        /// <param name="value">A <c>string[]</c> containing information about a series of reservations.</param>
        [Theory]
        [InlineData("Példa1 Tibor;F;12-02 15:30;20:00;16;3;4;6;8", "Példa1 Tibor2;F;12-02 15:30;21:00;16;10;11;13;14")]
        public void ReserveMultipleTablesMultipleReservationsTest(params string[] value)
        {
            InitTest(true, false, false);
            Globals.Reservations.Clear();
            foreach (var s in value)
            {
                var reservation = Reservation.FromString(s);
                reservation.tableType = 'K';
                reservation.reservedTables.Clear();

                ReservationManager.ProcessReservation(reservation);
            }

            Assert.Equal(value, Globals.Reservations.Select(x => x.ToString()));
        }

        /// <summary>This test ensures that cancellation of an existing reservation is processed properly.</summary>
        /// <param name="value">A <c>string[]</c> containing information about a series of reservations.</param>
        [Theory]
        [InlineData("Példa1 Tibor;F;12-02 15:30;20:00;2;1", "Példa1 Tibor;L;12-02 15:30;20:00;2;1", "Példa3 Tibor;F;12-02 21:00;22:00;2;1")]
        [InlineData("Példa4 Tibor;F;12-03 14:30;16:00;4;1", "Példa4 Tibor;L;12-03 14:30;16:00;4;1", "Példa5 Tibor;F;12-03 14:30;16:00;4;1")]
        [InlineData("Példa8 Tibor;F;12-04 11:00;13:00;3;1", "Példa8 Tibor;L;12-04 11:00;13:00;3;1", "Példa9 Tibor;F;12-04 11:00;13:00;3;1")]
        public void RevervationCancelSingleReservationTest(params string[] value)
        {
            InitTest(true, false, false);
            Globals.Reservations.Clear();
            foreach (var s in value)
            {
                var reservation = Reservation.FromString(s);
                reservation.tableType = 'B';
                reservation.reservedTables.Clear();

                switch (reservation.reservationType)
                {
                    case 'F':
                        ReservationManager.ProcessReservation(reservation);
                        break;
                    case 'L':
                        ReservationDataManager.RemoveReservation(reservation);
                        break;
                }
            }

            Assert.Equal(value, Globals.Reservations.Select(x => x.ToString()));
        }

        /// <summary>This test ensures that cancellation of multiple existing reservations are processed properly.</summary>
        /// <param name="value">A <c>string[]</c> containing information about a series of reservations.</param>
        [Theory]
        [InlineData("Példa1 Tibor;F;12-02 15:30;22:00;2;1", "Példa1 Tibor;L;12-02 15:30;22:00;2;1", "Példa2 Tibor;F;12-02 19:00;20:00;2;1", "Példa3 Tibor;F;12-02 21:00;22:00;2;1")]
        public void RevervationCancelMultipleReservationsTest(params string[] value)
        {
            InitTest(true, false, false);
            Globals.Reservations.Clear();
            foreach (var s in value)
            {
                var reservation = Reservation.FromString(s);
                reservation.tableType = 'B';
                reservation.reservedTables.Clear();

                switch (reservation.reservationType)
                {
                    case 'F':
                        ReservationManager.ProcessReservation(reservation);
                        break;
                    case 'L':
                        ReservationDataManager.RemoveReservation(reservation);
                        break;
                }
            }

            Assert.Equal(value, Globals.Reservations.Select(x => x.ToString()));
        }

        /// <summary>This test ensures that when a reservation is cancelled, waiting list items are processed and assigned the correct tables.</summary>
        /// <param name="value">A <c>string[]</c> containing information about a series of reservations.</param>
        [Theory]
        [InlineData("Példa1 Tibor;F;12-02 15:30;20:00;2;1", "Példa3 Tibor;F;12-02 21:00;22:00;2;-1", "Példa1 Tibor;L;12-02 15:30;20:00;2;1", "Példa3 Tibor;F;12-02 21:00;22:00;2;1")]
        public void ReservationCancelSingleReservationWaitingListTest(params string[] value)
        {
            InitTest(true, false, true);
            Globals.Reservations.Clear();
            foreach (var s in value)
            {
                var reservation = Reservation.FromString(s);
                if (!reservation.onWaitingList) reservation.reservedTables.Clear();

                switch (reservation.reservationType)
                {
                    case 'F':
                        ReservationManager.ProcessReservation(reservation);
                        break;
                    case 'L':
                        ReservationDataManager.RemoveReservation(reservation);
                        break;
                }
            }

            Assert.Equal(value, Globals.Reservations.Select(x => x.ToString()));
        }

        /// <summary>This test ensures that when a reservation is cancelled, multiple subsequent waiting list items are processed and assigned the correct tables.</summary>
        /// <param name="value">A <c>string[]</c> containing information about a series of reservations.</param>
        [Theory]
        [InlineData("Példa1 Tibor;F;12-02 15:30;20:00;2;1", "Példa3 Tibor;F;12-02 21:00;22:00;2;-1", "Példa4 Tibor;F;12-02 16:00;21:00;2;-1", "Példa1 Tibor;L;12-02 15:30;20:00;2;1", "Példa3 Tibor;F;12-02 21:00;22:00;2;1")]
        public void ReservationCancelMultipleReservationsWaitingListTest(params string[] value)
        {
            InitTest(true, false, true);
            Globals.Reservations.Clear();
            foreach (var s in value)
            {
                var reservation = Reservation.FromString(s);
                if (!reservation.onWaitingList) reservation.reservedTables.Clear();

                switch (reservation.reservationType)
                {
                    case 'F':
                        ReservationManager.ProcessReservation(reservation);
                        break;
                    case 'L':
                        ReservationDataManager.RemoveReservation(reservation);
                        break;
                }
            }

            Assert.Equal(value, Globals.Reservations.Select(x => x.ToString()));
        }

        /// <summary>This test ensures that statistics are generated correctly and contain the correct values.</summary>
        /// <param name="value">A <c>string[]</c> containing the start and end dates to be used for generating statistics.</param>
        [Theory]
        [InlineData("01-01 00:00", "12-12 23:59")]
        public void StatisticsTest(params string[] value)
        {
            Globals.Reservations.Clear();
            InitTest(true, true, true);
            var stats = new StatisticsGenerator(DateUtil.DateTimeFromString(value[0]), DateUtil.DateTimeFromString(value[1]));
            Assert.Equal(4, stats.IndoorsReservationsTotal);
            Assert.Equal(3, stats.OutdoorsReservationsTotal);

            Assert.Equal(4, stats.CompletedIndoorsReservations);
            Assert.Equal(0, stats.CompeltedOutdoorsReservations);

            Assert.Equal(2, stats.WaitingListCount);

            Assert.Equal(1, stats.LaterCompletedOutdoorsReservations);
            Assert.Equal(0, stats.LaterCompletedIndoorsReservations);

            Assert.Equal(1, stats.NotCompletedIndoorsReservations);
            Assert.Equal(1, stats.NotCompletedOutdoorsReservations);

            Assert.Equal(2, stats.NotCompletedReservations);
        }
    }
}