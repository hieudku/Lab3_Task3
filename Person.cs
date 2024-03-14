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
            if (month == 12)
            {

                if (day < 22)
                    Console.WriteLine("Sagittarius");
                else
                    Console.WriteLine("capricorn");
            }

            else if (month == 1)
            {
                if (day < 20)
                    Console.WriteLine("Capricorn");
                else
                    Console.WriteLine("aquarius");
            }

            else if (month == 2)
            {
                if (day < 19)
                    Console.WriteLine("Aquarius");
                else
                    Console.WriteLine("pisces");
            }

            else if (month == 3)
            {
                if (day < 21)
                    Console.WriteLine("Pisces");
                else
                    Console.WriteLine("aries");
            }
            else if (month == 4)
            {
                if (day < 20)
                    Console.WriteLine("Aries");
                else
                    Console.WriteLine("taurus");
            }

            else if (month == 5)
            {
                if (day < 21)
                    Console.WriteLine("Taurus");
                else
                    Console.WriteLine("gemini");
            }

            else if (month == 6)
            {
                if (day < 21)
                    Console.WriteLine("Gemini");
                else
                    Console.WriteLine("cancer");
            }

            else if (month == 7)
            {
                if (day < 23)
                    Console.WriteLine("Cancer"); 
                else
                    Console.WriteLine("leo");
            }

            else if (month == 8)
            {
                if (day < 23)
                    Console.WriteLine("Leo");
                else
                    Console.WriteLine("virgo");
            }

            else if (month == 9)
            {
                if (day < 23)
                    Console.WriteLine("Virgo");
                else
                    Console.WriteLine("libra");
            }

            else if (month == 10)
            {
                if (day < 23)
                    Console.WriteLine("Libra");
                else
                    Console.WriteLine("scorpio");
            }

            else if (month == 11)
            {
                if (day < 22)
                    Console.WriteLine("scorpio");
                else
                    Console.WriteLine("sagittarius");
            }
        }
    }
}
