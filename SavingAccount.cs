using System;

class SavingsAccount : BankAccount
 {
   double Interest = 0;

  override public void CalculateInterest() 
 {
  Interest = Balance * 0.05;
  Balance = Interest + Balance;

  Console.WriteLine("Balance after interest is " +Balance);
 }   

 public override void Withdraw(double amount)
 {
  if(Balance < 2000)
  {
    Console.WriteLine("Insufficient balance");
  }
  else if(amount < 0)
  { 
   amount = 0;
   Console.WriteLine("Invalid number, withdraw cannot be less then 0");
  }
  else if(amount > Balance)
  {
   amount = 0; 
   Console.WriteLine("You cannot withdraw more than your current balance");
  }
  else
  {
  double NewBalanceAfterWithdraw = Balance - amount;
  Console.WriteLine("The new balance in this account is " +NewBalanceAfterWithdraw);
 }
 }
      
 }