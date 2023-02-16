using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;


namespace banking_system.Classes
{
    internal class account
    {
        database db = new database();
        public int Id { get; set; }
        public int UserId { get; set; }
        public string AccountType { get; set; }
        public float Interest { get; set; }
        public float Balance { get; set; }

        public string Status { get; set; }

        public float Threshold { get; set; }


        public account(int id = 0, int userId = 0, string accountType = "", float interest = 0, float balance = 0, string status = "", float threshold = 0)
        {
            Id = id;
            UserId = userId;
            AccountType = accountType;
            Interest = interest;
            Balance = balance;
            Status = status;
            Threshold = threshold;
        }

        public bool createAccount()
        {
            bool value = false;
            string query = "insert into account Values(" + Id + ",'" + UserId + "','" + AccountType + "', '" + Interest + "',   '" + Balance + "', '" + Status + "', '" + Threshold + "')";
            if (db.insert(query))
            {
                value = true;
            }
            return value;

        }

        public bool changeAccountStatus()
        {
            bool value = false;
            string query = "update account set status='" + Status + "' where id=" + Id + "";
            if (db.update(query))
            {
                value = true;
            }
            return value;

        }

        public bool updateBalance()
        {
            bool value = false;
            string query = "update account set balance='" + Balance + "' where id=" + Id + "";
            if (db.update(query))
            {
                value = true;
            }
            return value;

        }

        public float selectBalance()
        {
            string query = "select * from account  where id=" + Id + "";
            DataSet ds = db.select(query);
            float balance = 0;
            if(ds.Tables[0].Rows.Count > 0)
            {
                balance = float.Parse(ds.Tables[0].Rows[0][4].ToString());
            }
            return balance;
            
        }


    }
}
