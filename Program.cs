using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            string emailAddress;
            int year;
            int month;
            int day;
            string chineseYear;

            // Get user's names and email address
            Console.WriteLine("Enter your first name: ");
            firstName = Console.ReadLine();

            Console.WriteLine("Enter your last name: ");
            lastName = Console.ReadLine();

            Console.WriteLine("Enter your email address: ");
            emailAddress = Console.ReadLine();


            // Get user's date of birth
            DateTime zeroTime = new DateTime(1, 1, 1);

            Console.WriteLine(DateTime.Today);
            Console.WriteLine("Enter your date of birth: ");
            

            Console.WriteLine("Enter year: ");
            year = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter month: ");
            month = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter day: ");
            day = int.Parse(Console.ReadLine());

            

            DateTime date1 = new DateTime(year, month, day);

            Person person1 = new Person(firstName, lastName, emailAddress, date1); // Parameters overload
            person1.PrintFields(); // Print out fields detail of the person

            // Calculate to find the chinese zodiac year
            chineseYear = person1.ChineseZodiac(year);
            Console.WriteLine($"You are born in the year of the {chineseYear}");

            // Check person's age
            TimeSpan span = DateTime.Now - date1;

            int years = (zeroTime + span).Year - 1;
            Console.WriteLine($"You are {years} years old.");

                if (years >= 18)
                {
                    Console.WriteLine("You are an adult!");
                }
                else if (years < 18 && years > 0)
                {
                    Console.WriteLine("Sorry you are not an adult yet!");
                }

            // Calculate birthday
            if (DateTime.Today.Month == month && DateTime.Today.Day == day)
            {
                Console.WriteLine("Today is your birthday! Happy birthday!");
            }

            // Calculate the Sun sign
            person1.WesternZodiac(month, day); 

        }
    }
}
