using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorAppointment
{
    public static partial class AppointmentManager
    {
        public static void DefaultDetails()
        {
            Doctor doctor1 = new Doctor (1,"Nancy","Anaesthesiology");
            Doctor doctor2 = new Doctor (2,"Andrew","Cardiology");
            Doctor doctor3 = new Doctor (3,"Janet","Diabetology");
            Doctor doctor4 = new Doctor (4,"Margaret","Neonatology");
            Doctor doctor5 = new Doctor (5,"Steven","Nephrology");
            doctorsList.AddRange(new List<Doctor>{doctor1,doctor2,doctor3,doctor4,doctor5});


            Patient patient1 = new Patient("Robert","welcome",40,Gender.Male);
            Patient patient2 = new Patient("Laura","welcome",36,Gender.Female);
            Patient patient3 = new Patient("Anne","welcome",42,Gender.Female);
            patientList.AddRange(new List<Patient>{patient1,patient2,patient3});


            Appoinment appoinment1 = new Appoinment(1,2,new DateTime(2012,8,3),"Heart problem");
            Appoinment appoinment2 = new Appoinment(1,5,new DateTime(2012,8,3),"Spinal cord injury");
            Appoinment appoinment3 = new Appoinment(2,2,new DateTime(2012,8,3),"Heart attack");
            appoinmentList.AddRange(new List<Appoinment>{appoinment1,appoinment2,appoinment3});
        }
    }
}