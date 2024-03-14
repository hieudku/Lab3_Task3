using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3_Task3;
namespace Lab3_Task3
{
    internal class Person
    {
        private readonly string firstName;
        private readonly string lastName;
        private readonly string emailAddress;
        private readonly DateTime dateOfBirth;

        public string FirstName { 
            get => firstName; 
            
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
        public void PrintFields()
        {
            Console.WriteLine($"Your full name: {firstName} {lastName}");
            Console.WriteLine($"Your email address: {emailAddress}");
            Console.WriteLine($"Your date of birth: {dateOfBirth}");
        }
        public string ChineseZodiac(int year)
        {
            string chineseYear = "";
            // Calculate the Chinese zodiac
            switch ((year - 4) % 12)
            {
                
                case 0:
                    chineseYear = "Rat";
                    break;
                case 1:
                    chineseYear = "Ox";
                    break;
                case 2:
                    chineseYear = "Tiger";
                    break;
                case 3:
                    chineseYear = "Rabbit";
                    break;
                case 4:
                    chineseYear = "Dragon";
                    break;
                case 5:
                    chineseYear = "Snake";
                    break;
                case 6:
                    chineseYear = "Horse";
                    break;
                case 7:
                    chineseYear = "Goat";
                    break;
                case 8:
                    chineseYear = "Monkey";
                    break;
                case 9:
                    chineseYear = "Rooster";
                    break;
                case 10:
                    chineseYear = "Dog";
                    break;
                case 11:
                    chineseYear = "Pig";
                    break;
            }
            return chineseYear;
        }
        public void WesternZodiac(int month, int day)
        {
            if (month == 12)
            {

                if (day < 22)
                    Console.WriteLine("Sagittarius");
                else
                    Console.WriteLine("Capricorn");
            }

            else if (month == 1)
            {
                if (day < 20)
                    Console.WriteLine("Capricorn");
                else
                    Console.WriteLine("Aquarius");
            }

            else if (month == 2)
            {
                if (day < 19)
                    Console.WriteLine("Aquarius");
                else
                    Console.WriteLine("Pisces");
            }

            else if (month == 3)
            {
                if (day < 21)
                    Console.WriteLine("Pisces");
                else
                    Console.WriteLine("Aries");
            }
            else if (month == 4)
            {
                if (day < 20)
                    Console.WriteLine("Aries");
                else
                    Console.WriteLine("Taurus");
            }

            else if (month == 5)
            {
                if (day < 21)
                    Console.WriteLine("Taurus");
                else
                    Console.WriteLine("Gemini");
            }

            else if (month == 6)
            {
                if (day < 21)
                    Console.WriteLine("Gemini");
                else
                    Console.WriteLine("Cancer");
            }

            else if (month == 7)
            {
                if (day < 23)
                    Console.WriteLine("Cancer"); 
                else
                    Console.WriteLine("Leo");
            }

            else if (month == 8)
            {
                if (day < 23)
                    Console.WriteLine("Leo");
                else
                    Console.WriteLine("Virgo");
            }

            else if (month == 9)
            {
                if (day < 23)
                    Console.WriteLine("Virgo");
                else
                    Console.WriteLine("Libra");
            }

            else if (month == 10)
            {
                if (day < 23)
                    Console.WriteLine("Libra");
                else
                    Console.WriteLine("Scorpio");
            }

            else if (month == 11)
            {
                if (day < 22)
                    Console.WriteLine("Scorpio");
                else
                    Console.WriteLine("Sagittarius");
            }
        }
    }
}
