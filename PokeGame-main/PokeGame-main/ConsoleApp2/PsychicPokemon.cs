using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeGame
{
    internal class PsychicPokemon : Pokemon
    {
        public PsychicPokemon() 
        {
            Type = PokeTypes.Psychic;
        }
        public void Confusion()
        {
            Console.WriteLine("All your base are belong to us");
        }
    }
}
