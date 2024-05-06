using System.Text.Json;
using System.IO;
using RestSharp;
using RESTAPI_TEST;

RestClient client = new RestClient("https://digimon-api.com/api/v1/");
Console.WriteLine("Pick a digimon to get information about it");
string digiName = Console.ReadLine();
RestRequest request = new($"digimon/{digiName}");

try
{

    RestResponse response = client.GetAsync(request).Result;
    Digimon d = JsonSerializer.Deserialize<Digimon>(response.Content);
    
    Console.WriteLine(d.name);
    Console.WriteLine($"xAntibody:{d.xAntibody}");


}
catch
{
    System.Console.WriteLine("You aint funny bro");
}



// Console.WriteLine(response.Content);
// File.WriteAllText("digimon.json", response.Content);

Console.ReadLine();

