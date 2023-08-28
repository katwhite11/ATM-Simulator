using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ATM
{
    public partial class Balance : Form
    {
        Customer currentCustomer = new Customer(Login.cusIDNum);
        ArrayList accountList = new ArrayList();
        ArrayList accountNumList = new ArrayList();

        public Balance()
        {
            InitializeComponent();
            accountList = Account.retrieveAccounts(currentCustomer.getID());
            accountNumList = Account.retrieveAccountNums(currentCustomer.getID());
        }

        public static String cusIDNum;
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\KATE\DESKTOP\ATM PROJECT\ATMDB.MDF;Integrated Security=True;Connect Timeout=30");


        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void menubtn_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.Show();
            this.Hide();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Balance1_Load(object sender, EventArgs e)
        {
            dropDown.DataSource = accountNumList;
            dropDown.SelectedIndex = -1;
            firstLast.Text = currentCustomer.getFirstName() + " " + currentCustomer.getLastName();

        }

        private void dropDown_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
            if (dropDown.SelectedIndex != -1)
            {
                String num = dropDown.SelectedItem.ToString();
                foreach (Account item  in accountList)
                {
                    String temp = item.getAccountNum();
                    if (num.Equals(temp))
                    {
                        double bal = item.getBalance();
                        accBalance.Text = bal.ToString();
                    }
                }
            }
            else
            {
                accBalance.Text = "";
            }
        }
    }
}
