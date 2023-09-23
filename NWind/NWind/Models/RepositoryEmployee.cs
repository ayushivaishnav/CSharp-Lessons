using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace NWind.Models
{
    public class RepositoryEmployee
    {
        private NorthwindContext _context;
        public RepositoryEmployee(NorthwindContext context)
        {
            _context = context;
        }
        public List<Employee> AllEmployee()
        {
            return _context.Employees.ToList();
        }
    }
}
