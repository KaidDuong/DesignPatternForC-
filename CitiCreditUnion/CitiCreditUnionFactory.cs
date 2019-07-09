using Interfaces;
using System;

namespace CitiCreditUnion
{
    //Concrete abstract factory 1
    public class CitiCreditUnionFactory : ICreditUnionFactory
    {
        public override ILoanAccount CreateLoanAccount() => new CitiLoanAccount();


        public override ISavingsAccount CreateSavingsAccount() => new CitiSavingsAccount();
        
    }
    
}