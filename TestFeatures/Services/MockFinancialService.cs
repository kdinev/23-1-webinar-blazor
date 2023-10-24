using Features.Models.Financial;

namespace Features.Financial
{
    public class MockFinancialService : IFinancialService
    {
        public Task<List<SalesType>> GetSales()
        {
            return Task.FromResult<List<SalesType>>(new());
        }
    }
}