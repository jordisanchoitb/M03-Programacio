using System;
using System.Collections.Generic;

namespace OOPEx
{
    public class Employee : IComparable<Employee>
    {
        public static int CounterEmployees { get; set; } = 0;
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Code { get; set; }
        public DateOnly BirthDate { get; set; }
        public DateOnly HireDate { get; set; }
        public float MonthSalary { get; set; }
        public int Payments { get; set; }

        public Employee(string name, string surname, string code, DateOnly birthdate, DateOnly hiredate, float monthsalary, int payments)
        {
            CounterEmployees++;
            Name = name;
            Surname = surname;
            Code = code;
            BirthDate = birthdate;
            HireDate = hiredate;
            MonthSalary = monthsalary;
            Payments = payments;
        }
        public Employee(string name, string surname, string code, DateOnly birthdate, DateOnly hiredate) : this(name, surname, code, birthdate, hiredate, 1800, 14){}

        public int Age(DateOnly birthday)
        {
            return DateTime.Now.Year - birthday.Year;
        }

        public string FullName()
        {
            return $"{this.Name} {this.Surname}";
        }

        public string ReverseFullName()
        {
            return $"{this.Surname} {this.Name}";
        }

        public int AntiquityEmployee()
        {
            return DateTime.Now.Year - HireDate.Year;
        }

        public float YearSalary()
        {
            return MonthSalary * Payments;
        }

        public override string ToString()
        {
            return "-----------------------------------------------------------------------------------------------------\n" +
                   "                          E M P L O Y E E                                                            \n" +
                   "-----------------------------------------------------------------------------------------------------\n" +
                   $">Code: {Code}\n" +
                   $">Firstname: {Name}\n" +
                   $">Last name: {Surname}\n" +
                   $">Full name: {FullName()}\n" +
                   $">Reverse name: {ReverseFullName()}\n" +
                   $">Age: {Age(BirthDate)}\n" +
                   $">Seniority: {AntiquityEmployee()}\n" +
                   $">Annual salary: {YearSalary()}\n" +
                   "-----------------------------------------------------------------------------------------------------\n";
        }

        public int CompareTo(Employee? other)
        {
            if (other == null) return 1;
            else
            {
                return this.AntiquityEmployee().CompareTo(other.AntiquityEmployee());
            }
        }
    }
}
