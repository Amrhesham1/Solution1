namespace Oflow_app_Server.ActionReq
{
    public class AuctionService
    {
         private readonly HttpClient _httpClient;

    public AuctionService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Auction>> GetAuctionsAsync()
    {
        return await _httpClient.GetFromJsonAsync<List<Auction>>("api/auctions");
    }
    }
}
