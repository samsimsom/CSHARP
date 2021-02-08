using System;
using static System.Console;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account("Jane Green", 50.00m);
            Account account2 = new Account("Harry Potter", -7.52m);

            WriteLine($"{account1.Name}'s balance: {account1.Balance}");
            WriteLine($"{account2.Name}'s balance: {account2.Balance}");
            
            Write("\nEnter deposit amount for account1: ");
            decimal depositAmount = decimal.Parse(ReadLine());
            WriteLine($"adding {depositAmount:C} to account1 balance \n");
            account1.Deposit(depositAmount);
            
            
            WriteLine($"{account1.Name}'s balance: {account1.Balance}");
            WriteLine($"{account2.Name}'s balance: {account2.Balance}");
            
            Write("\nEnter deposit amount for account2: ");
            depositAmount = decimal.Parse(ReadLine());
            WriteLine($"adding {depositAmount:C} to account2 balance\n");
            account2.Deposit(depositAmount);
            
            WriteLine($"{account1.Name}'s balance: {account1.Balance}");
            WriteLine($"{account2.Name}'s balance: {account2.Balance}");
        }
    }
}