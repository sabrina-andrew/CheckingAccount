using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{
    public class CheckingAccount
    {
        public decimal Balance { get; set; }

        public void Deposit(decimal amount)
        {
            Balance = Balance + amount;
            // Or Balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            Balance = Balance - amount;
            //Shortcut! Could also be Balance -= amount;
        }
    }
}
