
namespace CompositeDesignPattern
{
    internal class RegionalDepartment : IDepartment
    {

        //public RegionalDepartment(List<IDepartment> subDepartments) 
        //{
        //    _subDepartments = subDepartments;
        //}

        private List<IDepartment> _subDepartments = new List<IDepartment>();

        public RegionalDepartment(List<IDepartment> subDepartments)
        {
            _subDepartments = subDepartments;
        }

        public List<string> GetEmployees()
        {
            return _subDepartments.SelectMany(d => d.GetEmployees()).ToList();
        }

        public string GetName()
        {
            return string.Join(",", _subDepartments);
        }
    }
}