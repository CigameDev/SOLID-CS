using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.src.OopPrinciples.Encapsulation
{
    public class BankAccount
    {
        private decimal balance;
        public BankAccount(decimal balance)
        {
            Deposit(balance);
        }
        public decimal GetBalance()
        {
            return balance;
        }
        public void Deposit(decimal amount)//Deposit => tien gui
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be postive");
            }
            this.balance += amount;
        }

        public void Withdraw(decimal amount)//withdraw =>rút
        {
            if(amount <= 0)
            {
                throw new ArgumentException("Withdraw amount must be postive");
            }
            if(amount > balance)
            {
                throw new InvalidOperationException("Insufficient funds");
            }
            this.balance -= amount;
        }
    }
}
