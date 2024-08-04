using HWSeventeen.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace HWSeventeen.Interfaces
{
    public interface ICalculator
    {
        void CalculateInterest(Account account);
    }
}
