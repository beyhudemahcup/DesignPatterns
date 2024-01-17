namespace CompositeDesignPattern
{
    internal class ITDepartment : IDepartment
    {
        string E1 = "IT1";
        string E2 = "IT2";
        string E3 = "IT3";

        public List<string> GetEmployees()
        {
            return [E1, E2, E3];
        }

        public string GetName()
        {
            return "Employees of the it department!";
        }
    }
}
