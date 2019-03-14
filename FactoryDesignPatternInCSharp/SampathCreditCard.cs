namespace FactoryDesignPatternInCSharp
{
    public class SampathCreditCard : CreditCard
    {
        private readonly double _maxLimit;
        private readonly CardType _cardType;
        private readonly double _annualFee;
        public override double MaxLimit { get => _maxLimit; }
        public override double AnnualFee => _annualFee;
        public override CardType CardType => _cardType;

        public override string NameOfTheCard => "SampathCreditCard";

        public SampathCreditCard()
        {
            _maxLimit = 5000.00;
            _annualFee = 150.00;
            _cardType = CardType.Visa;
        }
    }
}
