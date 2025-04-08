using System.Net.Http.Json;

namespace ConsoleApp1
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            using HttpClient client = new HttpClient();
            HttpResponseMessage message = await client.GetAsync("https://api.sampleapis.com/beers/ale");
            Coffee[]? coffees = await message.Content.ReadFromJsonAsync<Coffee[]>();
            if (coffees is null)
            {
                return;
            }
            if (coffees.Length == 0)
            {
                return;
            }

            Console.WriteLine(coffees[0].Title);
        }
    }
}