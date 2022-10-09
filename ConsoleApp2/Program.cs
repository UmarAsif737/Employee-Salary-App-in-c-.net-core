using SalaryCal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static Employee Prof(string prof)
        {
            if (prof == "Manager")
            {
                return new Manager();
            }
            else if (prof == "Engineer")
            {
                return new Engineer();
            }
            else
            {
                return new HR();
            }


        }
        static void Main(string[] args)
        {
            Console.WriteLine("What's you proffesion: \n Engineer \n Manager \n HR");
            string prof = Console.ReadLine();

            Employee employee = Prof(prof);

            Console.WriteLine("\nThe monthly salary of a " + prof + " is $" + employee.CalSal());

            Console.ReadLine();
        }
    }
}
