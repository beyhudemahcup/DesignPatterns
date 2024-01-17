namespace ChainOfResponsibilityDesignPattern
{
    internal class Cashier(IApprover chief) : IApprover(chief)
    {
        public override bool ApproveLoan(int amount)
        {
            //cashier can approve if the money less than 100k
            if (amount <= 100000 && amount > 0 )
            {
                Console.WriteLine("Your loan is accepted by Cashier");
                return true;
            }
            else if (chief != null) {
                Console.WriteLine("Your loan is higher than Cashier's approval limit! Your request sent to the Chief Cashier");
                
                return chief.ApproveLoan(amount);
            }

            return false;
        }
    }
}
