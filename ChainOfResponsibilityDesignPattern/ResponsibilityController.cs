namespace ChainOfResponsibilityDesignPattern
{
    internal class ResponsibilityController
    {
        public void ResponsibilityControl(int amount)
        {
            //giving responsibility to every IApprover instance
            IApprover BranchExecutive = new BranchExecutive();

            IApprover chiefCashier = new ChiefCashier(BranchExecutive);

            IApprover cashier = new Cashier(chiefCashier);

            cashier.ApproveLoan(amount);
        }
    }
}
