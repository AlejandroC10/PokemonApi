using Domain;

namespace Application;

public class Pokedex
{
    public Pokemon FindPokemonById(int id)
    {
        Dictionary<string,string> fakeNames;
        Dictionary<string,int> fakeStats;
        List<string> fakeTypes;
        if (id ==2)
        {
            fakeNames = new Dictionary<string, string>
            {
                {"english", "Ivysaur"},
                {"japanese", "フシギソウ"},
                {"chinese", "妙蛙草"},
                {"french", "Herbizarre"}
            };
            fakeStats = new Dictionary<string, int>
            {
                {"HP", 60},
                {"Attack", 62},
                {"Defense", 63},
                {"Sp. Attack", 80},
                {"Sp. Defense", 80},
                {"Speed", 60}
            };
            fakeTypes = new List<string>
            {
                "Grass",
                "Poison"
            };
            return new Pokemon(2,fakeNames,fakeTypes,fakeStats);
        }
        
        
        fakeNames = new Dictionary<string, string>
        {
            {"english", "Bulbasaur"}
        };
        fakeStats = new Dictionary<string, int>
        {
            {"HP", 45}
        };
        fakeTypes = new List<string>
        {
            "Grass",
        };
        
        return new Pokemon(1,fakeNames,fakeTypes,fakeStats);
    }
}