using CitiCreditUnion;
using Interfaces;
using NationCreditUnion;

namespace Providers
{
    public class CreditUnionFactoryProvider
    {
        public static ICreditUnionFactory GetCreditUnionFactory(string accountNo)
        {
            if (accountNo.Contains("CITI")) { return new CitiCreditUnionFactory(); }
            else if (accountNo.Contains("NATION")) { return new NationCreditUnionFactory(); }
            else { return null; }
        }
    }
}