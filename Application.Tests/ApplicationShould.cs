using System.Collections.Generic;
using Domain;
using FluentAssertions;
using Xunit;

namespace Application.Test;

public class ApplicationShould
{
    [Fact]
    public void ReturnPokemon()
    {
        var pokedex = new Pokedex();
        var expectedPokemon = pokedex.FindPokemonById(1);

        var fakeNames = new Dictionary<string, string>
        {
            {"english", "Bulbasaur"},
            {"japanese", "フシギダネ"},
            {"chinese", "妙蛙种子"},
            {"french", "Bulbizarre"}
        };
        var fakeStats = new Dictionary<string, int>
        {
            {"HP", 45},
            {"Attack", 49},
            {"Defense", 49},
            {"Sp. Attack", 65},
            {"Sp. Defense", 65},
            {"Speed", 45}
        };
        var fakeTypes = new List<string>
        {
            "Grass",
            "Poison"
        };
        var fakePokemon = new Pokemon(1,fakeNames,fakeTypes,fakeStats);
        
        expectedPokemon.Should().BeEquivalentTo(fakePokemon);
    }
}