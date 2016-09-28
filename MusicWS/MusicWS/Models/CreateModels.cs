using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace MusicWS.Models
{
    public class CreateModels
    {
        public void AddGenre(string genre)
        {
                string connstring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = ""H:\Documents\Visual Studio 2015\Projects\lab3\MusicDB.mdf""; Integrated Security = True; Connect Timeout = 30";
                SqlConnection dbCon = new SqlConnection(connstring);

                String sqlString = "INSERT INTO Genre (Genre) VAlUES (@genre)";
                SqlCommand dbCom = new SqlCommand(sqlString, dbCon);
                dbCom.Parameters.Add("@genre", SqlDbType.NVarChar).Value = genre;
            try
            {
                dbCon.Open();
                dbCom.ExecuteNonQuery();
                dbCon.Close();

            }
            catch(Exception e) {
                Console.Write(e.ToString());
            }
        }

        public void AddArtist(string Firstname, string LastName)
        {
            string connstring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = ""H:\Documents\Visual Studio 2015\Projects\lab3\MusicDB.mdf""; Integrated Security = True; Connect Timeout = 30";
            SqlConnection dbCon = new SqlConnection(connstring);

            String sqlString = "INSERT INTO Artist (FirstName, LastName) VAlUES (@Firstname,@LastName)";
            SqlCommand dbCom = new SqlCommand(sqlString, dbCon);
            dbCom.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = Firstname;
            dbCom.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = LastName;
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

        public void AddAlbum(string AlbumName, int Year)
        {
            string connstring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = ""H:\Documents\Visual Studio 2015\Projects\lab3\MusicDB.mdf""; Integrated Security = True; Connect Timeout = 30";
            SqlConnection dbCon = new SqlConnection(connstring);

            String sqlString = "INSERT INTO Artist (AlbumName, year) VAlUES (@AlbumName,@Year)";
            SqlCommand dbCom = new SqlCommand(sqlString, dbCon);
            dbCom.Parameters.Add("@AlbumName", SqlDbType.NVarChar).Value = AlbumName;
            dbCom.Parameters.Add("@Year", SqlDbType.Int).Value = Year;
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