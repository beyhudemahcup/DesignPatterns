namespace FacadeDesignPattern
{
    // Client code
    class Program
    {
        static void Main()
        {
            // Client interacts with the banking system through the facade
            BankingFacade bankingFacade = new BankingFacade();

            // Perform banking operations using the facade
            bankingFacade.CheckAccountBalance();
            bankingFacade.ApplyForLoan();
            bankingFacade.MakeCreditCardPurchase();

            //in this way, client do not see any business code or the other stages but use the system without any problem
        }
    }
}
