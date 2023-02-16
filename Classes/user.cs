using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking_system.Classes
{
    internal class user
    {
        database db = new database();
        public int Id { get; set; }
        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }

        public string DOB { get; set; }
        public string Type { get; set; }
        public string Password { get; set; }

        public user(int id = 0, string username = "", string firstname = "", string lastname = "", string phone = "", string gender = "", string dob = "", string type = "", string password = "")
        {
            Id = id;
            Username = username;
            Firstname = firstname;
            Lastname = lastname;
            Phone = phone;
            DOB = dob;
            Gender = gender;
            Type = type;
            Password = password;
        }

        public bool addUser()
        {
            bool value = false;
            string query = "insert into user Values(" + Id + ",'" + Username + "','" + Firstname + "', '" + Lastname + "',   '" + Phone + "', '" + Gender + "', '" + DOB + "', '" + Type + "', '" + Password + "')";
            if (db.insert(query))
            {
                value = true;
            }
            return value;

        }

        public bool updateUser()
        {
            bool value = false;
            string query = "update user set username='" + Username + "', firstname='" + Firstname + "', lastname='" + Lastname + "',phone='" + Phone + "', gender='" + Gender + "', dob='" + DOB + "',type='" + Type + "',password='" + Password + "' where id=" + Id + "";
            if (db.update(query))
            {
                value = true;
            }
            return value;

        }

        public bool deleteUser()
        {
            bool value = false;
            string query = "delete from user where id=" + Id + "";
            if (db.update(query))
            {
                value = true;
            }
            return value;

        }

         public string login()
        {
            string value;
            string query = "select * from user where username='" + Username + "' AND password='" + Password + "'";
            DataSet ds = new DataSet();
            ds = db.select(query);

            if (ds.Tables[0].Rows.Count > 0)
            {
                string type = ds.Tables[0].Rows[0]["type"].ToString();
                if (type == "admin")
                {
                    value = "admin";
                }
                else
                {
                    value = ds.Tables[0].Rows[0]["id"].ToString();
                }
            }
            else
            {
                value = "failed";
            }
            return value;
        }
    }
}
