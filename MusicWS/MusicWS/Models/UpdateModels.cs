using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace MusicWS.Models
{
    public class UpdateModels
    {
        public void UpdateArtist(string newFirst, string newLast, string oldFirst, string oldLast)
        {
            string connstring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = ""H:\Documents\Visual Studio 2015\Projects\lab3\MusicDB.mdf""; Integrated Security = True; Connect Timeout = 30";
            SqlConnection dbCon = new SqlConnection(connstring);

            String sqlString = "UPDATE Artist SET FirstName=@newFirst,LastName=@newLast WHERE FirstName=@oldFirst AND LastName=@oldLast";
            SqlCommand dbCom = new SqlCommand(sqlString, dbCon);
            dbCom.Parameters.Add("@newLast", SqlDbType.NVarChar).Value = newLast;
            dbCom.Parameters.Add("@newFirst", SqlDbType.NVarChar).Value = newFirst;
            dbCom.Parameters.Add("@oldLast", SqlDbType.NVarChar).Value = oldLast;
            dbCom.Parameters.Add("@oldFirst", SqlDbType.NVarChar).Value = oldFirst;
            try
            {
                dbCon.Open();
                dbCom.ExecuteNonQuery();
                dbCon.Close();

            }
            catch (Exception e)
            {
                Console.Write(e.ToString());
            }
        }
    }
}