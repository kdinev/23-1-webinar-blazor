using Features.Models.Financial;

namespace Features.Financial
{
    public interface IFinancialService
    {
        Task<List<SalesType>> GetSales();
    }
}