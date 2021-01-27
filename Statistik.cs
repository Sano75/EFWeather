using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFWeather
{
    public partial class Statistik : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DataTable dt;
        SqlDataAdapter sda;
        string myConString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sano_\WeatherEF.mdf;Integrated Security=True;Connect Timeout=30";

        WeatherDBContext db;

        public Statistik()
        {
            InitializeComponent();
        }
        private void Statistik_Load(object sender, EventArgs e)
        {
            FillGridView();
        }

        private void btnHemStat_Click(object sender, EventArgs e)
        {
            Start start = new Start();
            this.Hide();
            start.Show();
        }

        private void btnNCSVStat_Click(object sender, EventArgs e)
        {
            NewCSV ncsv = new NewCSV();
            this.Hide();
            ncsv.Show();

        }

        private void St_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FillGridView()
        {
            dt = new DataTable();
            SqlCommand cmd2 = new SqlCommand();            
            DataTable dt2 = new DataTable();
            string comdInne = "select * from WeatherItems where utrymme = 'inne';";
            String comdUte = "select * from WeatherItems where utrymme = 'ute';";
            string antalRaderDB = "select count(*)-1 from WeatherItems";
            string antalInne = "select count(*)-1 from WeatherItems where utrymme = 'inne'";
            string antalUte = "select count(*)-1 from WeatherItems where utrymme = 'ute'";
            string medelH = "select top 1 Datum, Temp from WeatherItems where utrymme = 'ute' and Temp <= 10 ";
            string medelV = "select top 1 Datum, Temp from WeatherItems where utrymme = 'ute' and Temp <= 0  ";
            string lblHost;
            string lblVint;

            try
            {
                using (con = new SqlConnection(myConString))
                {
                    SqlCommand mdHost = new SqlCommand(medelH, con);
                    SqlCommand mdVint = new SqlCommand(medelV, con);
                    SqlCommand antalRader = new SqlCommand(antalRaderDB, con);
                    SqlCommand antalRInne = new SqlCommand(antalInne, con);
                    SqlCommand antalRUte = new SqlCommand(antalUte, con);


                    con.Open();
                    cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = comdInne;
                    sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    gvInne.DataSource = dt;


                    cmd2 = con.CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = comdUte;
                    SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
                    sda2.Fill(dt2);
                    GvUte.DataSource = dt2;
                    lblHost = mdHost.ExecuteScalar().ToString();
                    lblVint = mdVint.ExecuteScalar().ToString();
                    lblUteAntalRaderDB.Text = antalRader.ExecuteScalar().ToString()+" rader";
                    lblRaderDBInne.Text = antalRader.ExecuteScalar().ToString()+" rader";
                    lblMatningInne.Text = antalRInne.ExecuteScalar().ToString() + " rader";
                    lblMatningUte.Text = antalRUte.ExecuteScalar().ToString() + " rader";
                    con.Close();
                }
                lblMetHost.Text = lblHost.ToString();
                lblMetVinter.Text = lblVint.ToString();

            }
            catch (Exception e)
            {
                MessageBox.Show("Sql-Tabell kan inte visas\n\n" + e);
            }
        }

        private void btnInneTemp_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            SqlCommand cmd2 = new SqlCommand();
            DataTable dt2 = new DataTable();
            string comdInne = "select Datum, " +
                "avg(Temp) as Temp," +
                " avg(Fuktighet) as Fuktighet " +
                "from WeatherItems " +
                " where Utrymme = 'inne'" +
               " group by Datum;";


            try
            {
                using (con = new SqlConnection(myConString))
                {
                    con.Open();
                    cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = comdInne;
                    sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    gvInne.DataSource = dt;


                    con.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sql-Tabell kan inte visas\n\n" + ex);
            }
        }

        private void btnUteMedelTemp_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            SqlCommand cmd2 = new SqlCommand();
            DataTable dt2 = new DataTable();
            string comdInne = "select Datum, " +
                "avg(Temp) as Temp," +
                " avg(Fuktighet) as Fuktighet " +
                "from WeatherItems " +
                " where Utrymme = 'ute'" +
               " group by Datum;";

            try
            {
                using (con = new SqlConnection(myConString))
                {
                    con.Open();
                    cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = comdInne;
                    sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    GvUte.DataSource = dt;


                    con.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sql-Tabell kan inte visas\n\n" + ex);
            }
        }

        private void btnInneSearch_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            SqlCommand cmd2 = new SqlCommand();
            DataTable dt2 = new DataTable();
            string comdInne;
            DateTime sokDatum ;

            sokDatum = dtimePickerInne.Value.Date;
                    comdInne = "select Datum, " +
                   "avg(Temp) as Temp," +
                   " avg(Fuktighet) as Fuktighet " +
                   "from WeatherItems " +
                   " where Utrymme = 'inne' and datum = '" + sokDatum + "'" +
                  " group by Datum;";
               
            try
            {
                using (con = new SqlConnection(myConString))
                {
                    con.Open();
                    cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = comdInne;
                    sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    gvInne.DataSource = dt;

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sql-Tabell kan inte visas\n\n" + ex);
            }
        }

        private void btnUteSearch_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            SqlCommand cmd2 = new SqlCommand();
            DataTable dt2 = new DataTable();
            string comdUte;
            DateTime sokDatum;

            sokDatum = dTimePickerUte.Value.Date;
            comdUte = "select Datum, " +
           "avg(Temp) as Temp," +
           " avg(Fuktighet) as Fuktighet " +
           "from WeatherItems " +
           " where Utrymme = 'ute' and datum = '" + sokDatum + "'" +
          " group by Datum;";

            try
            {
                using (con = new SqlConnection(myConString))
                {
                    con.Open();
                    cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = comdUte;
                    sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    GvUte.DataSource = dt;

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sql-Tabell kan inte visas\n\n" + ex);
            }
        }

        private void btnInneMogelRisk_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            SqlCommand cmd2 = new SqlCommand();
            DataTable dt2 = new DataTable();
           
            try
            {
                using (con = new SqlConnection(myConString))
                {
                    con.Open();
                    cmd = new SqlCommand("SP_Egen_Inne_mogel", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    gvInne.DataSource = dt;

                    con.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sql-Tabell kan inte visas\n\n" + ex);
            }
        }

        private void btnUteMogelRisk_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            SqlCommand cmd2 = new SqlCommand();
            DataTable dt2 = new DataTable();
            
            try
            {
                using (con = new SqlConnection(myConString))
                {
                    con.Open();
                    cmd = new SqlCommand("SP_Egen_Ute_mogel", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    GvUte.DataSource = dt;

                    con.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sql-Tabell kan inte visas\n\n" + ex);
            }

        }

        private void btnUteFukt_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            SqlCommand cmd2 = new SqlCommand();
            DataTable dt2 = new DataTable();
            try
            {
                using (con = new SqlConnection(myConString))
                {
                    con.Open();
                    cmd = new SqlCommand("SP_Egen_Ute_Fukt", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    GvUte.DataSource = dt;


                    con.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sql-Tabell kan inte visas\n\n" + ex);
            }
        }

        private void btnInneFukt_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            SqlCommand cmd2 = new SqlCommand();
            DataTable dt2 = new DataTable();

            try
            {
                using (con = new SqlConnection(myConString))
                {
                    con.Open();
                    cmd = new SqlCommand("SP_Egen_Inne_Fukt", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    gvInne.DataSource = dt;


                    con.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sql-Tabell kan inte visas\n\n" + ex);
            }
        }
    }
}