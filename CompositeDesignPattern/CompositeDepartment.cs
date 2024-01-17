namespace CompositeDesignPattern
{
    internal class CompositeDepartment : IDepartment
    {
        private IDepartment _regionalDepartment;

        public CompositeDepartment(List<IDepartment> subDepartments)
        {
            _regionalDepartment = new RegionalDepartment(subDepartments);
        }

        public List<string> GetEmployees()
        {
            return _regionalDepartment.GetEmployees();
        }
        
        public string GetName()
        {
            return string.Join(", ", _regionalDepartment.GetName());
        }
    }
}
