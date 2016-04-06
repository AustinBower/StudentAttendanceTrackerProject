using System;
/*This class manipulates the information taken off of the student ID cards. It goes through the
string input and retrieves the student number by removing all characters not associated with the
number. Comment updated 3/25/2016.*/
namespace StudentAttendanceTracker
{

    public class StudentIDNumber
    {

        private string idNumber;
        // Returns student ID with unnecessary information removed. Comment updated 3/25/2016.   
        public string retrieveStudentId(string idInformation)
        {

            return idInformation.Substring(6,9);
             
        }// public string retrieveStudentId(string studentInput)
        public string idInformation
        {

            get
            {

                return idNumber;

            }// get
            set
            {

                idNumber = value;

            }// set

        }// public string idInformation

    }// public class StudentIDNumber

}// namespace Example