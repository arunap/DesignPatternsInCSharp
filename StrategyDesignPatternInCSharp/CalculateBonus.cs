namespace StrategyDesignPatternInCSharp
{
    public class CalculateBonus
    {
        private IBonusStrategy _bonusStrategy = null;

        public CalculateBonus(IBonusStrategy bonusStrategy)
        {
            _bonusStrategy = bonusStrategy;
        }

        public double GetBonus(double salary)
        {
            return _bonusStrategy.Calculate(salary);
        }
    }

    public enum PersonType
    {
        FullTime = 1,
        Contract = 2,
        Temp = 3
    }
}
