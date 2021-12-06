using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoptionDatabase
{

    //This class serves as a head node for a linked list of Records.
    class ReturnedDataHolder
    {
        private Record firstData;
        private Record activeData;

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

        public bool next()
        {
            if((activeData == null) && (firstData == null))
            {
                return false;
            }
            else if(activeData == null)
            {
                activeData = firstData;
                return true;
            }
            else if(activeData.getNext() != null)
            {

                activeData = activeData.getNext();
                return true;
            }
            else
            {
                return false;
            }


        }

        public string GetString(int index)
        {
            return activeData.getString(index);
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
