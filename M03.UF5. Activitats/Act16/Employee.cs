using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEx
{
    public class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string DNI { get; set; }

        public Employee(string name, string surname, string dNI)
        {
            Name = name;
            Surname = surname;
            DNI = dNI;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("");
            sb.AppendLine($"Name {this.Name}");
            sb.AppendLine($"Surname {this.Surname}");
            sb.AppendLine($"DNI {this.DNI}");
            return sb.ToString();
        }
    }

    public class Administrators : Employee
    {
        public string Department { get; set; }
        public string Role { get; set; }

        public Administrators(string name, string surname, string dNI, string department, string role) : base(name, surname, dNI)
        {
            Department = department;
            Role = role;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
            sb.AppendLine($"Department {this.Department}");
            sb.AppendLine($"Role {this.Role}");
            return sb.ToString();
        }
    }
}
