using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorAppointment
{
    public static partial class AppointmentManager
    {
        static Patient currentLoggedInPatient;
        public static void MainMenu()
        {
            string mChoice = "no";
            do
            {
                System.Console.WriteLine("_________________________________________________");
                System.Console.WriteLine("Welcome to Online Doctor Appointment");
                System.Console.WriteLine("MainMenu....");
                System.Console.WriteLine("Select 1. Login\t2. Register\t3. Exit");
                Console.Write("Your Choice : ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Login();
                            break;
                        }
                    case 2:
                        {
                            Register();
                            break;
                        }
                    case 3:
                        {
                            System.Console.Write("Do you want to exit (yes/no): ");
                            mChoice = Console.ReadLine();
                            break;
                        }
                    default:
                        {
                            System.Console.WriteLine("Enter Valid Choice !");
                            break;
                        }
                }


            } while (!mChoice.Equals("yes"));
        }
        static void Login()
        {
            System.Console.WriteLine("Welcome To Login Page....");
            System.Console.WriteLine("Please enter your Credentials");
            System.Console.Write("Enter your UserName : ");
            string name = Console.ReadLine();
            System.Console.Write("Enter your Password : ");
            string password = Console.ReadLine();
            bool flag = true;
            foreach(Patient patient in patientList){
                if(patient.Name.Equals(name)){
                    if(patient.Password.Equals(password)){
                        System.Console.WriteLine("You have successfully Logged In ! ");
                        flag=false;
                        currentLoggedInPatient = patient;
                        SubMenu();
                    }
                    else
                    {
                        System.Console.WriteLine("Invalid Password !");
                    }
                }
            };
            if(flag)
            {
                System.Console.WriteLine("Sorry, your record is invalid. Please register your profile and log in again.");
            }
        }
        static void Register()
        {
            System.Console.WriteLine("Welcome to Registration...");
            System.Console.WriteLine("Please enter the following details...");
            System.Console.Write("Enter Your Name : ");
            string name = Console.ReadLine();
            System.Console.Write("Enter your Password : ");
            string pwd = Console.ReadLine();
            System.Console.Write("Enter Your Age : ");
            int age = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Please enter your gender (Male/female) : ");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(),true);
            Patient patient = new Patient(name,pwd,age,gender);
            patientList.Add(patient);
            System.Console.WriteLine("Patient Added Successfully ! ");
        }
    }
}