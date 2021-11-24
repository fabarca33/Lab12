using System;

class CheckingAccount : BankAccount
 {
   double Interest = 0;

  override public void CalculateInterest() 
 {
  Interest = Balance * 0.005;
  Balance = Interest + Balance;

  Console.WriteLine("Balance after interest is " +Balance);
 }   


       
  }