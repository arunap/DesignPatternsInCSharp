namespace FactoryDesignPatternInCSharp
{
    public interface ICreditCardFactory
    {
        CreditCard GetCreditCard(BankNames bankNames);
    }
}
