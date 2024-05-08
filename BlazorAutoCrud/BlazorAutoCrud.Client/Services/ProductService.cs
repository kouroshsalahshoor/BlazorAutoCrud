using Shared.IRepositories;
using Shared.Models;
using System.Net.Http.Json;

namespace BlazorAutoCrud.Client.Services
{
    public class ProductService : IProductRepository
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Product>?> Get()
        {
            return await _httpClient.GetFromJsonAsync<List<Product>>("api/products");
        }
        public async Task<Product?> Get(int id)
        {
            return await _httpClient.GetFromJsonAsync<Product>($"api/products/{id}");
        }
        public async Task<Product?> Add(Product model)
        {
            var response = await _httpClient.PostAsJsonAsync("api/products", model);
            return await response.Content.ReadFromJsonAsync<Product>();
        }
        public async Task<Product?> Update(Product model)
        {
            var response = await _httpClient.PutAsJsonAsync("api/products", model);
            return await response.Content.ReadFromJsonAsync<Product>();
        }
        public async Task<Product?> Delete(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/products/{id}");
            return await response.Content.ReadFromJsonAsync<Product>();
        }
    }
}
