using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ATM
{
    class Account
    {
        String accountNum;
        String customerID;
        double balance;
        double dailyDepositAmount;
        double dailyTransactionTotal;
        double dailyTransactionLimit = 3000.0;
        string dailyTransactionDate;
        Transaction newTransaction;

        public Transaction getNewTransaction()
        {
            return newTransaction;
        }


        public int withdrawMoney(double amount, double machineCash, Boolean transfer, String toAcc, String fromAcc)
        {
            updateDailyTransaction();
            if (checkDailyTransaction() == false)
                return 1;
            if (verifyDailyTransaction(amount) == false)
                return 2;
            if (verifyAccountBalance(amount) == false)
                return 3;
            if (checkMachineCash(amount, machineCash) == false)
                return 4;
            updateWithdrawBalance(amount);
            updateDailyTransactionTotal(amount);
            updateAccountData();

            if (transfer)
            {
                newTransaction = new Transaction(accountNum, "Transfer", amount, fromAcc, toAcc);
            }
            else
            {
                newTransaction = new Transaction(accountNum, "Withdrawal", amount, fromAcc, toAcc);
            }
            newTransaction.saveTransaction();
            return 0;
        }

        public int depositMoney(double amount, double machineCash, Boolean transfer, String toAcc, String fromAcc)
        {
            updateDailyTransaction();
            if (checkDailyTransaction() == false)
                return 1;
            if (verifyDailyTransaction(amount) == false)
                return 2;
            
            updateDepositBalance(amount);
            updateDailyTransactionTotal(amount);
            updateDailyDepostAmt(amount);
            updateAccountData();

            
            if (transfer)
            { 
                newTransaction = new Transaction(accountNum, "Transfer", amount, fromAcc, toAcc); 
            }
            else
            {
                newTransaction = new Transaction(accountNum, "Deposit", amount, fromAcc, toAcc);
            }
            newTransaction.saveTransaction();
            return 0;
        }
        private void updateAccountData()
        {
            SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\KATE\DESKTOP\ATM PROJECT\ATMDB.MDF;Integrated Security=True;Connect Timeout=30");
            try
            {
                Con.Open();
                string sql = "UPDATE [Account] SET dailyTransDate='" + dailyTransactionDate + "',dailyTransTotal=" + dailyTransactionTotal + ",balance=" + balance + ",dailyDepositAmt="+ dailyDepositAmount+" WHERE accountNum='" + accountNum + "';";
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Con.Close();

        }
        private void updateDailyTransactionTotal(double amount)
        {
            dailyTransactionTotal = dailyTransactionTotal + amount;
        }

        private void updateWithdrawBalance(double amount)
        {
            balance = balance - amount;
        }

        private void updateDepositBalance(double amount)
        {
            balance = balance + amount;
        }

        private void updateDailyDepostAmt(double amount)
        {
            dailyDepositAmount = dailyDepositAmount + amount;
        }

        private bool checkMachineCash(double amount, double machineCash)
        {
            if (amount > machineCash)
                return false;
            else
                return true;
        }
        private bool verifyAccountBalance(double amount)
        {
            if (amount > balance)
                return false;
            else
                return true;
        }
        private bool verifyDailyTransaction(double amount)
        {
            if ((dailyTransactionTotal + amount) > 3000.0)
                return false;
            else
                return true;
        }
        public bool checkDailyTransaction()
        {
            if (dailyTransactionTotal >= 3000.0)
                return false;
            else
                return true;
        }
        private void updateDailyTransaction()
        {
            string todayDate = DateTime.Now.ToString("yyyy-MM-dd");
            if (!dailyTransactionDate.Equals(todayDate))
            {
                dailyTransactionDate = todayDate;
                dailyTransactionTotal = 0.0;
                dailyDepositAmount = 0.0;

            }
        }
        public String getAccountNum()
        {
            return accountNum;
        }

        public double getBalance()
        {
            return balance;
        }
        public static ArrayList retrieveAccounts(String id)
        {
            ArrayList accountList = new ArrayList();
            //ArrayList eventList = new ArrayList();  //a list to save the events
            //prepare an SQL query to retrieve all the events on the same, specified date
            DataTable myTable = new DataTable();
            SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\KATE\DESKTOP\ATM PROJECT\ATMDB.MDF;Integrated Security=True;Connect Timeout=30");
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Account where customerID='" + id + "' ORDER BY accountNum ASC", Con);
                sda.Fill(myTable);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Con.Close();

            foreach (DataRow row in myTable.Rows)
            {
                Account newAccount = new Account();
                newAccount.accountNum = row["accountNum"].ToString();
                newAccount.customerID = row["customerID"].ToString();
                newAccount.balance = Double.Parse(row["balance"].ToString());
                newAccount.dailyTransactionTotal = Double.Parse(row["dailyTransTotal"].ToString());
                newAccount.dailyTransactionDate = row["dailyTransDate"].ToString();
                newAccount.dailyDepositAmount = Double.Parse(row["dailyDepositAmt"].ToString());
                accountList.Add(newAccount);
            }
            return accountList;
        }

        public static ArrayList retrieveAccountNums(String id)
        {
            ArrayList accountNumList = new ArrayList();

            DataTable myTable = new DataTable();
            SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\KATE\DESKTOP\ATM PROJECT\ATMDB.MDF;Integrated Security=True;Connect Timeout=30");
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Account where customerID='" + id + "' ORDER BY accountNum ASC", Con);
                sda.Fill(myTable);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Con.Close();

            foreach (DataRow row in myTable.Rows)
            {
                Account newAccount = new Account();
                newAccount.accountNum = row["accountNum"].ToString();
                newAccount.customerID = row["customerID"].ToString();
                newAccount.balance = Double.Parse(row["balance"].ToString());
                newAccount.dailyTransactionTotal = Double.Parse(row["dailyTransTotal"].ToString());
                newAccount.dailyTransactionDate = row["dailyTransDate"].ToString();
                newAccount.dailyDepositAmount = Double.Parse(row["dailyDepositAmt"].ToString());

                accountNumList.Add(newAccount.accountNum);
            }
            return accountNumList;
        }
    }
}

