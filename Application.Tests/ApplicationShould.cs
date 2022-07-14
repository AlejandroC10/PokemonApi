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
}