namespace ChainOfResponsibilityDesignPattern
{
    internal abstract class IApprover
    {
        IApprover _chief;

        public IApprover(IApprover chief)
        {
            _chief = chief;
        }

        public abstract bool ApproveLoan (int amount);
    }
}
