using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FlightApp
{
    class FlightDetails
    {
        private int FlightID;
        private string FlightType;
        private string FlightName;
        private string FuelIntake;
        private string engine;
        private string altitude;

        public int FlightID1
        {
            get
            {
                return FlightID;
            }

            set
            {
                FlightID = value;
            }
        }

        public string FlightType1
        {
            get
            {
                return FlightType;
            }

            set
            {
                FlightType = value;
            }
        }

        public string FlightName1
        {
            get
            {
                return FlightName;
            }

            set
            {
                FlightName = value;
            }
        }

        public string FuelIntake1
        {
            get
            {
                return FuelIntake;
            }

            set
            {
                FuelIntake = value;
            }
        }

        public string Engine
        {
            get
            {
                return engine;
            }

            set
            {
                engine = value;
            }
        }

        public string Altitude
        {
            get
            {
                return altitude;
            }

            set
            {
                altitude = value;
            }
        }

        public FlightDetails(int flightID, string flightType, string flightName, string fuelIntake, string engine, string altitude)
        {
            this.FlightID1 = flightID;
            this.FlightType1 = flightType;
            this.FlightName1 = flightName;
            this.FuelIntake1 = fuelIntake;
            this.engine = engine;
            this.altitude = altitude;
        }

        public FlightDetails()
        {

        }

        public List<FlightDetails> GetFlight()
        {
            List<FlightDetails> Mylist = new List<FlightDetails>();
            DataHandling dh = new DataHandling();
            DataSet data = dh.ReadData(FlightID);
            foreach (DataRow item in data.Tables["tblFlightSimulator"].Rows)
            {
                Mylist.Add(new FlightDetails(int.Parse(item[""].ToString()),item[""].ToString(),item[""].ToString(),item[""].ToString(),item["Engine"].ToString(),item["Altitude"].ToString()));

            }
            return Mylist;
        }

        public int delete(int ID)
        {
            DataHandling data = new DataHandling();

            int affected = data.DeletetInfo(ID);
            return affected;

        }
        public int insert(string name,string type,string fuelintake, string engine, string altitude)
        {
            DataHandling data = new DataHandling();

            int affected = data.InsertInfo(name,type,fuelintake,engine,altitude);
            return affected;
        }
        public int update(int id, string name, string type, string fuelintake, string engine, string altitude)
        {
            DataHandling data = new DataHandling();

            int affected = data.UpdattInfo(id,name,type,fuelintake,engine,altitude);
            return affected;
        }

    }
}
