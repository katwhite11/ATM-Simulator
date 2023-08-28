using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class MainMenu : Form
    {
        Customer currentCustomer = new Customer(Login.cusIDNum);
        ArrayList accountList = new ArrayList();
        Account selectedAccount;
        double machineCash = 100000;
        int withdrawCode = -1;

        public MainMenu()
        {
            InitializeComponent();
            accountList = Account.retrieveAccounts(currentCustomer.getID());
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void withdrawbtn_Click(object sender, EventArgs e)
        {
            Withdraw wd = new Withdraw();
            wd.Show();
            this.Hide();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void checkbalancebtn_Click(object sender, EventArgs e)
        {
            Balance bal = new Balance();
            bal.Show();
            this.Hide();
        }

        private void depositbtn_Click(object sender, EventArgs e)
        {
            Deposit dep = new Deposit();
            dep.Show();
            this.Hide();
        }

        private void transferbtn_Click(object sender, EventArgs e)
        {
            Transfer tf = new Transfer();
            tf.Show();
            this.Hide();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            firstLast.Text = currentCustomer.getFirstName()+" "+currentCustomer.getLastName();

        }
    }
}
