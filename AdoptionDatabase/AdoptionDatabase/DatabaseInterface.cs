using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Data;

namespace AdoptionDatabase
{
    class DatabaseInterface
    {
        MySqlConnection connection;

        public DatabaseInterface()
        {
            



        }


        public ReturnedDataHolder queryDatabase(string queryString, int numcolumns)
        {
            connection = new MySqlConnection();
            connection.ConnectionString = "server = 127.0.0.1;uid = root;pwd=Adoption1@;database=adoption_db";
            connection.Open();

            ReturnedDataHolder response = new ReturnedDataHolder();

            MySqlCommand commander = new MySqlCommand();
            commander.CommandText = queryString;
            commander.Connection = connection;
            commander.CommandType = System.Data.CommandType.Text;

            MySqlDataReader output;

            try
            {
                output = commander.ExecuteReader();

                while (output.Read())
                {
                    string[] dataOut = new string[numcolumns];

                    for (int i = 0; i < numcolumns; i++)
                    {
                        dataOut[i] = output[i].ToString();
                    }

                    response.insert(new Record(dataOut));

                }

                output.Close();
            }
            catch(Exception e)
            {
                Debug.WriteLine("The action could not be performed");
            }

            


            
            connection.Close();
            connection = null;


            return response;
        }


        public void modifyDatabase(string insertString)
        {
            connection = new MySqlConnection();
            connection.ConnectionString = "server = 127.0.0.1;uid = root;pwd=Adoption1@;database=adoption_db";
            connection.Open();

            MySqlCommand commander = new MySqlCommand();
            commander.Connection = connection;
            commander.CommandType = System.Data.CommandType.Text;
            commander.CommandText = insertString;

            Debug.WriteLine(insertString);

            try
            {

                commander.ExecuteNonQuery();

            }
            catch(Exception e)
            {

                Debug.WriteLine("The action could not be performed");

            }
            connection.Close();
                
                
            
            


        }


        public int getHighestIndex(string table)
        {
            int output = 0;

            MySqlCommand commander = new MySqlCommand();
            commander.Connection = connection;
            commander.CommandType = System.Data.CommandType.Text;
            commander.CommandText = "SELECT * FROM " + table;

            MySqlDataReader dataOut = commander.ExecuteReader();

            while (dataOut.Read())
            {
                if (int.Parse((dataOut[0].ToString())) > output)
                    output = int.Parse((dataOut[0].ToString()));
            }

            dataOut.Close();

            return output;
        }

        public DataTable requestTable(string selectString, string whereString)
        {


            string cs = @"Server=localhost; Port=3306; Database=adoption_db; Uid=root; Pwd=Adoption1@;";
            MySqlConnection con = new MySqlConnection(cs);
            con.Open();
            MySqlCommand cmd = new MySqlCommand(selectString + whereString, con);

            Debug.WriteLine(selectString + whereString);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable fillTable = new DataTable();

            try
            {
                adapter.Fill(fillTable);
            }
            catch(Exception e)
            {
                Debug.WriteLine("Your transaction could not be completed");
            }

            con.Close();

            return fillTable;

        }


     


    }
}
