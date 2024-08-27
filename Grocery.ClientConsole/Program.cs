// See https://aka.ms/new-console-template for more information
Console.WriteLine("Console app to test the Grocery Api Client");
Console.WriteLine("Press any key when ready to start");
Console.ReadKey();

Console.WriteLine("----> Client initialized !!!");

HttpClient httpClient = new HttpClient();
httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6Impvc2VmIiwic3ViIjoiam9zZWYiLCJqdGkiOiJmMWFiY2FiZCIsImF1ZCI6WyJodHRwOi8vbG9jYWxob3N0OjIzNjE5IiwiaHR0cHM6Ly9sb2NhbGhvc3Q6NDQzNTAiLCJodHRwOi8vbG9jYWxob3N0OjUwNTgiLCJodHRwczovL2xvY2FsaG9zdDo3MjU4Il0sIm5iZiI6MTcyNDQyODMzMCwiZXhwIjoxNzMyMzc3MTMwLCJpYXQiOjE3MjQ0MjgzMzIsImlzcyI6ImRvdG5ldC11c2VyLWp3dHMifQ.BWGCAaBLLARa0fWzU1bNvMTIf-KqdOMr_Y3gxTay3H4");
var client = new NSwagGrocerySdk.Client.NSwagGrocerySdk("https://localhost:7258/", httpClient);

Console.WriteLine("-----> Listing items");

foreach (var item in client.GetGroceryItemsAsync().Result)
{
    Console.WriteLine($"item name: {item.Name}");
}
Console.WriteLine("-----> Adding a new item");

await client.AddGroceryItemAsync(new NSwagGrocerySdk.Client.GroceryItem()
{
    Name = "wine",
    Description = "red wine"
});
Console.WriteLine("-----> Listing items again");
foreach (var item in client.GetGroceryItemsAsync().Result)
{
    Console.WriteLine($"item name: {item.Name}");
}

Console.WriteLine("Completed. Press any key when ready");
Console.ReadKey();
