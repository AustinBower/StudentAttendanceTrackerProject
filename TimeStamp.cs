﻿using System;
/*This creates a time stamp by */
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

        public string GetDate(DateTime Date)
        {

            Date = DateTime.Today;

            return Date.ToString();

        }//

    }// class TimeStamp
}