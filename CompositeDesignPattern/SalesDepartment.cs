
namespace CompositeDesignPattern
{
    internal class SalesDepartment : IDepartment
    {
        string E1 = "sales1";
        string E2 = "sales2";
        string E3 = "sales3";

        public List<string> GetEmployees()
        {
            return [E1, E2, E3];
        }

        public string GetName()
        {
            return "Employees of the sales department!";
        }
    }
}
