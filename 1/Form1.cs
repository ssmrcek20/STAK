using System.Data;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.LinkLabel;

namespace ChargersManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadStationData();
        }

        private void LoadStationData()
        {
            var csvManager = new CSVManager();
            var stations = csvManager.getStations();
            foreach (var station in stations)
            {
                listView1.Items.Add(station.Name);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var csvManager = new CSVManager();
                string selected = listView1.SelectedItems[0].Text;
                var selectedStation = csvManager.getStation(selected);
                if (selectedStation == null)
                {
                    MessageBox.Show("Nije moguće pronaći odabranu punionicu.");
                    return;
                }

                richTextBox1.Text = $"Naziv: {selectedStation.Name}\n" +
                    $"Adresa: {selectedStation.Address}\n" +
                    $"Broj mjesta: {selectedStation.Spots}\n" +
                    $"Status mjesta: {selectedStation.State}\n" +
                    $"Plaćanje: {selectedStation.Paying}";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var addStationForm = new AddStation())
            {
                addStationForm.ShowDialog();

                listView1.Items.Clear();
                LoadStationData();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var csvManager = new CSVManager();
                csvManager.DeleteStation(listView1.SelectedItems[0].Text);
                listView1.Items.Clear();
                LoadStationData();
            }
            else
            {
                MessageBox.Show("Molim te odaberi punionicu prije brisanja.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var stationReservationForm = new StationReservation())
            {
                stationReservationForm.ShowDialog();
            }
        }
    }
}