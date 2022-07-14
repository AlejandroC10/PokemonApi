using Domain;

namespace Application;

public class Pokedex
{
    public Pokemon FindPokemonById(int id)
    {
        var fakeNames = new Dictionary<string, string>
        {
            {"english", "Bulbasaur"}
        };
        var fakeStats = new Dictionary<string, int>
        {
            {"HP", 45}
        };
        var fakeTypes = new List<string>
        {
            "Grass",
        };
        
         
        return new Pokemon(1,fakeNames,fakeTypes,fakeStats);
    }
}