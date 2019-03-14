namespace StrategyDesignPatternInCSharp
{
    public class NoBonusStrategry : IBonusStrategy
    {
        public double Calculate(double salary)
        {
            return 0;
        }
    }
}
