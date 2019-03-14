namespace FactoryDesignPatternInCSharp
{
    public class HNBCreditCard : CreditCard
    {
        private readonly double _maxLimit;
        private readonly CardType _cardType;
        private readonly double _annualFee;
        public override double MaxLimit { get => _maxLimit; }
        public override double AnnualFee => _annualFee;
        public override CardType CardType => _cardType;

        public override string NameOfTheCard => "HNBCreditCard";

        public HNBCreditCard()
        {
            _maxLimit = 4500.00;
            _annualFee = 250.00;
            _cardType = CardType.Amex;
        }
    }
}
