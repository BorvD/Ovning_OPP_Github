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
        public string whatAccountType;
        public int deposit;
        public int withdraw;
        private string accountName;


        // Konstruktor för att initiera kontot med ett startbelopp
        public void AccountBalance(int Balance)
        {   
            // Sätt kontobalansen till det angivna startbeloppet
            balance = Balance;
        }

        public void AccountName(string name)
        {
            // Metod
            accountName = name;
        }

        // Metod för att sätta in pengar på kontot
        public void Deposit(int amount)
        {
            // Addera beloppet inom parantereserna till kontobalansen
            balance += amount;
            deposit = amount;
        }

        // Metod för att ta ut pengar från kontot
        public void Withdraw(int amount)
        {
            // Subtrahera beloppet inom parantereserna från kontobalansen
            balance -= amount;
            withdraw = amount;
        }

        // Metod för att få fram kontobalansen
        public int GetBalance()
        {
            // Returnera kontobalansen
            return balance;
        }

        // Metod för att visa kontotypen
        public virtual void BankAccountType()
        {
            // Skriver ut kontotypen i konsolen
            // Gör texten blå
            Console.ForegroundColor = ConsoleColor.Blue;
            // Skriv ut kontotypen
            Console.WriteLine("Bankaccount:");
            // Återställer textfärgen till vit
            Console.ForegroundColor = ConsoleColor.White;
        }

        // Metod för att visa kontobalansen
        public void ShowBalance()
        {
            // Skriver ut kontobalansen i konsolen
            Console.WriteLine($"Account Name: {accountName}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Deposit: {deposit}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Withdraw: {withdraw}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Current balance: {balance}");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--------------");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
