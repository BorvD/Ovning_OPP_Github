namespace Ovning_OPP_Github
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // För att köra BankAccount-klassen
            // Nytt konto med en balans på 100
            BankAccount newAccount = new BankAccount(100);
            // Sätter in 50 på kontot
            newAccount.Deposit(50);
            // Tar ut 25 från kontot
            newAccount.Withdraw(25);
            // Visar den aktuella balansen
            newAccount.ShowBalance();
        }
    }
}
