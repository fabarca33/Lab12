using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");

  SavingsAccount s1 = new SavingsAccount();
  s1.Deposit(2000);
  s1.Withdraw(5000);
  s1.CalculateInterest();
  s1.Withdraw(500);

  CheckingAccount c1 = new CheckingAccount();
  c1.Deposit(2000);
  c1.Withdraw(5000);
  c1.CalculateInterest();
  c1.Withdraw(500);

    /*Test case 1
             * Create a savingsaccount object
             * Deposit $2000
             * Withdraw $5000
             * Calculate interest
             * Withdraw $500
            */

            /*Test case 2
            * Create a checkingaccount object
            * Deposit $2000
            * Withdraw $5000
            * Calculate interest
            * Withdraw $500
           */

  }
}