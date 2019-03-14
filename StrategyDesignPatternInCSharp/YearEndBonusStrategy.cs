namespace StrategyDesignPatternInCSharp
{
    public class YearEndBonusStrategy : IBonusStrategy
    {
        public double Calculate(double salary)
        {
            return salary * 20 / 100;
        }
    }
}
