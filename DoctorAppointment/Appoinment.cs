using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorAppointment
{
    public class Appoinment
    {
        private static int s_appointment = 1;
        public int AppoinmentID {get;}
        public int PatientID {get;}
        public int DoctorID {get;set;}
        public DateTime Date {get;set;}
        public string Problem {get;set;}

        public Appoinment(int patientID,int doctorID,DateTime date,string problem)
        {
            AppoinmentID = s_appointment++;
            DoctorID = doctorID;
            PatientID = patientID;
            Date = date;
            Problem = problem;

        }
    }
}