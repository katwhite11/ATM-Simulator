using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using MySqlX.XDevAPI.Common;

namespace ATM
{
    class Transaction
    {
        int transactionNum;
        String accountNum;
        String transactionType;
        double amount;
        String fromAccount;
        String toAccount;
        String date;

        public Transaction(String accNum, String transTy, double amountMoney, String fromAcc, String toAcc)
        {
            accountNum = accNum;
            transactionType = transTy;
            amount = amountMoney;
            fromAccount = fromAcc;
            toAccount = toAcc;
            transactionNum = -1;
        }

        public int getTransNum()
        {
            return transactionNum;
        }

        public double getAmount()
        {
            return amount;
        }
        public void saveTransaction()
        {
            SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\KATE\DESKTOP\ATM PROJECT\ATMDB.MDF;Integrated Security=True;Connect Timeout=30");

            try
            {
                Con.Open();
                string sql = "SELECT MAX(transNum) FROM [Transaction];";
                SqlCommand cmd = new SqlCommand(sql, Con);
                Object obj = cmd.ExecuteScalar();

                if (obj != DBNull.Value)
                {
                    int result = Convert.ToInt32(cmd.ExecuteScalar());
                    transactionNum = result + 1;
                }
                else
                {
                    transactionNum = 10001;
                }
        
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Con.Close();
            
            SqlConnection Con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\KATE\DESKTOP\ATM PROJECT\ATMDB.MDF;Integrated Security=True;Connect Timeout=30");
            try
            {
                Con2.Open();
                date = DateTime.Now.ToString("yyyy-MM-dd");
                string sql = "INSERT INTO [Transaction] (transNum, accountNum, transType, amount, fromAccount, toAccount, dateTime)" +
                " VALUES ("+transactionNum+",'"+accountNum+"','"+transactionType+"',"+amount+",'"+fromAccount+"','"+toAccount+"','"+date+"');";
                SqlCommand cmd = new SqlCommand(sql, Con2);
                cmd.ExecuteNonQuery();
             }

             catch (Exception ex)
             {
                Console.WriteLine(ex.ToString());
             }
             Con2.Close();
        }
    }
}
