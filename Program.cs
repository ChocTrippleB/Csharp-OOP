using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        public class Person
        {
            public string Name;
            public int StudentNumber;
            public string Institution; public string City;
            public string Region;
            public string Country;


            public void Details()
            {
                Console.Clear();
                Console.WriteLine("Student Details \n\nName: " + Name + "\nStudent number: " + 
                                    StudentNumber + "\nInstitution: " + Institution
                                    + "\nCity: " + City + "\nRegion: " + Region + "\nCountry: " + Country);
            }
        }
        static void Main(string[] args)
        {
            Person person = new Person();

            Console.Write("What is your name: ");
            person.Name = Console.ReadLine();
            Console.Write("Enter your student number: ");
            person.StudentNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the name of your institution: ");
            person.Institution = Console.ReadLine();
            Console.Write("Enter the name of the city: ");
            person.City = Console.ReadLine();
            Console.Write("Enter your region: ");
            person.Region = Console.ReadLine();
            Console.Write("From which country are you from?: ");
            person.Country = Console.ReadLine();

            person.Details();

            Console.ReadKey();
        }
    }
}
