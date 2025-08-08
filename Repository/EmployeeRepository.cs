using Microsoft.EntityFrameworkCore;
using MyProject.Model;

namespace MyProject.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        //private readonly List<Employee> _employees = new()
        //{
        //    new Employee { Id = 1, Name = "John Doe", Department = "IT" },
        //    new Employee { Id = 2, Name = "Jane Smith", Department = "HR" }
        //};

        private readonly AppDbContext _context;

        public EmployeeRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Employee>> GetAllEmployees() //=>  _employees;
        {
            return await _context.Employees.AsNoTracking().ToListAsync();
        }

    }
}
