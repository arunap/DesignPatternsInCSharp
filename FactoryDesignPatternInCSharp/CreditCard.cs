using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPatternInCSharp
{
    public enum CardType
    {
        Visa,
        Master,
        Amex
    }

    public enum BankNames
    {
        HNB,
        Sampth,
        NSB
    }

    public abstract class CreditCard
    {
        public abstract double MaxLimit { get; }
        public abstract double AnnualFee { get; }
        public abstract CardType CardType { get; }
        public abstract string NameOfTheCard { get; }

        public virtual string GetCardInfo() { return $"{ NameOfTheCard} ==> Max limit: {MaxLimit}, Fee: {AnnualFee}, Type: {CardType}"; }
    }
}
