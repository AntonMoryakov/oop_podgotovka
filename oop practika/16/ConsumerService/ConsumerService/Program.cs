using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsumerService
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var client = new HttpClient();

            var response = await client.GetAsync("http://localhost:5000/products");

            if (response.IsSuccessStatusCode)
            {
                var products = await response.Content.ReadAsAsync<Product[]>();

                foreach (var product in products)
                {
                    Console.WriteLine($"Id: {product.Id}");
                    Console.WriteLine($"Name: {product.Name}");
                    Console.WriteLine($"Description: {product.Description}");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine($"Failed to get products. Status code: {response.StatusCode}");
            }
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}