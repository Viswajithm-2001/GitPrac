using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorAppointment
{
    public enum Gender {Select, Male, Female}
    public class Patient
    {

        //field
        private static int s_patientID = 0;

        //properties
        public int PatientID {get;}
        public string Password {get;set;}
        public string Name {get;set;}
        public int Age {get;set;}
        public Gender Gender {get;set;}

        public Patient(string name,string password,int age,Gender gender)
        {
            PatientID = ++s_patientID;
            Name= name;
            Age=age;
            Gender = gender;
            Password = password;
        }

    }
}