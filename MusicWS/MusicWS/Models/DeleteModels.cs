using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace MusicWS.Models
{
    public class DeleteModels
    {
        public void DeleteArtist(string firstName, string lastName)
        {

            string connstring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = ""H:\Documents\Visual Studio 2015\Projects\lab3\MusicDB.mdf""; Integrated Security = True; Connect Timeout = 30";
            SqlConnection dbCon = new SqlConnection(connstring);

            String sqlString = "DELETE FROM Artist WHERE FirstName=@firstName AND LastName=@lastName";
            SqlCommand dbCom = new SqlCommand(sqlString, dbCon);
            dbCom.Parameters.Add("@lastName", SqlDbType.NVarChar).Value = lastName;
            dbCom.Parameters.Add("@firstName", SqlDbType.NVarChar).Value = firstName;

            try
            {
                dbCon.Open();
                dbCom.ExecuteNonQuery();
                dbCon.Close();

            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
            }
        }
    }
}