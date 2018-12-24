using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;

namespace WCF_FestivalBands
{
   
    public class FestivalBandsService : IFestivalBandsService
    {
        public List<String> GenerateNewBandList(String Festival)
        {
            

            string dataSource = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " +
                           @"D:\WCFFestivalBands\WCFFestivalBands\App_Data\FestivalBands.mdf; Integrated Security = True; Connect Timeout = 30";


            //Create new instance of sql connection, pass in the connection string for FestivalBands.mdf to connect to database.
            SqlConnection conn = new SqlConnection(dataSource);

            string sqlQuerySelectBands = "SELECT Bands.Band_Name FROM Band_Festival JOIN dbo.Bands ON Bands.Band_ID =" +
                                      "Band_Festival.Band_ID JOIN dbo.Festival ON Festival.Festival_ID " +
                                      "= Band_Festival.Festival_ID WHERE Festival_Name = @festival";
            

            SqlCommand cmd = new SqlCommand(sqlQuerySelectBands, conn);
            cmd.Parameters.AddWithValue("@festival", Festival);

            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            //Create new list of bands
            List<String> bands = new List<string>();

            while (reader.Read())
            {
                bands.Add(reader["Band_Name"].ToString());
            }


            reader.Close();
           
          
            //Return the list of bands
            return bands;
        }

     
    }

}
