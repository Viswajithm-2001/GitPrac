using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorAppointment
{
     public delegate string MyDel(string str);

    public static partial class AppointmentManager
    {
        public static event MyDel MyEvent;
        
        
        static void SubMenu()
        {
            string choice = "no";
            do
            {
                System.Console.WriteLine("Select \n1.Book Appoinment\n2. View Appointment details \n3. Edit my profile\n4. Exit");
                Console.Write("Your choice : ");
                string menuChoice = Console.ReadLine();
                switch (menuChoice)
                {
                    case "1":
                        {
                            BookAppointment();
                            break;

                        }
                    case "2":
                        {
                            ViewAppointmentDetails();
                            break;

                        }
                    case "3":
                        {
                            EditMyProfile();
                            break;

                        }
                    case "4":
                        {
                            System.Console.WriteLine("Do you want to exit (yes/no): ");
                            choice = Console.ReadLine();
                            break;

                        }
                    default:
                        {
                            System.Console.WriteLine("Enter valid Choice !");
                            break;
                        }
                }
            } while (!choice.Equals("yes"));
            System.Console.WriteLine("Thank You !");
        }
        public static string AppointmentMessage()
        {
            return "Appointment Added Successfully ! ";
        }

        static Doctor doc;
        static string AppointmentAdded(string str)
        {
            return str;
        }
        static void Subscribe()
        {
            MyEvent += new MyDel(AppointmentAdded);
        }
        static void BookAppointment()
        {
            System.Console.WriteLine("You are now Booking an Appointment");
            System.Console.WriteLine("Select the department");
            System.Console.WriteLine("1. Anaesthesiology\n2. Cardiology\n3. Diabetology\n4. Neonatology\n5. Nephrology");
            System.Console.Write("Enter Your Choice : ");
            string dept = "";
            string choice = Console.ReadLine();
            bool validChoice = false;
            switch (choice)
            {
                case "1":
                    {
                        dept = "Anaesthesiology";
                        validChoice = true;
                        break;
                    }
                case "2":
                    {
                        dept = "Cardiology";
                        validChoice = true;
                        break;
                    }
                case "3":
                    {
                        dept = "Diabetology";
                        validChoice = true;
                        break;
                    }
                case "4":
                    {
                        dept = "Neonatology";
                        validChoice = true;
                        break;
                    }
                case "5":
                    {
                        dept = "Nephrology";
                        validChoice = true;
                        break;
                    }
                default:
                    {
                        System.Console.WriteLine("Invalid Choice");
                        break;
                    }
            }
            if (validChoice)
            {

                foreach (Doctor doctor in doctorsList)
                {
                    if (doctor.Department.Equals(dept))
                    {
                        doc = doctor;
                        break;
                    }
                }
                if (doc.appoinmentCount <= 2)
                {
                    System.Console.Write("Enter your Problem : ");
                    string problem = Console.ReadLine();
                    DateTime date = DateTime.Now;
                    System.Console.WriteLine($"Appointment is confirmed for the date - {date.ToString("MM/dd/yyyy")}. To book press “Y”, to cancel press “N”");
                    string ch = Console.ReadLine();
                    if (ch.ToUpper().Equals("Y"))
                    {
                        Appoinment appoinment = new Appoinment(currentLoggedInPatient.PatientID, doc.DoctorID, DateTime.Now, problem);
                        appoinmentList.Add(appoinment);
                        Subscribe();
                        string message = AppointmentManager.MyEvent?.Invoke("Appoinment Added Successfully !");
                        System.Console.WriteLine(message);

                    }
                    System.Console.WriteLine("Thank you !");
                }
                else
                {
                    System.Console.WriteLine("Doctor is available for current date...");
                }
            }
        }
        static void ViewAppointmentDetails()
        {
            int count = 0;
            foreach (Appoinment appoinment in appoinmentList)
            {
                count += 1;
            }
            if (count > 0)
            {
                System.Console.WriteLine("---------------------------------------");
                System.Console.WriteLine("Appointment ID\tPatient ID\tDoctor ID\tDate\t\tProblem");
                foreach (Appoinment appoinment in appoinmentList)
                {
                    if (appoinment.PatientID == currentLoggedInPatient.PatientID)
                    {
                        System.Console.WriteLine($"{appoinment.AppoinmentID,12}{appoinment.PatientID,12}{appoinment.DoctorID,15}{appoinment.Date.ToString("MM/dd/yyyy"),18}{appoinment.Problem,22}");
                    }
                }
            }
        }
        static void EditMyProfile()
        {
            System.Console.WriteLine("You are now editing your profile...");
            System.Console.WriteLine("To Update...");
            System.Console.Write("Enter your Name : ");
            string newName = Console.ReadLine();
            System.Console.Write("Enter New Password : ");
            string newPwd = Console.ReadLine();
            System.Console.WriteLine("Enter your new Age : ");
            int newAge = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter Your Gender (male/female): ");
            Gender gend = Enum.Parse<Gender>(Console.ReadLine(), true);
            foreach (Patient patient in patientList)
            {
                if (currentLoggedInPatient.PatientID == patient.PatientID)
                {
                    patient.Name = newName;
                    patient.Password = newPwd;
                    patient.Age = newAge;
                    patient.Gender = gend;
                    System.Console.WriteLine("Edited Successfully !");
                    break;
                }
            }

        }
    }
}