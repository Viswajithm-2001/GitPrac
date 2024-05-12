using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorAppointment
{
    public class Doctor
    {
        public int appoinmentCount = 0;
        
        public int DoctorID {get;set;}
        public string DoctorName {get; set;}
        public string Department {get;set;}
        public Doctor(int doctorID, string doctorName, string department)
        {
            DoctorID = doctorID;
            DoctorName = doctorName;
            Department = department;
        }
    }
}