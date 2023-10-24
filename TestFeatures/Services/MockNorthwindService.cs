using Features.Models.Northwind;

namespace Features.Northwind
{
    public class MockNorthwindService : INorthwindService
    {
        public Task<List<SuppliersType>> GetSuppliers()
        {
            return Task.FromResult<List<SuppliersType>>(new());
        }

        public Task<List<EmployeesType>> GetEmployees()
        {
            return Task.FromResult<List<EmployeesType>>(new());
        }
    }
}