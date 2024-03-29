﻿using J7z_E_Commerce.Shared;

namespace J7z_E_Commerce.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _httpClient;

        public CategoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public List<Category> Categories { get; set; } = new List<Category>();

        public async Task GetCategories()
        {
            var responce = await _httpClient.GetFromJsonAsync<ServiceResponse<List<Category>>>($"api/Category");
            if(responce != null && responce.Data != null)
            {
                Categories = responce.Data;
            }
        }
    }
}
