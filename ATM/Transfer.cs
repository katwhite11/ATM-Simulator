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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace ATM
{
    public partial class Transfer : Form
    {
        Customer currentCustomer = new Customer(Login.cusIDNum);
        ArrayList accountList = new ArrayList();
        ArrayList accountNumList1 = new ArrayList();
        ArrayList accountNumList2 = new ArrayList();
        Account fromAccount;
        Account toAccount;
        String accNumTemp;
        double machineCash = 100000;
        int withdrawCode = -1;
        int depositCode = -1;

        public Transfer()
        {
            InitializeComponent();
            accountList = Account.retrieveAccounts(currentCustomer.getID());
            accountNumList1 = Account.retrieveAccountNums(currentCustomer.getID());
            accountNumList2 = Account.retrieveAccountNums(currentCustomer.getID());
        }

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

        private void Transfer_Load(object sender, EventArgs e)
        {
            fromdropDown.DataSource = accountNumList1;
            fromdropDown.SelectedIndex = -1;
            todropDown.DataSource = accountNumList2;
            todropDown.SelectedIndex = -1;
            firstLast.Text = currentCustomer.getFirstName() + " " + currentCustomer.getLastName();

        }

        private void fromdropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fromdropDown.SelectedIndex != -1)
            {
                accNumTemp = fromdropDown.SelectedItem.ToString();
                fromAccount = (Account)accountList[fromdropDown.SelectedIndex];
            }
            else
            {
                accNumTemp = "";
            }
        }

        private void todropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (todropDown.SelectedIndex != -1)
            {
                accNumTemp = todropDown.SelectedItem.ToString();
                toAccount = (Account)accountList[todropDown.SelectedIndex];
            }
            else
            {
                accNumTemp = "";
            }
        }

        private void gobtn_Click(object sender, EventArgs e)
        {
            Boolean transfer = true;
            double amount1 = Double.Parse(amtBox.Text);
            withdrawCode = fromAccount.withdrawMoney(amount1, machineCash,transfer, fromAccount.getAccountNum(), toAccount.getAccountNum());

            double amount2 = Double.Parse(amtBox.Text);
            depositCode = toAccount.depositMoney(amount2, machineCash, transfer, fromAccount.getAccountNum(), toAccount.getAccountNum());

            if (fromdropDown.SelectedIndex == todropDown.SelectedIndex)
            {
                MessageBox.Show("Please select two different accounts.");
            }
            else
            {
                if (withdrawCode == 1)
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
                else if (withdrawCode == 0)
                {
                    if (depositCode == 0)
                    {
                        MessageBox.Show("Thank you.\nTransaction number: "
                            + toAccount.getNewTransaction().getTransNum() + "\n" + "Amount: $"
                            + toAccount.getNewTransaction().getAmount() + "\n" + "From account: "
                            + fromAccount.getAccountNum() + "\n" + "To account: "
                            + toAccount.getAccountNum());
                    }
                    else if (depositCode == 1)
                    {
                        MessageBox.Show("The transactions of this account have exceeded the max limit $3000 for today.\n"
                            + "Please select another account.");
                    }
                    else if (depositCode == 2)
                    {
                        MessageBox.Show("The amount will make the transactions of this account exceed the max limit $3000 for today.\n"
                            + "Please enter a smaller amount.");
                    }
                }

                MainMenu menu = new MainMenu();
                menu.Show();
                this.Hide();
            }
        }
    }
}
