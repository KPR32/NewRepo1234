using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exam1.Models
{
    public class Harmfulness : Department
    {
       public int P { get; set; }

        public Harmfulness(string name, decimal base_salary, double coefficient, int p):base(name,base_salary, coefficient) 
        { 
            this.P = p;
        }

       public decimal HarmfulnessQ()
        {
            return base.QualityQ() + base.QualityQ() / P;
        }

        public override decimal QualityQ()
        {
            return  base.QualityQ() + base.QualityQ() / P;
        }
    }
}
