using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Customer
    {
        String id;

        public Customer(String num)
        {
            id = num;
        }

        public String getID()
        {
            return id;
        }

        public string getFirstName()
        {
            DataTable myTable = new DataTable();
            SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\KATE\DESKTOP\ATM PROJECT\ATMDB.MDF;Integrated Security=True;Connect Timeout=30");
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT firstName from Customer where Id='" + id + "';", Con);
            sda.Fill(myTable);
            Con.Close();
            string firstName = myTable.Rows[0][0].ToString();
            return firstName;
            
        }

        public string getLastName()
        {
            DataTable myTable = new DataTable();
            SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\KATE\DESKTOP\ATM PROJECT\ATMDB.MDF;Integrated Security=True;Connect Timeout=30");
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT lastName from Customer where Id='" + id + "';", Con);
            sda.Fill(myTable);
            Con.Close();
            string lastName = myTable.Rows[0][0].ToString();
            return lastName;
        }
    }
}
