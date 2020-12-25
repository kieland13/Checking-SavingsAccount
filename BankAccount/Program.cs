using System;

namespace BankAccount
{
   class Program
   {
      static void Main(string[] args)
      {
         try
         {
            decimal credit = 12.4M;

            //checked with negative and positive amounts for starting account and interest rate
            //right message appeared
            SavingsAccount sa = new SavingsAccount(1500.00M, .06M);
            Console.WriteLine(sa);

            //interest was correctly calculated
            credit = sa.CalculateInterest();
            Console.WriteLine("Total interest: $" + Math.Round(credit,2));
            
            //it correctly added money to account
            //checked with negative and positive amount
            sa.Credit(credit);
            Console.WriteLine("$" + Math.Round(sa.AccountBalance,2));

            //it correctly subtracted money to account
            //checked with positive and negative amount
            decimal debit = 1000M;
            sa.Debit(debit);
            Console.WriteLine(sa);

            CheckingAccount ca = new CheckingAccount(2000M, 4.95M);
            Console.WriteLine(ca);
            
            //checked with positive and negative number, right exception message and math appeared
            decimal checkingCredit = 50M;
            ca.Credit(checkingCredit);
            Console.WriteLine(ca);

            //checked with both positive number and negative number, right exception message and math appeared
            //checked with overdrafting account, right message appeared
            decimal checkingDebit = 50M;
            ca.Debit(checkingDebit);
            Console.WriteLine(ca);
            
         }
         catch (ArgumentOutOfRangeException ex)
         {
            Console.WriteLine(ex.Message);
         }
         Console.ReadKey();
      }
   }
}
