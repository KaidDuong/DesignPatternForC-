using Interfaces;
using System;

namespace CitiCreditUnion
{
    //Product A2
    public class CitiSavingsAccount : ISavingsAccount
    {
       public CitiSavingsAccount()=> Console.WriteLine("Return citi savings account");
    }
}