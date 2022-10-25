using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1761
{
   public class CalculatorInterest
   {
        public string Types { get;set; }
       
        ICalculator Calc { get; set; }
        public CalculatorInterest(string types, ICalculator calc)
        {
            Types = types;
            Calc = calc;
        }
        public void CalculateInterest()
        {
            Calc.Calculate();
        }

   }
}
