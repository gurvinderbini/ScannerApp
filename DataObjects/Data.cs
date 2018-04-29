using System;
using System.Collections.Generic;
using System.Text;

namespace DataObjects
{

  

    public class Data
    {
        public Scan scan { get; set; }
        public Previous_Scans[] previous_scans { get; set; }
    }

    public class Scan
    {
        public string code_number { get; set; }
        public string result { get; set; }
        public string scan_station { get; set; }
        public string date { get; set; }
        public object validated_date { get; set; }
        public string color { get; set; }
        public string updated_at { get; set; }
        public string created_at { get; set; }
        public int id { get; set; }
    }

    public class Previous_Scans
    {
        public int id { get; set; }
        public string code_number { get; set; }
        public string result { get; set; }
        public string color { get; set; }
        public string date { get; set; }
        public string validated_date { get; set; }
        public string scan_station { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
    }

}
