namespace Ovning_OPP_Github
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // För att köra BankAccount klassen
            // Nytt konto med en balans på 100. Går att ändra och testa olika värden inom parenteserna
            BankAccount newAccount = new BankAccount(100);
            //Vilket kontotyp det är
            newAccount.BankAccountType();
            // Skapar ett objekt av BankAccountInfo klassen för att visa kontoinformation
            BankAccountInfo bankAccountInfo = new BankAccountInfo();
            // Anropar metoden för att visa kontoinformation
            bankAccountInfo.AccountInfo();
            // Sätter in 50 på kontot. Går att ändra och testa olika värden inom parenteserna
            newAccount.Deposit(50);
            // Tar ut 25 från kontot. Går att ändra och testa olika värden inom parenteserna
            newAccount.Withdraw(25);
            // Visar den aktuella balansen på kontot
            newAccount.ShowBalance();

            // För att köra SavingsAccount klassen
            // Nytt sparkonto med en balans på 200. Går att ändra och testa olika värden inom parenteserna
            SavingsAccount newSavingsAccount = new SavingsAccount(200);
            //Vilket kontotyp det är
            newSavingsAccount.BankAccountType();
            // Skapar ett objekt av SavingsAccountInfo klassen för att visa kontoinformation
            SavingsAccountInfo savingsAccountInfo = new SavingsAccountInfo();
            // Anropar metoden för att visa kontoinformation
            savingsAccountInfo.AccountInfo();
            // Sätter in 100 på sparkontot. Går att ändra och testa olika värden inom parenteserna
            newSavingsAccount.Deposit(100);
            // Tar ut 50 från sparkontot. Går att ändra och testa olika värden inom parenteserna
            newSavingsAccount.Withdraw(500);
            // Visar den aktuella balansen på sparkontot
            newSavingsAccount.ShowBalance();
        }
    }
}
