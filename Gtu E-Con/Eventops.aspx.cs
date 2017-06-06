﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Oracle.ManagedDataAccess.Client;


namespace Gtu_E_Con
{
    public partial class Eventops : Page
    {
        OracleConnection con;
        protected void Page_Load(object sender, EventArgs e)
        {
            String conStr = "USER ID=lelo;Password=123;Data Source=localhost:1521/xe";
            con = new OracleConnection();
            con.ConnectionString = conStr;
            con.Open();
        }


        protected void Button1_Click1(object sender, EventArgs e)
        {
            OracleCommand query = con.CreateCommand();
            query.CommandText = "select * from events";
            OracleDataReader Reader = query.ExecuteReader();
            int rowCount = 0;

            while (Reader.Read())
            {
                rowCount++;
            }

            query.CommandText = "INSERT INTO EVENTS VALUES(" + rowCount + "," + capacity.Text + ",'" + eventDate.Text + "','" + eventName.Text + "','" + eventDescription.Text + "'," + duration.Text + ",'" + eventType.Text + "')";
            query.ExecuteReader();
        }
    }
}