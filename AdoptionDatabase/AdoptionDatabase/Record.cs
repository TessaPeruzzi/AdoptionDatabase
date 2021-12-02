using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace AdoptionDatabase
{
    class Record
    {
        private Record next;
        private string[] data;



        public Record(string[] data)
        {
            next = null;
            this.data = data;

        }

        public void insert(Record newRecord)
        {
            if (next != null)
            {
                next.insert(newRecord);
            }
            else
            {
                next = newRecord;

            }
        }

        public string getString(int index)
        {
            return data[index];
        }

        public void dumpToConsole()
        {

            for (int i = 0; i < data.GetLength(0); i++)
            {
                Debug.Write(data[i] + " ");

            }
            Debug.Write("\n");

            if (next != null)
                next.dumpToConsole();
        }



        public Record getNext()
        {
            return next;
        }







    }
}
