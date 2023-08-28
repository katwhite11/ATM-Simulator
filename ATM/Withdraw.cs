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

namespace ATM
{
    public partial class Withdraw : Form
    {
        Customer currentCustomer = new Customer(Login.cusIDNum);
        ArrayList accountList = new ArrayList();
        ArrayList accountNumList = new ArrayList();
        Account selectedAccount;
        String accNumTemp;
        double machineCash = 100000;
        int withdrawCode = -1;

        public Withdraw()
        {
            InitializeComponent();
            accountList = Account.retrieveAccounts(currentCustomer.getID());
            accountNumList = Account.retrieveAccountNums(currentCustomer.getID());
        }

        public static String cusIDNum;
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\KATE\DESKTOP\ATM PROJECT\ATMDB.MDF;Integrated Security=True;Connect Timeout=30");


        private void menubtn_Click(object sender, EventArgs e)
        {
                MainMenu menu = new MainMenu();
                menu.Show();
                this.Hide();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
                Login login = new Login();
                login.Show();
                this.Hide();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
                System.Windows.Forms.Application.Exit();
        }

        private void Withdraw_Load(object sender, EventArgs e)
        {
            dropDown.DataSource = accountNumList;
            dropDown.SelectedIndex = -1;
            firstLast.Text = currentCustomer.getFirstName() + " " + currentCustomer.getLastName();

        }

        private void dropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dropDown.SelectedIndex != -1)
            {
                accNumTemp = dropDown.SelectedItem.ToString();
                selectedAccount = (Account)accountList[dropDown.SelectedIndex];
            }
            else
            {
                accNumTemp = "";
            }
        }

        private void gobtn_Click(object sender, EventArgs e)
        {
            double amount = Double.Parse(amtBox.Text);
            Boolean transfer = false;
            String defTrans = "-1";
            withdrawCode = selectedAccount.withdrawMoney(amount, machineCash, transfer, defTrans, defTrans);


            if (withdrawCode == 0)
            {
                MessageBox.Show("Please take the money.\nTransaction number: "
                    + selectedAccount.getNewTransaction().getTransNum() + "\n" + "Withdrawal amount: $"
                    + selectedAccount.getNewTransaction().getAmount() + "\n" + "From account: "
                    + selectedAccount.getAccountNum());
            }
            else if (withdrawCode == 1)
            {
                MessageBox.Show("The transactions of this account have exceeded the max limit $3000 for today.\n"
                    + "Please select another account.");
            }
            else if (withdrawCode == 2)
            {
                MessageBox.Show("The amount will make the transactions of this account exceed the max limit $3000 for today.\n"
                    + "Please enter a smaller amount.");
            }
            else if (withdrawCode == 3)
            {
                MessageBox.Show("The amount you entered is greater than the balance of the selected account.\n"
                    + "Please enter a smaller amount.");
            }
            else if (withdrawCode == 4)
            {
                MessageBox.Show("The machince doesn't have enough cash for your withdrawal.\n"
                    + "Please enter a smaller amount.");
            }
            MainMenu menu = new MainMenu();
            menu.Show();
            this.Hide();
        }
    }
}
