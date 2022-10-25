using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul1761;

    public class AccountBase : ICalculator
    {
    // баланс учетной записи
    public double Balance { get; set; }

    // процентная ставка
    public double Interest { get; set; }
    public void Calculate()
        {
            if (Balance < 1000)
                Interest -= Balance * 0.2;
            else
               Interest -= Balance * 0.4;
        }
    }


