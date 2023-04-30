using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DataLayerClass
{
    public class DLL
    {
        public DLL() { }
        //opening and connecting to my database
        public static string conn = "server=localhost;uid=root;password='';database=ujstaff";
        //using a sql class to connect to our database
        private readonly MySqlConnection connection = new MySqlConnection(conn);
        //sql class to perform command or query of sql
        MySqlCommand cmd = new MySqlCommand();

        //A void function that check the state of the database(if it is open or close)
        public void checkOpenCloseDB()
        {
            if(connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            else
            {
                connection.Close();
            }
        }
        //A void function that will write or insert into the table our data 
        public void WriteToDB(string id, string name, string surname, string email, string age)
        {
            string sqlSyntax = $"insert into staffmembers(id,name,surname,email,age) values('{id}','{name}','{surname}','{email}','{age}')";
            checkOpenCloseDB();

            cmd = new MySqlCommand(sqlSyntax, connection);
            cmd.ExecuteNonQuery();

            checkOpenCloseDB();
        }
        //A function that read all from the selected table(in this case it's members)
        public DataTable GetTable()
        {
            string sqlSyntax2 = "select * from staffmembers";
            checkOpenCloseDB();
            cmd = new MySqlCommand(sqlSyntax2, connection);

            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();

            sqlDataAdapter.Fill(table);
            return table;
        }

    } 
}
