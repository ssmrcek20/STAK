using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ChargersManager
{
    public partial class StationReservation : Form
    {
        public StationReservation()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView2.Items.Clear();
            listView3.Items.Clear();

            var csvManager = new CSVManager();
            var stations = csvManager.getStations();
            List<Stations> freeStations = new List<Stations>();
            List<Stations> notFreeStations = new List<Stations>();
            foreach (var station in stations)
            {
                if (station.State == "Raspoloživo")
                {
                    freeStations.Add(station);
                }
                else
                {
                    notFreeStations.Add(station);
                }
            }

            foreach (var station in notFreeStations)
            {
                listView1.Items.Add(station.Name);
            }

            List<Stations> reservedStations = new List<Stations>();
            List<Stations> freeStationsForReal = new List<Stations>();
            var reservations = csvManager.getReservations();
            var dateTimeStart = dateTimePicker1.Value;
            var dateTimeEnd = dateTimePicker1.Value + new TimeSpan(0, (int)numericUpDown1.Value, 0);
            foreach (var reservation in reservations)
            {
                if (dateTimeStart > DateTime.Parse(reservation.DateTimeEnd) || dateTimeEnd < DateTime.Parse(reservation.DateTimeStart))
                {

                }
                else
                {
                    var station = freeStations.Find(x => x.Id == reservation.StaionId);
                    if (station != null)
                    {
                        reservedStations.Add(station);
                        freeStations.Remove(station);
                    }
                }
            }

            foreach (var station in freeStations)
            {
                listView3.Items.Add(station.Name);
            }
            foreach (var station in reservedStations)
            {
                listView2.Items.Add(station.Name);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView3.SelectedItems.Count > 0)
            {
                var dateTimeStart = dateTimePicker1.Value;
                var dateTimeEnd = dateTimePicker1.Value + new TimeSpan(0, (int)numericUpDown1.Value, 0);
                var csvManager = new CSVManager();
                csvManager.AddReservation(listView3.SelectedItems[0].Text, dateTimeStart, dateTimeEnd);
                MessageBox.Show("Punionica rezervirana!");
                Close();
            }
            else
            {
                MessageBox.Show("Molim te odaberi slobodnu punionicu prije rezerviranja.");
            }
        }
    }
}
