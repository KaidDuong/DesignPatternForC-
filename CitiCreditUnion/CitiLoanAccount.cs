using Interfaces;
using System;

namespace CitiCreditUnion
{
    //Product A1
    public class CitiLoanAccount : ILoanAccount
    {
        public CitiLoanAccount() =>Console.WriteLine(" Return citi loan account");
    }
}