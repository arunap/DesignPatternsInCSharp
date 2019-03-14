using System;

namespace FactoryDesignPatternInCSharp
{
    public class CreditCardFactory : ICreditCardFactory
    {
        public CreditCard GetCreditCard(BankNames bankNames)
        {
            switch (bankNames)
            {
                case BankNames.HNB:
                    return new HNBCreditCard();
                case BankNames.Sampth:
                    return new SampathCreditCard();
                case BankNames.NSB:
                    return new NSBCreditCard();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
