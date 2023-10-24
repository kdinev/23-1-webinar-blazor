using System.Net.Http.Json;
using Features.Models.Financial;

namespace Features.Financial
{
    public class FinancialService: IFinancialService
    {
        private readonly HttpClient _http;

        public FinancialService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<SalesType>> GetSales()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("/static-data/financial-sales-type.json", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<SalesType>>().ConfigureAwait(false);
            }

            return new List<SalesType>();
        }
    }
}