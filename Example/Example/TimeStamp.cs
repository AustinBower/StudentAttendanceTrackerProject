using System;
/*This class creates a time stamp of the day and time. Comment updated 3/25/2016.*/
namespace Example
{
    
    public class TimeStamp
    {

        private string refinedStringDate;
        private string date;
        // Returns the time the user swiped in using 24-hour clock time. Comment updated 3/25/2016.
        public string GetTimestamp(DateTime Date)
        {

            return Date.ToString("HH:mm:ss");

        }// public static String GetTimestamp(DateTime value)
        // Returns date the user swiped in. Comment updated 3/25/2016.
        public string GetDate(DateTime Date)
        {

            int counter = 0;
            string tempStringVariable = "";
            Date = DateTime.Today;
            try
            {

                // Removes the added time information at the end of the Date variable. Comment updated 3/25/2016.
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
                refinedStringDate = "";

            }// catch 1

            return refinedStringDate;

        }// public string GetDate(DateTime Date

    }// class TimeStamp
}