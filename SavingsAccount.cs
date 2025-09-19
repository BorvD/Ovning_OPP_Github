using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_OPP_Github
{
    // Arv klass från BankAccount
    public class SavingsAccount : BankAccount
    {
        // Fältet för att lagra kontobalansen
        private int balance;


        // Konstruktor för att initiera sparkontot med ett startbelopp
        public SavingsAccount(int Balance) : base(Balance)
        {
            // Sätt kontobalansen till det angivna startbeloppet
            balance = Balance;
        }

        // Metod för att visa kontotypen
        public override void BankAccountType()
        {
            // Skriver ut kontotypen i konsolen
            // Gör texten grön
            Console.ForegroundColor = ConsoleColor.Blue;
            // Skriv ut kontotypen
            Console.WriteLine("Savingsaccount:");
            // Återställer textfärgen till vit
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
