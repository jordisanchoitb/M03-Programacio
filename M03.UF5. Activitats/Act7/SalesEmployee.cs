using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEx
{
    public class SalesEmployee : Employee
    {
        public float Comission { get; set; }

        public SalesEmployee(string name, string surname, string code, DateOnly birthdate, DateOnly hiredate, float comission, float monthsalary, int payments) : base(name, surname, code, birthdate, hiredate, monthsalary, payments)
        {
            Comission = comission;
        }
        public SalesEmployee(string name, string surname, string code, DateOnly birthdate, DateOnly hiredate, float comission) : base(name, surname, code, birthdate, hiredate)
        {
            Comission = comission;
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
                   $">Comission: {Comission}\n" +
                   "-----------------------------------------------------------------------------------------------------\n";
        }

    }
}
