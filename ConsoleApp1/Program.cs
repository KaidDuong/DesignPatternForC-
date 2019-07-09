using System;
using System.Collections.Generic;
using Interfaces;
using Providers;

namespace ConsoleApp1
{
    class Program
    {
       public static void Main(string[] args)
        {
            List<string> accountNumbers = new List<string> {
                "CITI-212",
                "NATION-111",
                "KAID-201"
            };
            foreach( var accountNo in accountNumbers)
            {
                ICreditUnionFactory anAbstractFactory = CreditUnionFactoryProvider.GetCreditUnionFactory(accountNo);

                if( anAbstractFactory == null) { Console.WriteLine($"Sorry.This credit union w / account numb {accountNo} is invalid"); }
                else
                {
                    ILoanAccount loan = anAbstractFactory.CreateLoanAccount();
                    ISavingsAccount savings = anAbstractFactory.CreateSavingsAccount();
                }
            }
            Console.ReadLine();
        }
    }
}
