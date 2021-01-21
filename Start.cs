using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFWeather
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void btnNewCSV_Click(object sender, EventArgs e)
        {
            NewCSV ncv = new NewCSV();
            this.Hide();
            ncv.Show();
        }

        private void btnStatistik_Click(object sender, EventArgs e)
        {
            Statistik st = new Statistik();
            this.Hide();
            st.Show();
        }

        private void Start_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
