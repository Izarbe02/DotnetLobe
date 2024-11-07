/*dotnet new console
dotnet run
dotnet add package Newtonsoft.Json
"https://pokeapi.co/api/v2/pokemon"; URL api*/
using Models;
using System;
using Newtonsoft;
using Newtonsoft.Json;

class Program
{

    static HttpClient client = new HttpClient();

    static async Task Main()
        {
            //get
            var response = await client.GetAsync("https://pokeapi.co/api/v2/pokemon");
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseBody);

            Info info  = JsonConvert.DeserializeObject<Info>(responseBody);
            //objet info almacena json (reponsebody) convertido supliendo necesiddes info

            Console.WriteLine($"Count:{info.count}");
            foreach (Pokemon  item in info.results){
                Console.WriteLine($"Name: {item.name}, URL: {item.URL}");
            }
    }
}


