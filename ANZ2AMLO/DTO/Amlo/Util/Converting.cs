using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.IO;


namespace DTO.Util
{
   public class Converting
    {
       public static string ConvertDateTimeToEng(DateTime dt)
       {
           string strDate = "";

           strDate = string.Format("{0}/{1}/{2}",dt.Month.ToString(),dt.Day.ToString(),dt.Year.ToString());
           return strDate;
       }

       public static DateTime StringToDateEng(string strDate)
       {
           DateTime dtEng ;

           IFormatProvider iformate = new CultureInfo("en-US");
           dtEng = DateTime.Parse(strDate, iformate);

           return dtEng;
       }

       public static int StringToInt(string data)
       {
           int result = 0;
           try
           {

               result = Convert.ToInt32(data);
           }
           catch
           { }
           finally
           { }

           return result;
       }

    


        public static DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Defining type of data column gives proper data table 
                var type = (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>) ? Nullable.GetUnderlyingType(prop.PropertyType) : prop.PropertyType);
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name, type);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;

        }
       


     

      


        public static IEnumerable<T> GetListFromDataReader<T>(SqlDataReader reader) where T : new()
        {

            var obj = new T();
            var properties = typeof(T).GetProperties();
            string proName = "";
            var columnList = (reader.GetSchemaTable().Select()).Select(r => r.ItemArray[0].ToString());
            while (reader.Read())
            {
                var element = Activator.CreateInstance<T>();
                foreach (var property in properties)
                {
                    if (!columnList.Contains(property.Name))
                    {
                        continue;
                    }
                    var o = (object)reader[property.Name];
                    if (o.GetType() != typeof(DBNull)) property.SetValue(element, ChangeType(o, property.PropertyType), null);
                }
                yield return element;
            }

        }




        public static List<T> ConvertDataReaderToObjectList<T>(SqlDataReader reader)
        {

            var obj = new List<T>();
            var properties = typeof(T).GetProperties();
            string proName = "";
            var colNames = (reader.GetSchemaTable().Select()).Select(r => r.ItemArray[0].ToString()).ToList();
            while (reader.Read())
            {
                var item = Activator.CreateInstance<T>();
                foreach (var property in typeof(T).GetProperties())
                {
                    if (colNames.Find(delegate (string colName)
                    {
                        return colName.ToLower().Equals(property.Name.ToLower());
                    }) != null)
                    {

                        Type convertTo = Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType;
                        property.SetValue(item, Convert.ChangeType(reader[property.Name], convertTo), null);

                    }
                }

                obj.Add(item);

            }

            return obj;

        }




        public static object ChangeType(object value, Type conversion)
        {
            var t = conversion;

            if (t.IsGenericType && t.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
            {
                if (value == null)
                {
                    return null;
                }

                t = Nullable.GetUnderlyingType(t); ;
            }

            return Convert.ChangeType(value, t);
        }


   

        public static DataTable ConvertToSitePreparationUnder(DataTable dt)
        {

            int col = 1;
            dt.Columns.Add("chkFile", typeof(byte[]));
            dt.Columns.Add("chkFileName");
            dt.Columns.Add("chkSubFile", typeof(byte[]));
            dt.Columns.Add("chkSubFileName");

            foreach (DataRow dr in dt.Rows)
            {

                if (dr["IschkFile"] != null && dr["IschkFile"].ToString() != "")
                {
                    dr["chkFileName"] = dr["IschkFile"].ToString().Equals("1") ? @"~\img\chkbox.jpg" : @"~\img\unchkbox.jpg";
                }


                if (dr["IschkSubFile"] != null && dr["IschkSubFile"].ToString() != "")
                {
                    dr["chkSubFileName"] = dr["IschkSubFile"].ToString().Equals("1") ? @"~\img\chkbox.jpg" : @"~\img\unchkbox.jpg";
                }
            }


            return dt;
        }


        public static object Parse(Type dataType, string ValueToConvert)
        {
            TypeConverter obj = TypeDescriptor.GetConverter(dataType);
            object value = ValueToConvert != null ? obj.ConvertFromString(null, CultureInfo.InvariantCulture, ValueToConvert) : null;
            return value;
        }



      

        static int GetWeekNumberOfMonth(DateTime date)
        {
            date = date.Date;
            DateTime beginningOfMonth = new DateTime(date.Year, date.Month, 1);

            while (date.Date.AddDays(1).DayOfWeek != CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek)
                date = date.AddDays(1);

            return (int)Math.Truncate((double)date.Subtract(beginningOfMonth).TotalDays / 7f) + 1;

        }

        static int GetWeekNumber4OfMonth(DateTime date)
        {
            int weekNo = 0;
            date = date.Date;

            if (date.Day >= 1 && date.Day <= 7)
            {
                weekNo = 1;
            }
            else if (date.Day >= 8 && date.Day <= 14)
            {
                weekNo = 2;
            }
            else if (date.Day >= 15 && date.Day <= 21)
            {
                weekNo = 3;
            }
            else
            {
                weekNo = 4;
            }

            return weekNo;

        }

        public static int GetMonthWeekNumberOfYear(DateTime date)
        {
            int weekNo = 0;
            date = date.Date;

            if (date.Day >= 1 && date.Day <= 7)
            {
                weekNo = 1;
            }
            else if (date.Day >= 8 && date.Day <= 14)
            {
                weekNo = 2;
            }
            else if (date.Day >= 15 && date.Day <= 21)
            {
                weekNo = 3;
            }
            else
            {
                weekNo = 4;
            }

            return ToInt(date.Year.ToString() + date.Month.ToString() + weekNo.ToString());


        }



        public static string MMddYY(string DDMMYY)
        {
            string result = "";
            try
            {

                result = string.Format("{0}/{1}/{2}", DDMMYY.Split('/')[1], DDMMYY.Split('/')[0], DDMMYY.Split('/')[2]);
            }
            catch (Exception ex)
            { }
            finally { }
            return result;

        }



        public static string DDMMYY(string MMddYY)
        {
            string result = "";

            try
            {

                result = string.Format("{0}/{1}/{2}", MMddYY.Split('/')[1], MMddYY.Split('/')[0], MMddYY.Split('/')[2]);
            }
            catch (Exception ex)
            { }
            finally { }
            return result;

        }


        public static DateTime ToDate(string MMddYY)
        {
            string result = "";
            CultureInfo us = new CultureInfo("en-US");
            DateTime stDate = new DateTime();
            try
            {

                stDate = DateTime.Parse(MMddYY, us);
            }
            catch (Exception ex)
            { }
            finally { }
            return stDate;

        }


        public static double ToDouble(object result)
        {
            double value = 0;

            try
            {

                value = Convert.ToDouble(result);
            }
            catch (Exception ex)
            { }
            finally { }
            return value;

        }



        public static int ToInt(object result)
        {
            int value = 0;

            try
            {

                value = Convert.ToInt32(result);
            }
            catch (Exception ex)
            { }
            finally { }
            return value;

        }







        public static int GetIso8601WeekOfYear(DateTime time)
        {
            // Seriously cheat.  If its Monday, Tuesday or Wednesday, then it'll 
            // be the same week# as whatever Thursday, Friday or Saturday are,
            // and we always get those right
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                time = time.AddDays(3);
            }

            // Return the week of our adjusted day
            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }

    
}
}
