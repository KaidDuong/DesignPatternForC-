using Interfaces;
using System;

namespace NationCreditUnion
{
    //Product A2
    public class NationLoanAccount : ILoanAccount
    {
        public NationLoanAccount() => Console.WriteLine("Return Nation loan account");
    }
}