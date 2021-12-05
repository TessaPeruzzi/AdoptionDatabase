using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Data;

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

        public static ReturnedDataHolder queryPetsForUser(string[] petTypes, string petGender, string ageOperator, string age)
        {
            ReturnedDataHolder pets = new ReturnedDataHolder();
            string query = "SELECT PET.PET_ID, PETSHOP.NAME, AGENCY.NAME, VET.NAME, PET.PET_NAME, PET.PET_TYPE, PET.PICTURE, PET.GENDER, PET.AGE, PET.ADOPTION_PRICE FROM (PET JOIN PETSHOP ON(PET.PETSHOP_ID = PETSHOP.PETSHOP_ID) JOIN VET ON VET.VET_ID = PET.VET_ID JOIN AGENCY ON AGENCY.AGENCY_ID = PET.AGENCY_ID)";

            bool followingOutside = false;
            bool followingInside = false;

            if(hasContents(petTypes))
            {
                if (followingOutside == false)
                    query += " WHERE";

                query += "(";

                for (int i = 0; i < petTypes.Length; i++)
                {
                    if (petTypes[i] != null)
                    { 
                        if (followingInside)
                            query += " OR";

                        query = query + " (PET.PET_TYPE = '" + petTypes[i] + "')";

                        followingInside = true;
                    }
                   

                }
                followingInside = false;
                followingOutside = true;

                query += " )";
            }

            if(petGender != null)
            {
                if (followingOutside == false)
                {
                    query += " WHERE";
                }
                else
                {
                    query += " AND";
                }

                query += " (PET.GENDER = '" + petGender + "')";

                followingOutside = true;

            }

            if(ageOperator != "")
            {
                if (followingOutside == false)
                    query += " WHERE";
                else
                {
                    query += " AND";
                }

                query += " (PET.AGE " + ageOperator +  " " + age + ")";

                followingOutside = true;
            }

            query += ";";

            Debug.WriteLine(query);

            DatabaseInterface DataLink = new DatabaseInterface();

            pets = DataLink.queryDatabase(query, 10);

            pets.dumpToConsole();
           


            return pets;
        }
        
        public static bool hasContents(string[] s)
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

        public static DataTable getPetTable(string[] infoBox)
        {
            DatabaseInterface activeInterface = new DatabaseInterface();
            string whereString;
            string selectString = "SELECT P.PET_ID, P.PETSHOP_ID, P.AGENCY_ID, P.VET_ID, P.PET_NAME, P.PET_TYPE, P.PICTURE, P.GENDER, AGE, P.ADOPTION_PRICE, AD.FIRSTNAME FROM PET AS P LEFT OUTER JOIN ADOPTION AS A ON P.PET_ID = A.PET_ID LEFT OUTER JOIN ADOPTER AS AD ON AD.ADOPTER_ID = A.ADOPTER_ID";
;
            if (infoBox == null)                   
                whereString = "";
            else
            {
                whereString = "";
            }

            return activeInterface.requestTable(selectString, whereString);
        }
        public static DataTable getAgencyTable(string[] infoBox)
        {
            DatabaseInterface activeInterface = new DatabaseInterface();
            string whereString;
            string selectString = "SELECT AGENCY_ID, NAME, ADDRESS, PHONE_NUM FROM AGENCY";
            if (infoBox == null)
                whereString = "";
            else
            {
                whereString = "";
            }

            return activeInterface.requestTable(selectString, whereString);
        }
        public static DataTable getVetTable(string[] infoBox)
        {
            DatabaseInterface activeInterface = new DatabaseInterface();
            string whereString;
            string selectString = "SELECT V.VET_ID, V.NAME, V.ADDRESS, V.PHONE_NUM, V.LOGO FROM VET AS V JOIN SPECIALIZATIONS_has_VET AS SV ON V.VET_ID = SV.VET_VET_ID JOIN SPECIALIZATIONS AS S ON S.ID = SV.SPECIALIZATIONS_ID";
            if (infoBox == null)
                whereString = "";
            else
            {
                bool followingInside = false;

                whereString = " WHERE ";

                for (int i = 0; i < infoBox.Length; i++)
                {
                    if (infoBox[i] != null)
                    {
                        if (followingInside)
                            whereString += " OR";

                        whereString = whereString + " (S.NAME = '" + infoBox[i] + "')";

                        followingInside = true;
                    }


                }
            }

            whereString += " GROUP BY VET_ID;";

            return activeInterface.requestTable(selectString, whereString);
        }
        public static DataTable getShopTable(string[] infoBox)
        {
            DatabaseInterface activeInterface = new DatabaseInterface();
            string whereString;
            string selectString = "SELECT PETSHOP_ID, NAME, ADDRESS, PHONE_NUM FROM PETSHOP";
            if (infoBox == null)
                whereString = "";
            else
            {
                whereString = "";
            }

            return activeInterface.requestTable(selectString, whereString);
        }
        public static DataTable getAdopterTable(string[] infoBox)
        {
            DatabaseInterface activeInterface = new DatabaseInterface();
            string whereString;
            string selectString = "SELECT AD.ADOPTER_ID, AD.FIRSTNAME, AD.LASTNAME, AD.PHONE, AD.ADDRESS, AD.CITY, AD.STATE, AD.ZIP, AP.PET_ID, T.START_TIME, ADOPTION.PET_ID FROM(ADOPTER AS AD LEFT OUTER JOIN APPOINTMENT AS AP ON AD.ADOPTER_ID = AP.ADOPTER_ID) LEFT OUTER JOIN APPOINTMENT_SLOT AS APS ON((AP.TIMESLOT_ID = APS.TIMESLOT_ID) AND(AP.VOLUNTEER_ID = APS.VOLUNTEER_ID)) LEFT OUTER JOIN TIMESLOT AS T ON T.TIMESLOT_ID = APS.TIMESLOT_ID LEFT OUTER JOIN ADOPTION ON AD.ADOPTER_ID = ADOPTION.ADOPTER_ID";
            if (infoBox == null)
                whereString = "";
            else
            {
                whereString = "";
            }

            return activeInterface.requestTable(selectString, whereString);
        }
        public static DataTable getVolunteerTable(string[] infoBox)
        {
            DatabaseInterface activeInterface = new DatabaseInterface();
            string whereString;
            string selectString = "SELECT VOLUNTEER_ID, FIRSTNAME, LASTNAME, IS_ADMIN FROM VOLUNTEER";
            if (infoBox == null)
                whereString = "";
            else
            {
                whereString = "";
            }

            return activeInterface.requestTable(selectString, whereString);
        }
        public static DataTable getAppointmentTable(string[] infoBox)
        {
            DatabaseInterface activeInterface = new DatabaseInterface();
            string whereString;
            string selectString = "SELECT A.APPOINTMENT_ID, AD.FIRSTNAME, P.PET_NAME, V.FIRSTNAME, T.TIMESLOT_ID, T.START_TIME, T.END_TIME FROM APPOINTMENT AS A JOIN APPOINTMENT_SLOT AS APS ON((A.VOLUNTEER_ID = APS.VOLUNTEER_ID) AND(A.TIMESLOT_ID = APS.TIMESLOT_ID)) JOIN TIMESLOT AS T ON(APS.TIMESLOT_ID = T.TIMESLOT_ID) JOIN VOLUNTEER AS V ON APS.VOLUNTEER_ID = V.VOLUNTEER_ID JOIN ADOPTER AS AD ON AD.ADOPTER_ID = A.ADOPTER_ID JOIN PET AS P ON P.PET_ID = A.PET_ID;";
            if (infoBox == null)
                whereString = "";
            else
            {
                whereString = "";
            }

            return activeInterface.requestTable(selectString, whereString);
        }

        public static int getIndex(string database, string data)
        {
            
            DatabaseInterface activeInterface = new DatabaseInterface();

            switch(database)
            {
                case "ADOPTER":
                    return activeInterface.getIndex("ADOPTER", "ADOPTER_ID", data, "FIRSTNAME");
                case "PET":
                    return activeInterface.getIndex("PET", "PET_ID", data, "PET_NAME");
                default:
                    return activeInterface.getIndex("VOLUNTEER", "VOLUNTEER_ID", data, "FIRSTNAME");


            }



        }




        public static void insertIntoDatabase(string query)
        {
            DatabaseInterface activeInterface = new DatabaseInterface();
            activeInterface.modifyDatabase(query);
        }

    }

    
   
    
}
