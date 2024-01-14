namespace FacadeDesignPattern
{
    internal class BankingFacade
    {
        private Account account;
        private Loan loan;
        private CreditCard creditCard;

        public BankingFacade()
        {
            account = new Account();
            loan = new Loan();
            creditCard = new CreditCard();
        }

        // Facade method to check account balance
        public void CheckAccountBalance()
        {
            account.CheckBalance();
        }

        // Facade method to apply for a loan
        public void ApplyForLoan()
        {
            loan.ApplyLoan();
        }

        // Facade method to make a credit card purchase
        public void MakeCreditCardPurchase()
        {
            creditCard.MakePurchase();
        }
    }
}
