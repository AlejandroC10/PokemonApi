﻿using Domain;
using Json;

namespace Application;

public class Pokedex
{
    public Pokemon FindPokemonById(int id)
    {
        var pokemonDb = new PokemonDb();
        var pokemonList = pokemonDb.ReadPokemon();

        foreach (var pokemon in pokemonList)
        {
            if (pokemon.Id == id)
            {
                return pokemon;
            }   
        }

        return null;
    }

    public List<Pokemon> FindByType(string type)
    {
        var pokemonDb = new PokemonDb();
        var pokemonList = pokemonDb.ReadPokemon();

        var matchPokemon = new List<Pokemon>();
        
        foreach (var pokemon in pokemonList)
        {
            if (pokemon.Type.Contains(type))
            {
                matchPokemon.Add(pokemon);
            }   
        }
        
        return matchPokemon;
    }

    public List<Pokemon> GetAll()
    {
        return null;
    }
}