using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_OPP_Github
{
    public class BankAccount
    {
        // Fältet för att lagra kontobalansen
        private int balance;

        // Konstruktor för att initiera kontot med ett startbelopp
        public BankAccount(int Balance)
        {
            // Sätt kontobalansen till det angivna startbeloppet
            balance = Balance;
        }

        // Metod för att sätta in pengar på kontot
        public void Deposit(int amount)
        {
            // Addera beloppet inom parantereserna till kontobalansen
            balance += amount;
        }

        // Metod för att ta ut pengar från kontot
        public void Withdraw(int amount)
        {
            // Subtrahera beloppet inom parantereserna från kontobalansen
            balance -= amount;
        }

        // Metod för att få fram kontobalansen
        public int GetBalance()
        {
            // Returnera kontobalansen
            return balance;
        }

        // Metod för att visa kontobalansen
        public void ShowBalance()
        {
            // Skriver ut kontobalansen i konsolen
            Console.WriteLine($"Deposit:{Deposit}, Withdraw:{Withdraw}Current balance: {balance}");
        }
    }
}
