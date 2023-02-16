using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking_system.Classes
{
    internal class payee
    {
        database db = new database();
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string AccountNumber { get; set; }


        public payee(int id = 0, int userId = 0, string firstname = "", string lastname = "", string accountNumber = "")
        {
            Id = id;
            UserId = userId;
            Firstname = firstname;
            Lastname = lastname;
            AccountNumber = accountNumber;
        }

        public bool addPayee()
        {
            bool value = false;
            string query = "insert into payee Values(" + Id + ",'" + UserId + "','" + Firstname + "', '" + Lastname + "', '" + AccountNumber + "')";
            if (db.insert(query))
            {
                value = true;
            }
            return value;

        }

        public bool updatePayee()
        {
            bool value = false;
            string query = "update payee set userId='" + UserId + "', firstname='"+Firstname+"', lastname='"+Lastname+ "' , accountNumber='" + AccountNumber + "' where id=" + Id + "";
            if (db.update(query))
            {
                value = true;
            }
            return value;

        }

        public bool deletePayee()
        {
            bool value = false;
            string query = "delete from payee where id=" + Id + "";
            if (db.delete(query))
            {
                value = true;
            }
            return value;

        }

        

    }
}
