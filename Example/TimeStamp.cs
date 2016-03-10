using System;
/*This creates a time stamp of the day and time.*/
namespace Example
{
    public class TimeStamp
    {

        private string refinedStringDate;
        private string date;
        public string GetTimestamp(DateTime Date)
        {

            return Date.ToString("HH:mm:ss");

        }// public static String GetTimestamp(DateTime value)
        public string GetDate(DateTime Date)
        {

            int counter = 0;
            string tempStringVariable = "";
            Date = DateTime.Today;
            try
            {

                while (Date.ToString().Substring(counter, 1) != " ")
                {

                    refinedStringDate = tempStringVariable + Date.ToString().Substring(counter, 1);
                    tempStringVariable = refinedStringDate;
                    counter++;

                }// while (Date.ToString().Substring(counter, 1) != " ")

            }// try 1
            catch
            {

                Console.WriteLine("Error date counter exceeded string length!");

            }// catch 1

            return refinedStringDate;

        }// public string GetDate(DateTime Date)
        public string Date
        {

            get
            {

                return date;

            }// get
            set
            {

                date = value;

            }// set

        }// public string Date

    }// class TimeStamp
}