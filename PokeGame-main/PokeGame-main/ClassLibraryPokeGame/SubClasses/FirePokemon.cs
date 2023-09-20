using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryPokeGame.Enums;

namespace ClassLibraryPokeGame.SubClasses
{
    public class FirePokemon : Pokemon
    {
        public FirePokemon()
        {
            Type = PokeTypes.Fire;
        }

        public override void Attack(Pokemon target)
        {
            base.Attack(target);
            Ember();
        }
            
        public override void Eat(string food)
        {
            
        }

        public void Ember()
        {
            Console.WriteLine("Burn baby burn!");
        }
    }
}
