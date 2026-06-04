using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.Data.Sqlite;
using Incident_Library.MODELS__Data_;

namespace Incident_Library.Repository
{
    public class IncidentRepository
    {
        public List<IncidentReport> Read()
        {
            var incidentList = new List<IncidentReport>();
            using var conncetion = new SqliteConnection("Data Source=IncidentLibrary.db;");
            conncetion.Open();
            using var command = new SqliteCommand("SELECT * FROM Incident", conncetion);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                IncidentReport i = new IncidentReport();
                i.Id = Convert.ToInt32(reader["IncidentID"]);
                i.Title = reader["Title"] as string;
                i.HowDiscovered = reader["HowDiscovered"] as string;
                i.WhatIsIncident = reader["WhatIsIncident"] as string;
                i.HowResolved = reader["HowResolved"] as string;
                i.Status = Convert.ToInt32(reader["StatusID"]);

                incidentList.Add(i);
            }
            return incidentList;
        }
    }
}
