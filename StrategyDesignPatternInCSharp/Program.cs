using System;

namespace StrategyDesignPatternInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double basicSalary = 1000;
            double bonusAmount = 0;
            CalculateBonus calculateBonus = null;

            PersonType type = PersonType.FullTime;

            switch (type)
            {
                case PersonType.FullTime:
                    calculateBonus = new CalculateBonus(new YearEndBonusStrategy());
                    bonusAmount = calculateBonus.GetBonus(basicSalary);
                    break;
                case PersonType.Contract:
                    calculateBonus = new CalculateBonus(new MidYearBonusStrategy());
                    bonusAmount = calculateBonus.GetBonus(basicSalary);
                    break;
                case PersonType.Temp:
                    calculateBonus = new CalculateBonus(new NoBonusStrategry());
                    bonusAmount = calculateBonus.GetBonus(basicSalary);
                    break;
                default:
                    break;
            }

            Console.WriteLine(string.Format("Bonus Amount for {0} employee is: {1} for: {2}", type.ToString(), bonusAmount, basicSalary));
            Console.ReadKey();
        }
    }
}
