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

namespace ATM
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static String cusIDNum;
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\KATE\DESKTOP\ATM PROJECT\ATMDB.MDF;Integrated Security=True;Connect Timeout=30");

        private void loginbtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Customer where Id='" + cusIDBox.Text + "' and pin='" + pinBox.Text + "';", Con);
            DataTable dt1 = new DataTable();
            sda.Fill(dt1);
            if (dt1.Rows[0][0].ToString() == "1")
            {
                cusIDNum = cusIDBox.Text;
                MainMenu menu = new MainMenu();
                menu.Show();
                this.Hide();
                Con.Close();
            }
            else
            {
                MessageBox.Show("Wrong customer ID number or PIN");
            }

            Con.Close();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
