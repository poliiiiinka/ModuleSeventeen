using HWSeventeen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace HWSeventeen.Classes
{
    public class SalaryAccount : Account, ICalculator
    {
        public void CalculateInterest(Account salaryAccount)
        {
            Console.WriteLine("Реализация зарплатного счёта");

            salaryAccount.Interest = salaryAccount.Balance * 0.5;
        }
    }
}
