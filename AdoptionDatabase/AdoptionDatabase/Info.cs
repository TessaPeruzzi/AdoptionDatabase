using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace AdoptionDatabase
{
    class Info
    {

        public enum TransactionType
        {
            QUERY_PET, QUERY_ADOPTER, QUERY_AGENCIES, QUERY_VETS, QUERY_SPECIALIZATIONS, QUERY_APPOINTMENTS, QUERY_SHOPS,
            ADD_PET, ADD_ADOPTER, ADD_APPOINTMENTS, ADD_ADOPTION, UPDATE_PETS, UPDATE_ADOPTERS, UPDATE_APPOINTMENTS, DELETE_ADOPTERS, DELETE_PET, DELETE_APPOINTMENTS, DELETE_ADOPTION
        };

        public Info()
        {

        }

        public static ReturnedDataHolder queryPetsForUser(string[] petTypes, string[] petSexes, string[] petAges)
        {
            ReturnedDataHolder pets = new ReturnedDataHolder();

            string query = "SELECT (PET_NAME, PET_TYPE, PICTURE, GENDER, AGE, ADOPTION_PRICE) FROM PET WHERE ";

            bool followingOutside = false;
            bool followingInside = false;

            if(hasContents(petTypes))
            {
                query += "(";

                for (int i = 0; i < petTypes.Length; i++)
                {
                    if (petTypes[i] != null)
                    { 
                        if (followingInside)
                            query += "OR ";

                        query = query + "(PET_TYPE = " + petTypes[i] + ") ";

                        followingInside = true;
                    }
                   

                }
                followingInside = false;
                followingOutside = true;

            }



            Debug.WriteLine(query);



            return pets;
        }
        
        private static bool hasContents(string[] s)
        {

            for(int i = 0; i < s.Length; i++)
            {
                if(s[i] != null)
                {
                    return true;
                }

            }
            return false;

        }


    }
}
