namespace ChainOfResponsibilityDesignPattern
{
    internal class ChiefCashier(IApprover chief) : IApprover(chief)
    {
        public override bool ApproveLoan(int amount)
        {
            //Chief cashier can approve if the money less than 250k
            if (amount <= 250000 && amount > 100000)
            {
                Console.WriteLine("Your loan is accepted by Chief Cashier");
                
                return true;
            }
            else if (chief != null)
            {
                Console.WriteLine("Your loan is higher than Chief Cashier's approval limit! Your request sent to the Branch Executive");

                return chief.ApproveLoan(amount);
            }

            return false;
        }
    }
}
