using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Repository
{
    public class PokemonRepository
    {
        private List<Pokemon> _pokemonTeam = new List<Pokemon>();


        //add to list (limit pokemon to 6)
        public void AddPokemonToTeam(Pokemon pokemon)
        {
            _pokemonTeam.Add(pokemon);
        }
        //get list
        public List<Pokemon> GetPokemonTeam()
        {
            return _pokemonTeam;
        }
        //get one pokemon
        public Pokemon GetPokemonByTeamPosition(int teamPosition)
        {
            foreach(Pokemon tryPokemon in _pokemonTeam)
            {
                if(tryPokemon.TeamPosition == teamPosition)
                {
                    return tryPokemon;
                }
            }
            return null;
            //Pokemon pokemon = _pokemonTeam[teamPosition - 1];
            //return pokemon;
        }
        //update pokemon
        public void UpdatePokemonByTeamPosition(int teamPosition, Pokemon updates)
        {
            Pokemon oldPokemon = _pokemonTeam[teamPosition - 1];

            oldPokemon.PokemonSpeciesName = updates.PokemonSpeciesName;
            oldPokemon.PokemonNickName = updates.PokemonNickName;
            oldPokemon.Level = updates.Level;
            oldPokemon.PokemonType = updates.PokemonType;
            oldPokemon.SecondaryType = updates.SecondaryType;
            oldPokemon.MoveOne = updates.MoveOne;
            oldPokemon.MoveTwo = updates.MoveTwo;
            oldPokemon.MoveThree = updates.MoveThree;
            oldPokemon.MoveFour = updates.MoveFour;
        }

        public void UpdatePokemonByNickName(string nickName, Pokemon newPokemon)
        {
            foreach (Pokemon p in _pokemonTeam)
            {
                if (nickName == p.PokemonNickName)
                {
                    p.PokemonSpeciesName = newPokemon.PokemonSpeciesName;
                    p.PokemonNickName = newPokemon.PokemonNickName;
                    p.Level = newPokemon.Level;
                    p.PokemonType = newPokemon.PokemonType;
                    p.SecondaryType = newPokemon.SecondaryType;
                    p.MoveOne = newPokemon.MoveOne;
                    p.MoveTwo = newPokemon.MoveTwo;
                    p.MoveThree = newPokemon.MoveThree;
                    p.MoveFour = newPokemon.MoveFour;

                }
            }
        }

        //remove pokemon
        public void RemovePokemonFromTeam(int teamPosition)
        {
            Pokemon pokemon = _pokemonTeam[teamPosition - 1];
            _pokemonTeam.Remove(pokemon);
        }
    }
}
