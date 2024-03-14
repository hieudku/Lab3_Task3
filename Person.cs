using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Task3
{
    internal class Person
    {
        private string firstName;
        private string lastName;
        private string emailAddress;
        private DateTime dateOfBirth;

        public string FirstName { 
            get => firstName; 
            set => firstName = value; 
        }
        public DateTime DOB
        {
            get
            {
                return dateOfBirth;
            }
        }

        public string LastName { get => lastName;}
        public string Email { get => emailAddress; }

        public Person(string fName, string lName, string email, DateTime dOB)
        {
            firstName = fName;
            lastName = lName;
            emailAddress = email;
            dateOfBirth = dOB;
        }
        public Person (string fName, string lName, string email)
        {
            firstName = fName;
            lastName = lName;
            emailAddress = email;
        }
        public Person(string fName, string lName, DateTime dOB)
        {
            firstName = fName;
            lastName = lName;
            dateOfBirth = dOB;
        }
        public void printFields()
        {
            Console.WriteLine($"Your detail: {firstName} {lastName} {emailAddress} {dateOfBirth}");
        }
        public void chineseZodiac(int year)
        {
            // Calculate the Chinese zodiac
            switch ((year - 4) % 12)
            {
                case 0:
                    Console.WriteLine("Your Chinese zodiac is Rat");
                    break;
                case 1:
                    Console.WriteLine("Your Chinese zodiac is Ox");
                    break;
                case 2:
                    Console.WriteLine("Your Chinese zodiac is Tiger");
                    break;
                case 3:
                    Console.WriteLine("Your Chinese zodiac is Rabbit");
                    break;
                case 4:
                    Console.WriteLine("Your Chinese zodiac is Dragon");
                    break;
                case 5:
                    Console.WriteLine("Your Chinese zodiac is Snake");
                    break;
                case 6:
                    Console.WriteLine("Your Chinese zodiac is Horse");
                    break;
                case 7:
                    Console.WriteLine("Your Chinese zodiac is Goat");
                    break;
                case 8:
                    Console.WriteLine("Your Chinese zodiac is Monkey");
                    break;
                case 9:
                    Console.WriteLine("Your Chinese zodiac is Rooster");
                    break;
                case 10:
                    Console.WriteLine("Your Chinese zodiac is Dog");
                    break;
                case 11:
                    Console.WriteLine("Your Chinese zodiac is Pig");
                    break;
            }
        }
        public void westernZodiac(int month, int day)
        {

        }
    }
}
