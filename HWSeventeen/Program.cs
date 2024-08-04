using HWSeventeen.Classes;
using HWSeventeen.Interfaces;

namespace HWSeventeen
{
    internal class Program
    {
        static ICalculator _calculator;
        static void Main(string[] args)
        {
            _calculator.CalculateInterest(new OrdinaryAccount());

            _calculator.CalculateInterest(new SalaryAccount());
        }
    }
}
