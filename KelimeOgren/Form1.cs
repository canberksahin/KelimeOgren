using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace KelimeOgren
{
    public partial class Form1 : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\canbe\OneDrive\Masaüstü\dbSozluk.accdb");

        Random rand = new Random();
        int sure = 90;
        int kelime = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Getir();
            timer1.Start();
        }

        private void Getir()
        {
            int rast = rand.Next(1, 2490);
            con.Open();

            OleDbCommand cmd = new OleDbCommand("select * from sozluk where id=@p1", con);
            cmd.Parameters.AddWithValue("@p1", rast);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtIngilizce.Text = dr[1].ToString();
                lblCevap.Text = dr[2].ToString();
                lblCevap.Text = lblCevap.Text.ToLower();
            }
            con.Close();
        }

        private void txtTurkce_TextChanged(object sender, EventArgs e)
        {
            if (txtTurkce.Text == lblCevap.Text)
            {
                kelime++;
                lblKelime.Text = kelime.ToString();
                Getir();
                txtTurkce.Clear();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            lblSure.Text = sure.ToString();
            if (sure == 0)
            {
                txtIngilizce.Enabled = false;
                txtTurkce.Enabled = false;
                timer1.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Getir();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            if (button2.Text == "GİZLE")
            {
                lblCevap.Visible = false;
                button2.Text = "GÖSTER";
            }
            else
            {
                lblCevap.Visible = true;
                button2.Text = "GİZLE";

            }
        }
    }
}
