using System;

namespace OOPEx
{
    public class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public DateOnly BirthDate { get; set; }

        public Employee(string name, string surname, string email, int phone , DateOnly birdaydate)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Phone = phone;
            BirthDate = birdaydate;
        }

        public static int Age(DateOnly birthday)
        {
            return DateTime.Now.Year - birthday.Year;
        }

    }
}
