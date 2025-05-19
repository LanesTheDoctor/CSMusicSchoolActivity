using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MusicSchool2
{
    public class Enrolment : IComparable<Enrolment>
    {
        // public properties
        public string FName { get; set; }
        public string LName { get; set; }
        public string DOB { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Instrument { get; set; }
        public string Course { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }

        // public parameterised constructor method
        public Enrolment(string fName, string lName, string dob,
        string phone, string email, string instrument, string course, string
        startDate, string endDate)
        {
            FName = fName;
            LName = lName;
            DOB = dob;
            Phone = phone;
            Email = email;
            Instrument = instrument;
            Course = course;
            StartDate = startDate;
            EndDate = endDate;
        }

        // public ToString() method
        // use to display in the application
        public override string ToString()
        {
            string enrolmentString = FName + "\t" + LName + "\t" +
            Instrument + "\t" + Course + "\t" + StartDate + " " +
            EndDate;
            return enrolmentString;
        }

        // returns a CSV string version of the enrolment instance data
        // used to write to the external file for saving
        public string ToCSVString()
        {
            return FName + "," + LName + "," + DOB + "," + Phone +
            "," + Email + "," + Instrument + "," + Course + "," + StartDate +
            "," + EndDate;
        } // end ToCSVString() method

        public int CompareTo(Enrolment other)
        {
            if (other == null) return 1; // null check

            return string.Compare(this.LName, other.LName, StringComparison.OrdinalIgnoreCase);
        }
    } // end class Enrolment

}

