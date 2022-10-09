using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCal
{
    public abstract class Employee
    {
        double baseSal = 1500;
        double fuelAllow; 
        double medAllow;
        public double salary;

        public double BaseSalary
        {
            get
            {
                return baseSal;
            }
        }

        public double FuelAllowance
        {
            set
            {
                fuelAllow = value;
            }
            get
            { 
                return fuelAllow; 
            }
        }

        public double MedAllowance
        {
            set
            {
                medAllow = value;
            }
            get
            {
                return medAllow;
            }
        }

        public abstract double CalSal();

    }

    public class Engineer : Employee
    {
        double annualSal = 7000;

        public override double CalSal()
        {
            FuelAllowance = 0;
            MedAllowance = 0;
            salary = (annualSal / 12) + BaseSalary + FuelAllowance + MedAllowance;

            return salary;
        }
    }

    public class Manager : Employee
    {
        double tax = 0.17;
        public override double CalSal()
        {
            FuelAllowance = 250;
            MedAllowance = 1000;
            salary = BaseSalary + FuelAllowance + MedAllowance;
            salary = salary - salary * tax;
            return salary;
        }

    }
    public class HR : Employee
    {
        double interAllowance;
        public override double CalSal()
        {
            FuelAllowance = 150;
            MedAllowance = 800;

            interAllowance = (MedAllowance + FuelAllowance) * 0.10;
            salary = BaseSalary + FuelAllowance + MedAllowance + interAllowance;

            return salary;
        }

    }
}
