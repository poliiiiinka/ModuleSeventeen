using HWSeventeen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace HWSeventeen.Classes
{
    public class OrdinaryAccount : Account, ICalculator
    {
        public void CalculateInterest(Account ordinaryAccount)
        {
            Console.WriteLine("Реализация обычного счёта");

            ordinaryAccount.Interest = ordinaryAccount.Balance * 0.4;

            if (ordinaryAccount.Balance < 1000)
                ordinaryAccount.Interest -= ordinaryAccount.Balance * 0.2;

            if (ordinaryAccount.Balance >= 1000)
                ordinaryAccount.Interest -= ordinaryAccount.Balance * 0.4;
        }
    }
}
