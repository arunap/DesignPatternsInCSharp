using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPatternInCSharp
{
    public class MidYearBonusStrategy : IBonusStrategy
    {
        public double Calculate(double salary)
        {
            return salary * 7 / 100;
        }
    }
}
