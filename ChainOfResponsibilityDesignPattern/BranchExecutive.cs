namespace ChainOfResponsibilityDesignPattern
{
    internal class BranchExecutive :IApprover
    {
        //make this class the head of the other classes 
        //constructor dont take any value 
        public BranchExecutive() : base(null)
        {
        }

        public override bool ApproveLoan(int amount)
        {
            //Branch executive can approve if the money less than 500k
            if (amount <= 500000 && amount > 250000)
            {
                Console.WriteLine("Your loan is accepted by Branch Executive");
                return true;
            }
            else if (amount > 500000)
            {
                Console.WriteLine("Your loan is higher than Bank Loaning process! Please enter a valid value!");

                return false;
            }

            return false;
        }
    }
}
