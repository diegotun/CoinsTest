using CoinsTest.Models;
using CsvHelper;
using JsonFlatten;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace CoinsTest.Utils
{
    public static class Tools
    {
        public static DataTable JsonStringToTable(string jsonContent)
        {
            //JObject json = JObject.Parse(jsonContent);
            DataTable dt = JsonConvert.DeserializeObject<DataTable>(jsonContent);
            return dt;
        }

        public static string JsonToCSV(string jsonContent, string delimiter)
        {
            StringWriter csvString = new StringWriter();
            using (var csv = new CsvWriter(csvString, CultureInfo.InvariantCulture))
            {
                
                using (var dt = JsonStringToTable(jsonContent))
                {
                    foreach (DataColumn column in dt.Columns)
                    {
                        csv.WriteField(column.ColumnName);
                    }
                    csv.NextRecord();

                    foreach (DataRow row in dt.Rows)
                    {
                        for (var i = 0; i < dt.Columns.Count; i++)
                        {
                            csv.WriteField(row[i]);
                        }
                        csv.NextRecord();
                    }
                }
            }
            return csvString.ToString();
        }

        public static string ObjToCsv(RootCoinDetails myobj)
        {
            StringWriter csvString = new StringWriter();
            using (var csv1 = new CsvWriter(csvString, CultureInfo.InvariantCulture))
            {
                using (DataTable dt = Tools.SetJSONToDT(myobj))
                {
                    foreach (DataColumn column in dt.Columns)
                    {
                        csv1.WriteField(column.ColumnName);
                    }
                    csv1.NextRecord();

                    foreach (DataRow row in dt.Rows)
                    {
                        for (var i = 0; i < dt.Columns.Count; i++)
                        {
                            csv1.WriteField(row[i]);
                        }
                        csv1.NextRecord();
                    }
                }
            }
            return csvString.ToString();
        }

        public static DataTable SetJSONToDT(RootCoinDetails myObj)
        {
            DataTable dt = new DataTable();
            dt.TableName = "myDT";

                foreach (PropertyInfo property in myObj.GetType().GetProperties())
                {
                    dt.Columns.Add(new DataColumn(property.Name, property.PropertyType));
                }

                /*foreach (var obj in myObj)
                {*/
                    DataRow newRow = dt.NewRow();
                    foreach (PropertyInfo property in myObj.GetType().GetProperties())
                    {
                        newRow[property.Name] = myObj.GetType().GetProperty(property.Name).GetValue(myObj, null);
                    }
                    dt.Rows.Add(newRow);
                //}
                return dt;
            
        }


        public static string FlatAndFormatJSON(string jsonstring)
        {
            var json = JObject.Parse(jsonstring).ToString(Newtonsoft.Json.Formatting.None);
            var jObject = JObject.Parse(json);
            var flattened = jObject.Flatten();
            string flattenedJsonString = JsonConvert.SerializeObject(flattened, Formatting.Indented);
            JObject newjson = JObject.Parse(flattenedJsonString);
            string jsonFlat = JObject.Parse(newjson.ToString()).ToString(Newtonsoft.Json.Formatting.None);
            return jsonFlat;
        }
    }
}
