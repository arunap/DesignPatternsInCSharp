using System;

namespace FactoryDesignPatternInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditCardFactory creditCardFactory = new CreditCardFactory();
            var bankCard = creditCardFactory.GetCreditCard(BankNames.HNB);

            Console.WriteLine(bankCard.GetCardInfo());
            Console.ReadKey();
        }
    }
}
