using System;
/*This class manipulates the information taken off of the student ID cards. It goes through the
string input and retrieves the student number by removing all characters not associated with the
number.*/
namespace Example
{

    public class StudentIDNumber
    {

        private string idNumber;    
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