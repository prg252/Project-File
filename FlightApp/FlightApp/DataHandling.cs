using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace FlightApp
{
    class DataHandling
    {
        SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();
        public DataHandling()
        {
            connection.DataSource = @"";
            connection.InitialCatalog = "";
            connection.IntegratedSecurity = true;
        }
        public DataSet ReadData(int tblName)
        {
            DataSet rawData = new DataSet();
            SqlConnection conn = new SqlConnection(connection.ToString());
            string query = string.Format("SELECT * FROM {0}", tblName);
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.FillSchema(rawData, SchemaType.Source, tblName.ToString());
                adapter.Fill(rawData, tblName.ToString());

            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
                
            }
            finally
            {
                if (conn.State==ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return rawData;
        }
       
        public int InsertInfo(string name,string type,string fuel, string engine, string altitude)
        {
            int affected = 0;
            SqlConnection conn = new SqlConnection(connection.ToString());
            string qry = string.Format("INSERT INTO tblFlightSimulator(Name,Type,FuelIntake,engine,altitude) VALUES(@name,@type,@fuel,@engine,@altitude)");
            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(qry, conn);
                comm.Parameters.AddWithValue("@", name);
                comm.Parameters.AddWithValue("@",type);
                comm.Parameters.AddWithValue("@", fuel);
                

            }
            catch (SqlException se)
            {

                MessageBox.Show(se.Message);
            }
            return affected;
        }
        public int UpdattInfo(int ID,string name, string type, string fuel, string engine, string altitude)
        {
            int affected = 0;
            SqlConnection conn = new SqlConnection(connection.ToString());
            string qry = string.Format("UPDATE tblFlightSimulator SET FlightId=@ID,Name=@name,Type=@type,Fuel=@fuel,Engine=@engine,Altitude=@altitude ");
            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(qry, conn);
                comm.Parameters.AddWithValue("@", name);
                comm.Parameters.AddWithValue("@", type);
                comm.Parameters.AddWithValue("@", fuel);
                comm.Parameters.AddWithValue("@", ID);
                comm.Parameters.AddWithValue("@", engine);
                comm.Parameters.AddWithValue("@", altitude);


            }
            catch (SqlException se)
            {

                MessageBox.Show(se.Message);
            }
            return affected;
        }
        public int DeletetInfo(int ID)
        {
            int affected = 0;
            SqlConnection conn = new SqlConnection(connection.ToString());
            string qry = string.Format("DELETE FROM tblFlightSimulator WHERE FlightID=ID");
            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(qry, conn);
                comm.Parameters.AddWithValue("@", ID);
                


            }
            catch (SqlException se)
            {

                MessageBox.Show(se.Message);
            }
            return affected;
        }
    }
}
