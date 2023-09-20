using ClassLibraryPokeGame.Enums;

namespace ClassLibraryPokeGame.SubClasses
{
    public class GrassPokemon : Pokemon
    {
        public GrassPokemon()
        {
            Type = PokeTypes.Grass;
        }

        public override void Eat(string food)
        {
            
        }

        public void HyperBeam()
        {
            Console.WriteLine("Venusaur casts the attack Hyperbeam");
        }

    }
}
