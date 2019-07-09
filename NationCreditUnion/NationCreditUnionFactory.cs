using Interfaces;

namespace NationCreditUnion
{
    //Concrete Abstract Factory 2
    public class NationCreditUnionFactory : ICreditUnionFactory
    {
        public override ILoanAccount CreateLoanAccount() => new NationLoanAccount();

        public override ISavingsAccount CreateSavingsAccount() => new NationSavingsAccount();
    }
}