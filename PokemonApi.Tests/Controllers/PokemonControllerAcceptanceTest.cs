using System.Net.Http;
using Xunit;
using PokemonApi;

namespace PokemonApiTests.Controllers;

public class PokemonControllerAcceptanceTest: IClassFixture<CustomWepApplicationFactory<Program>>
{
    private readonly HttpClient client;

    public PokemonControllerAcceptanceTest(CustomWepApplicationFactory<Program> factory)
    {
        client = factory.CreateClient();
    }
    [Fact]
    public void FindPokemonByIdAcceptance()
    {

    }
}