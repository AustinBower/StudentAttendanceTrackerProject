using System;
namespace Example
{

    public class TimeStamp
    {

        private string date;
        public string GetTimestamp(DateTime Date)
        {

            return Date.ToString("HH:mm:ss");

        }// public static String GetTimestamp(DateTime value)
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

}// namespace Example