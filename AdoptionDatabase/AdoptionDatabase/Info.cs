using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoptionDatabase
{
    class Info
    {

        public enum TransactionType
        {
            QUERY_PET, QUERY_ADOPTER, QUERY_AGENCIES, QUERY_VETS, QUERY_SPECIALIZATIONS, QUERY_APPOINTMENTS, QUERY_SHOPS,
            ADD_PET, ADD_ADOPTER, ADD_APPOINTMENTS, ADD_ADOPTION, UPDATE_PETS, UPDATE_ADOPTERS, UPDATE_APPOINTMENTS, DELETE_ADOPTERS, DELETE_PET, DELETE_APPOINTMENTS, DELETE_ADOPTION
        };



    }
}
