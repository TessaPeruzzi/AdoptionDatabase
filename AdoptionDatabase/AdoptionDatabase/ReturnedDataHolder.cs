using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoptionDatabase
{
    class ReturnedDataHolder
    {
        private Record firstData;


        public ReturnedDataHolder()
        {
            firstData = null;
        }

        public void insert(Record newData)
        {
            if (firstData == null)
            {
                firstData = newData;
            }
            else
            {
                firstData.insert(newData);
            }

        }

        public void dumpToConsole()
        {
            if (firstData != null)
            {
                firstData.dumpToConsole();
            }
        }


    }
}
