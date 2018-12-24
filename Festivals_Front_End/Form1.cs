using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Runtime.Serialization;

namespace Festivals_Front_End
{
    public partial class Form1 : Form
    {

        String Festival { get; set; } = "";

        FestivalsBandsServiceReference.FestivalBandsServiceClient ws = null;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ws = new FestivalsBandsServiceReference.FestivalBandsServiceClient();
        }
        private void comBoxFestivals_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxBands.Items.Clear();

            Festival = ComBoxFestivals.SelectedItem.ToString();

             List<String> bands = ws.GenerateNewBandList(Festival);

            listBoxBands.Items.AddRange(bands.ToArray());

            Console.WriteLine(String.Join(",",bands));
            /*string dataSource = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " +
                           @"D:\WCFFestivalBands\WCFFestivalBands\App_Data\FestivalBands.mdf; Integrated Security = True; Connect Timeout = 30";


            //Create new instance of sql connection, pass in the connection string for FestivalBands.mdf to connect to database.
            SqlConnection conn = new SqlConnection(dataSource);

            string sqlQuerySelectBands = "SELECT Bands.Band_Name FROM Band_Festival JOIN dbo.Bands ON Bands.Band_ID =" +
                                      "Band_Festival.Band_ID JOIN dbo.Festival ON Festival.Festival_ID " +
                                      "= Band_Festival.Festival_ID WHERE Festival_Name = @festival";

            SqlCommand cmd = new SqlCommand(sqlQuerySelectBands, conn);
            cmd.Parameters.AddWithValue("@festival", festival);

            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                listBoxBands.Items.Add(reader["Band_Name"].ToString());
            }

            reader.Close();

            conn.Close();*/

        }

       

    }

       
    }

