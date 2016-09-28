using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace MusicWS.Models
{
    public class SearchModels
    {
        public List<String> search()
        {
            List<String> listan = new List<String>();
            string connstring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = ""H:\Documents\Visual Studio 2015\Projects\lab3\MusicDB.mdf""; Integrated Security = True; Connect Timeout = 30";
            SqlConnection dbCon = new SqlConnection(connstring);

            String sqlString = "Select * From Artist";
            SqlCommand dbCom = new SqlCommand(sqlString, dbCon);

            dbCon.Open();
            SqlDataReader nwReader = dbCom.ExecuteReader();
            while (nwReader.Read())
            {
                string firstName = (string)nwReader["FirstName"];
                string lastName = (string)nwReader["LastName"];
                listan.Add(firstName+lastName);

            }
            nwReader.Close();
            dbCon.Close();
            return listan;
        }


        public String ListToString(List<string> listan)
        {
            String stringArray = null;
            for(int i = 0; i< listan.Count; i++)
            {
                stringArray = stringArray + listan[i];
            }
            return stringArray;
        }
    }
}