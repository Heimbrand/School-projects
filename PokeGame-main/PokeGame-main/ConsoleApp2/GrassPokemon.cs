using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeGame
{
    internal class GrassPokemon : Pokemon
    {
        public GrassPokemon()
        {
            Type = PokeTypes.Grass;        
        }
        public void HyperBeam()
        {
            Console.WriteLine("Venusaur casts the attack Hyperbeam");
        }

    }
}
