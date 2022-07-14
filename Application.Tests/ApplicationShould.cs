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

        expectedPokemon.Should().BeOfType<Pokemon>();
    }
    
    [Fact]
    public void ReturnPokemonWithId2()
    {
        var pokedex = new Pokedex();
        var expectedPokemon = pokedex.FindPokemonById(2);
        var fakeNames = new Dictionary<string, string>
        {
            {"english", "Ivysaur"},
            {"japanese", "フシギソウ"},
            {"chinese", "妙蛙草"},
            {"french", "Herbizarre"}
        };
        var fakeStats = new Dictionary<string, int>
        {
            {"HP", 60},
            {"Attack", 62},
            {"Defense", 63},
            {"Sp. Attack", 80},
            {"Sp. Defense", 80},
            {"Speed", 60}
        };
        var fakeTypes = new List<string>
        {
            "Grass",
            "Poison"
        };
        var fakePokemon = new Pokemon(2,fakeNames,fakeTypes,fakeStats);

        expectedPokemon.Should().BeEquivalentTo(fakePokemon);
    }
}