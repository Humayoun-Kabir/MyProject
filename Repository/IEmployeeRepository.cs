using MyProject.Model;

namespace MyProject.Repository
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAllEmployees();
    }
}
