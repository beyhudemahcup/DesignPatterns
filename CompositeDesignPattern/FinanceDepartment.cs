
namespace CompositeDesignPattern
{
    internal class FinanceDepartment : IDepartment
    {

        string E1 = "finance1";
        string E2 = "finance2";
        string E3 = "finance3";

        public List<string> GetEmployees()
        {
            return [E1,E2,E3];
        }

        public string GetName()
        {
            return "Employees of the finance department!";
        }
    }
}
