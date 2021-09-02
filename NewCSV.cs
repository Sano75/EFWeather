using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFCore.BulkExtensions;

namespace EFWeather
{
    public partial class NewCSV : Form
    {
        WeatherDBContext db;
        OpenFileDialog openFile = new OpenFileDialog();
        DataTable dt = new DataTable();
        int antalRader = 0;
        static int antalTillSQL = 0;
        //string myConString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\WeatherEF.mdf;Integrated Security=True;Connect Timeout=30";
        string myConString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sano_\WeatherEF.mdf;Integrated Security=True;Connect Timeout=30";



        public NewCSV()
        {
            InitializeComponent();
        }

        private void btnHemNCSV_Click(object sender, EventArgs e)
        {
            Start start = new Start();
            this.Hide();
            start.Show();
        }

        private void btnStatNCSV_Click(object sender, EventArgs e)
        {
            Statistik st = new Statistik();
            this.Hide();
            st.Show();
        }

        private void Ncsv_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnGetFile_Click(object sender, EventArgs e)
        {
            openFile.ShowDialog();
            tbGetFile.Text = openFile.FileName;
            BindCSV(tbGetFile.Text);
        }

        private void BindCSV(string filePath)
        {
            dt = new DataTable();
            antalRader = 0;

            string[] lines = File.ReadAllLines(filePath);
            if (dt.Rows.Count != 0)
            {   //dt.Reset();  
            }
            else
            {
                dt.Reset();
                dt.Columns.Clear();
                dt.Rows.Clear();
                if (lines.Length > 0)
                {
                    //tableHeader creates from file
                    string firstLine = lines[0];
                    string[] headerLabels = firstLine.Split(',');
                    foreach (string hLabel in headerLabels)
                    {
                            dt.Columns.Add(new DataColumn(hLabel));
                    }                    

                    //tableContext gets from file
                    for (int r = 1; r < lines.Length; r++)
                    {
                        string[] dataL = lines[r].Split(',');
                        DataRow dr = dt.NewRow();
                        int columnIndex = 0;
                        try
                        {
                            foreach (string hLabel in headerLabels)
                            {
                                dr[hLabel] = dataL[columnIndex++];
                            }
                            dt.Rows.Add(dr);
                            antalRader++;
                        }
                        catch (Exception) { dt.Rows.Add("Importerad fil kan inte läsas"); }
                    }
                    lblAntalRader.Text = " " + antalRader + " ";
                }

                if (dt.Rows.Count > 0)
                {
                    gvNewCSV.DataSource = dt.DefaultView;
                }
            }
        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            ToSql(tbGetFile.Text);
        }
        private void btnAddNewRecords_Click(object sender, EventArgs e)
        {
            AddToSql(tbGetFile.Text);
        }
        public  void ToSql(String file)
        {

            SqlCommand cmd = new SqlCommand();
            string deleteCmd = "delete from WeatherItems";
            //preparing for the bulk insert
            string cmd2 = @"' with (rowterminator = '\n', fieldterminator = ',') ";
            //using the view VWeather to insert data from the csv file
            string cmdView = @"bulk insert VWeather from '";
            string ViewCMD = cmdView+ file+ cmd2;
            string raderiDB = "select count(*) from WeatherItems where datum is not null";
        
            try
            {
                using (SqlConnection con = new SqlConnection(myConString))
                {
                    SqlCommand CmdDelete = new SqlCommand(deleteCmd, con);
                    SqlCommand raderDB = new SqlCommand(raderiDB, con);
                    cmd = new SqlCommand(ViewCMD, con);

                    con.Open();
                    CmdDelete.ExecuteNonQuery();                    
                    cmd.ExecuteNonQuery();
                    antalTillSQL = (Int32)raderDB.ExecuteScalar();
                    con.Close();                    
                }
                lblRaderDB.Text = (antalTillSQL-1).ToString();
                MessageBox.Show(antalRader + "\nNy data sparad\n"+"Totalt i DB "+(antalTillSQL-1));
            }
            catch (Exception e)
            {
                MessageBox.Show("Kunde inte spara" +
                    " till SQL-DB\n\n" + e);
            }
        }
        public void AddToSql(String file)
        {
            SqlCommand cmd = new SqlCommand();
            string cmd2 = @"' with (rowterminator = '\n', fieldterminator = ',') ";
            string cmdView = @"bulk insert VWeather from '";
            string ViewCMD = cmdView + file + cmd2;
            string raderiDB = "select count(*) from WeatherItems where datum is not null";

            try
            {
                using (SqlConnection con = new SqlConnection(myConString))
                {
                    cmd = new SqlCommand(ViewCMD, con);
                    SqlCommand raderDB = new SqlCommand(raderiDB, con);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    antalTillSQL = (Int32)raderDB.ExecuteScalar();
                    con.Close();
                }
                lblRaderDB.Text = (antalTillSQL-1).ToString();
                MessageBox.Show(antalRader + "\nNy data sparad\n" +"Totalt i DB "+ (antalTillSQL - 1));
            }
            catch (Exception e)
            {
                MessageBox.Show("Kunde inte spara" +
                    " till SQL-DB\n\n" + e);
            }
        }

    }
}
