using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEx
{
    public class HourlyWorker : AWorker
    {
        public int HoursWorked { get; set; }

        public HourlyWorker(string name, double salary_rate, int hoursWorked) : base(name, salary_rate)
        {
            HoursWorked = hoursWorked;
        }
        public override double computePay()
        {
            return GetSalaryRate() * HoursWorked;
        }
    }
}
