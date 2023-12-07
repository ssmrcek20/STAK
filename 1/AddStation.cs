using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChargersManager
{
    public partial class AddStation : Form
    {
        public AddStation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Niste unijeli sve podatke!");
                return;
            }
            var newStation = new Stations("", textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            var csvManager = new CSVManager();
            csvManager.AddStation(newStation);
            Close();
        }
    }
}
