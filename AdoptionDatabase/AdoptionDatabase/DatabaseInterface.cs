using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace AdoptionDatabase
{
    class DatabaseInterface
    {
        MySqlConnection connection;

        public DatabaseInterface()
        {
            connection = new MySqlConnection();
            connection.ConnectionString = "server = 127.0.0.1;uid = root;pwd=12345;database=Test";
            connection.Open();



        }


        public ReturnedDataHolder queryDatabase(string queryString, int numcolumns)
        {
            ReturnedDataHolder response = new ReturnedDataHolder();

            MySqlCommand commander = new MySqlCommand();
            commander.CommandText = queryString;
            commander.Connection = connection;
            commander.CommandType = System.Data.CommandType.Text;

            MySqlDataReader output = commander.ExecuteReader();


            Console.WriteLine("good so far");


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

            return response;
        }


        public void modifyDatabase(string insertString)
        {
            MySqlCommand commander = new MySqlCommand();
            commander.Connection = connection;
            commander.CommandType = System.Data.CommandType.Text;
            commander.CommandText = insertString;

            try
            {
                commander.ExecuteReader().Close();
            }
            catch (Exception e)
            {

            }


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


    }
}
