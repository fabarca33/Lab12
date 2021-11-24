using System;
 
abstract class BankAccount
{
 public string AcctNbr { get; set; }
 public string Name { get; set; }
 public double Balance { get; set; }
 public DateTime DateCreated { get; set; }
 public double amount {get; set;}

 public BankAccount():this(1000)
 {
 }
 public BankAccount(double balance)
 {
  Balance = balance;
 }

 public void Deposit(double amount)
 {
  if(amount < 0)
  { 
    amount = 0;
    Console.WriteLine("Invalid number, deposit cannot be less then 0");
  }
  else
  {
    double NewBalanceAfterDeposit = Balance + amount;
    Console.WriteLine("The new balance in this account is " +NewBalanceAfterDeposit);
    Balance = NewBalanceAfterDeposit;
  }
  
 }

 public virtual void Withdraw(double amount)
 {
  if(amount < 0)
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

 public abstract void CalculateInterest();

 }