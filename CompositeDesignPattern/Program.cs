namespace CompositeDesignPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<IDepartment> subDepartments = new List<IDepartment>
            {
            new ITDepartment(),
            new SalesDepartment(),
            new FinanceDepartment()
            };

            int itIndex = 1;
            int salesIndex = 2;
            int financeIndex = 3;

            //reaching every departments I can use composite class
            IDepartment compositeDepartment = new CompositeDepartment(subDepartments);

            //reaching departments code
            Console.WriteLine(compositeDepartment.GetName());
            Console.WriteLine(string.Join(",", compositeDepartment.GetEmployees()));

            Console.WriteLine("=========================");
            //reaching itDepartment's code
            Console.WriteLine(subDepartments[itIndex].GetName());
            Console.WriteLine(string.Join(",", subDepartments[1].GetEmployees()));

            //reaching salesDepartment's code
            Console.WriteLine(subDepartments[salesIndex].GetName());
            Console.WriteLine(string.Join(",", subDepartments[salesIndex].GetEmployees()));

            //reaching financeDepartment's code
            Console.WriteLine(subDepartments[financeIndex].GetName());
            Console.WriteLine(string.Join(",", subDepartments[financeIndex].GetEmployees()));
        }
    }
}
