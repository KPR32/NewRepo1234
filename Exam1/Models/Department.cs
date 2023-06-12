using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1.Models
{
    public class Department
    {
        public string Name { get; set; }  
        
        public decimal Basе_salary { get; set; }

        public double Coefficient { get; set; }

        public Department(string Name, decimal Base_salary, double Coefficient)
        {
            this.Name = Name;
            this.Basе_salary = Base_salary;
            this.Coefficient = Coefficient;
        }

        public virtual decimal QualityQ()
        {
            return Basе_salary * (100 + (decimal)Coefficient);
        }
    }
}
