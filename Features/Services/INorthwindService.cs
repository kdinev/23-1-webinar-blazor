using Features.Models.Northwind;

namespace Features.Northwind
{
    public interface INorthwindService
    {
        Task<List<SuppliersType>> GetSuppliers();

        Task<List<EmployeesType>> GetEmployees();
    }
}