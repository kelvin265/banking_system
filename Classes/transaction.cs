using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking_system.Classes
{
    internal class transaction
    {
        database db = new database();
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string TransactionType { get; set; }
        public int PayeeId { get; set; }
        public float Amount { get; set; }

        public string Date { get; set; }


        public transaction(int id = 0, int accountId = 0, string transactionType = "", int payeeId = 0, float amount = 0, string date = "")
        {
            Id = id;
            AccountId = accountId;
            TransactionType = transactionType;
            PayeeId = payeeId;
            Amount = amount;
            Date = date;
            
        }

        public bool newTransaction()
        {
            bool value = false;
            string query = "insert into transactions Values(" + Id + ",'" + AccountId + "','" + TransactionType + "', '" + PayeeId + "',   '" + Amount + "', '" + Date + "')";
            if (db.insert(query))
            {
                value = true;
            }
            return value;

        }

        public DataSet viewTransactions()
        {
            string query = "select * from transactions where accountId = " + AccountId + "";
            DataSet ds = db.select(query);
            return ds;

        }
    }
}
