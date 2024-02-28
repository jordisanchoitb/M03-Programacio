using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEx
{
    public abstract class AWorker
    {
        private string name;
        private double salary_rate;
        public AWorker(string name, double salary_rate)
        {
            this.name = name;
            this.salary_rate = salary_rate;
        }
        public string GetName()
        {
            return name;
        }
        public double GetSalaryRate()
        {
            return salary_rate;
        }
        public abstract double computePay();
    }
}
