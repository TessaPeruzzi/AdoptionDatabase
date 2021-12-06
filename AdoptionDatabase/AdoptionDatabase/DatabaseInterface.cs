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



        //This method performs the query indicated by the queryString, and returns the results in a Record-based linked list.
        //It is called by the queryPetsForUser method in Info
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



        //This method finds the ID nubmer associated with a given piece of data in a given database.
        //It is called by the method of the same name in the Info class.
        public int getIndex(string table, string returnTarget, string data, string dataType)
        {

            connection = new MySqlConnection();
            connection.ConnectionString = "server = 127.0.0.1;uid = root;pwd=Adoption1@;database=adoption_db";
            connection.Open();

            MySqlCommand commander = new MySqlCommand("SELECT " + returnTarget + " FROM " + table + " WHERE '" + data + "' = " + dataType +";", connection);

            

            Debug.WriteLine(commander.CommandText);

            int output = 0;

            try
            {
                MySqlDataReader reader = commander.ExecuteReader();

                while (reader.Read())
                {
                    output = int.Parse(reader[0].ToString());

                }

                reader.Close();

            }
            catch(Exception e)
            {
                Debug.WriteLine("The query failed");
            }

            connection.Close();

            return output;

        }


        //This method performs the SQL query held by the insertString argument.
        //This method is called through the method of the same name in the Info class for all updates, insert, and delete statements.
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

        //This method gets a DataTable object from the database using the query formed by adding the selectString and the whereString.
        //It is called by all of the methods in the Info class that return a DataTable object, such as the getXTable and searchX methods.
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
