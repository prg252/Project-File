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
        /// <summary>
        /// Data Source=WINDOWS-17D44N0\SQLEXPRESS;Initial Catalog="Flight Simulator";Integrated Security=True
        /// </summary>
        public DataHandling()
        {
            connection.DataSource = @"WINDOWS-17D44N0\SQLEXPRESS";
            connection.InitialCatalog = "Flight Simulator";
            connection.IntegratedSecurity = true;
        }
        public DataSet ReadData(string tblName)
        {
            DataSet rawData = new DataSet();
            SqlConnection conn = new SqlConnection(connection.ToString());
            string query = string.Format("SELECT * FROM {0}", tblName);
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.FillSchema(rawData, SchemaType.Source, tblName);
                adapter.Fill(rawData, tblName);

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


        public DataSet GetSelectedData(int idToGet)
        {
            DataSet rawData = new DataSet();
            SqlConnection conn = new SqlConnection(connection.ToString());
            string query = string.Format("SELECT * FROM tblFlightSimulator WHERE FlightID ={0}",idToGet);
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.FillSchema(rawData, SchemaType.Source);
                adapter.Fill(rawData, "tblFlightSimulator");

            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);

            }
            finally
            {
                if (conn.State == ConnectionState.Open)
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
