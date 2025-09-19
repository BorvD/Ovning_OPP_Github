using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_OPP_Github
{
    abstract class InfoOfAccount
    {
        // Abstrakt metod som implementeras i subklasser
        public abstract void AccountInfo();

    }
    // Subklass för BankAccount
    class BankAccountInfo : InfoOfAccount
    {
        // Implementering av den abstrakta metoden
        public override void AccountInfo()
        {
            // Ändra textfärgen till magneta
            Console.ForegroundColor = ConsoleColor.Magenta;
            // Skriv ut information om BankAccount
            Console.WriteLine("Account info: It has 0,5% interest rates");
            // Återställ textfärgen till vit
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    // Subklass för SavingsAccount
    class SavingsAccountInfo : InfoOfAccount
    {
        // Implementering av den abstrakta metoden
        public override void AccountInfo()
        {
            // Ändra textfärgen till magenta
            Console.ForegroundColor = ConsoleColor.Magenta;
            // Skriv ut information om SavingsAccount
            Console.WriteLine("Account info: It has 1,5% interest rates");
            // Återställ textfärgen till vit
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

