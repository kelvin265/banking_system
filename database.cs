using Finisar.SQLite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banking_system
{
    class database
    {
        private SQLiteConnection con = new SQLiteConnection("Data Source = banking_system.db; Version=3; Compress=True;");

        public database()
        {

            //con.Open();
            //string query = "Create Table payee(id int primary key,userId int, firstname varchar(50),lastname varchar(50), accountNumber varchar(50), foreign key (userId) references user (id) on delete cascade on update cascade)";

            //SQLiteCommand cmd = new SQLiteCommand(query, con);
            //cmd.ExecuteNonQuery();
            //con.Close();

        }
        public SQLiteConnection Con
        {
            get
            {
                return con;
            }
        }
        // opening connection to database
        public void openConnection()
        {
            con.Open();
        }
        // closing connection to database
        public void closeConnection()
        {
            con.Close();
        }

        public bool insert(string query)
        {
            openConnection();
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            if (cmd.ExecuteNonQuery() == 1)
            {
                closeConnection();
                return true;
            }
            else
            {
                closeConnection();
                return false;
            }
            
        }

        public DataSet select(string query)
        {
            openConnection();
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            closeConnection();
            DataSet ds = new DataSet();
            da.Fill(ds);
            
            return ds;
            

        }

        public bool delete(string query)
        {
            openConnection();
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            if (cmd.ExecuteNonQuery() == 1)
            {
                closeConnection();
                return true;
            }
            else
            {
                closeConnection();
                return false;
            }

        }
        public bool update(string query)
        {
            openConnection();
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            if (cmd.ExecuteNonQuery() == 1)
            {
                closeConnection();
                return true;
            }
            else
            {
                closeConnection();
                return false;
            }

        }
        public int codeGenerator(string tableName)
        {
            int code = 0;
            try
            {
                int x = 0;
                int y = 0;

                string Query = "SELECT count(*) FROM " + tableName + "";
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand(Query, con);
                x = int.Parse(cmd.ExecuteScalar() + "");

                Query = "SELECT ID FROM " + tableName + " ORDER BY ID ASC";
                SQLiteDataAdapter sda = new SQLiteDataAdapter(Query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count.Equals(0) && x.Equals(0))
                    code = 1;
                else if (dt.Rows.Count > 0 && x > 0)
                    foreach (DataRow i in dt.Rows)
                        y = int.Parse(i["ID"].ToString());

                if (x > y)
                {
                    x = x + 1;
                    code = x;
                }
                else if (y > x)
                {
                    y = y + 1;
                    code = y;
                }
                else if (x == y)
                    code = y + 1;
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }

            return code;
        }
    }
}
