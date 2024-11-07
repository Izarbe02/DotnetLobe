using System; 
using Models;
using Newtonsoft;
using Newtonsoft.Json;



class Program{

    static HttpClient Client = new HttpClient();


    static async Task Main()
        {
            //get
            var response = await Client.GetAsync("https://pokeapi.co/api/v2/pokemon");
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseBody);

            Info info  = JsonConvert.DeserializeObject<Info>(responseBody);
            //objet info almacena json (reponsebody) convertido supliendo necesiddes info

            Console.WriteLine($"Count:{info.Count}");
            foreach (Berry  item in info.Results){
                Console.WriteLine($"Name: {item.Name}, URL: {item.URL}");
            }
    }
}
