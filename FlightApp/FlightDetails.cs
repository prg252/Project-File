﻿using System;
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
        private string FlightName;
        private int FuelIntake;
        private string engine;
        private string altitude;
        private int speed;
        private string cango;

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

        public int FuelIntake1
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

        public int Speed { get => speed; set => speed = value; }
        public string Cango { get => cango; set => cango = value; }

        public FlightDetails(int flightID, string flightName, string engine, int fuelIntake, string altitude, int speed, string cango)
        {
            this.FlightID1 = flightID;
            this.FlightName1 = flightName;
            this.FuelIntake1 = fuelIntake;
            this.engine = engine;
            this.altitude = altitude;
            this.speed = speed;
            this.cango = cango;
        }

        public FlightDetails()
        {

        }

        public List<FlightDetails> GetFlight()
        {
            List<FlightDetails> Mylist = new List<FlightDetails>();
            DataHandling dh = new DataHandling();
            DataSet data = dh.ReadData("tblFlightSimulator");
            foreach (DataRow item in data.Tables["tblFlightSimulator"].Rows)
            {
                Mylist.Add(new FlightDetails(int.Parse(item["FlightID"].ToString()),item["Name"].ToString(), item["Engine"].ToString(), int.Parse(item["Fuel"].ToString()),item["Altitude"].ToString(),int.Parse(item["Speed"].ToString()), item["Cargo"].ToString()));

            }
            return Mylist;
        }

        public List<FlightDetails> getSelectedFlight(int idToGet)
        {
            List<FlightDetails> Mylist = new List<FlightDetails>();
            DataHandling dh = new DataHandling();
            DataSet data = dh.GetSelectedData(idToGet);
            foreach (DataRow item in data.Tables["tblFlightSimulator"].Rows)
            {
                Mylist.Add(new FlightDetails(int.Parse(item["FlightID"].ToString()), item["Name"].ToString(), item["Engine"].ToString(), int.Parse(item["Fuel"].ToString()), item["Altitude"].ToString(), int.Parse(item["Speed"].ToString()), item["Cargo"].ToString()));

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
