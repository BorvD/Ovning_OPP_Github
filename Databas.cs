using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_OPP_Github
{
    internal class Databas
    {
        public void Run() 
        {

            // Skapar ett objekt för att köra BankAccount
            BankAccount newAccount = new BankAccount();
            // Skapar ett objekt av BankAccountInfo klassen för att visa kontoinformation
            BankAccountInfo bankAccountInfo = new BankAccountInfo();
            // Skapar ett objekt för att köra SavingsAccount
            SavingsAccount newSavingsAccount = new SavingsAccount();
            // Skapar ett objekt av SavingsAccountInfo klassen för att visa kontoinformation
            SavingsAccountInfo savingsAccountInfo = new SavingsAccountInfo();



            // Mall för att skapa nytt BankKonto:
            //newAccount.AccountName("");           // Fyll i kontonamn
            //newAccount.BankAccountType();
            //bankAccountInfo.AccountInfo();
            //newAccount.AccountBalance();          // Fyll i Vad som fanns i kontot från start
            //newAccount.Deposit();                 // Fyll i hur mycket som läggs in på kontot
            //newAccount.Withdraw();                // Fyll i hur mycket som tar ut ur konot
            //newAccount.ShowBalance();



            // Mall för att skapa nytt Sparkonto:
            //newSavingsAccount.AccountName("");      // Fyll i kontonamn
            //newSavingsAccount.BankAccountType();
            //savingsAccountInfo.AccountInfo();
            //newSavingsAccount.AccountBalance();     // Fyll i Vad som fanns i kontot från start
            //newSavingsAccount.Deposit();            // Fyll i hur mycket som läggs in på kontot
            //newSavingsAccount.Withdraw();           // Fyll i hur mycket som tar ut ur konot
            //newSavingsAccount.ShowBalance();

            // Ett välkomstmeddelande
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Welcome to BörveBank! Here are all our Accounts:");
            Console.WriteLine("--------------");
            Console.WriteLine("--------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--------------");


            // För att köra BankAccount klassen
            // Vilket namn kontot har
            newAccount.AccountName("12345");
            // Vilket kontotyp det är
            newAccount.BankAccountType();
            // Anropar metoden för att visa kontoinformation
            bankAccountInfo.AccountInfo();
            // Balans på kontot från start
            newAccount.AccountBalance(200);
            // Sätter in 50 på kontot. Går att ändra och testa olika värden inom parenteserna
            newAccount.Deposit(50);
            // Tar ut 25 från kontot. Går att ändra och testa olika värden inom parenteserna
            newAccount.Withdraw(25);
            // Visar den aktuella balansen på kontot
            newAccount.ShowBalance();


            // För att köra SavingsAccount klassen
            // Vilket namn kontot har
            newSavingsAccount.AccountName("12346");
            // Vilket kontotyp det är
            newSavingsAccount.BankAccountType();
            // Anropar metoden för att visa kontoinformation
            savingsAccountInfo.AccountInfo();
            // Balans på kontot
            newSavingsAccount.AccountBalance(200);
            // Sätter in 100 på sparkontot. Går att ändra och testa olika värden inom parenteserna
            newSavingsAccount.Deposit(100);
            // Tar ut 50 från sparkontot. Går att ändra och testa olika värden inom parenteserna
            newSavingsAccount.Withdraw(500);
            // Visar den aktuella balansen på sparkontot
            newSavingsAccount.ShowBalance();


            newAccount.AccountName("d34d");  
            newAccount.BankAccountType();
            bankAccountInfo.AccountInfo();
            newAccount.AccountBalance(58438);          
            newAccount.Deposit(5739);                 
            newAccount.Withdraw(4739);                
            newAccount.ShowBalance();


            newSavingsAccount.AccountName("ercdnrk");      
            newSavingsAccount.BankAccountType();
            savingsAccountInfo.AccountInfo();
            newSavingsAccount.AccountBalance(7348);     
            newSavingsAccount.Deposit(7538);            
            newSavingsAccount.Withdraw(0);           
            newSavingsAccount.ShowBalance();


            newAccount.AccountName("Nemos hemliga konto");
            newAccount.BankAccountType();
            bankAccountInfo.AccountInfo();
            newAccount.AccountBalance(5368);
            newAccount.Deposit(0);
            newAccount.Withdraw(0);
            newAccount.ShowBalance();


            newSavingsAccount.AccountName("rdhcey");
            newSavingsAccount.BankAccountType();
            savingsAccountInfo.AccountInfo();
            newSavingsAccount.AccountBalance(75387);
            newSavingsAccount.Deposit(5739);
            newSavingsAccount.Withdraw(99999999);
            newSavingsAccount.ShowBalance();


            newAccount.AccountName("rhwjcb");
            newAccount.BankAccountType();
            bankAccountInfo.AccountInfo();
            newAccount.AccountBalance(5483);
            newAccount.Deposit(75934);
            newAccount.Withdraw(5734);
            newAccount.ShowBalance();


            newSavingsAccount.AccountName("rg3ufd");
            newSavingsAccount.BankAccountType();
            savingsAccountInfo.AccountInfo();
            newSavingsAccount.AccountBalance(65834);
            newSavingsAccount.Deposit(5749);
            newSavingsAccount.Withdraw(57934);
            newSavingsAccount.ShowBalance();





            // Vissar att listan är slut
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("--------------");
            Console.WriteLine("--------------");
            Console.WriteLine("Fin");
            Console.ForegroundColor = ConsoleColor.White;


        }
    }
}
