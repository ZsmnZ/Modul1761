using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1761
{
    public class AccountSalary : ICalculator
    {
        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest = 2;
        public AccountSalary(double balance)
        {
            Balance = balance;
        }
        public void CalculateInterest()
        {
            Interest = Balance * 0.5;
            Console.WriteLine(Interest);
        }
    }
}
