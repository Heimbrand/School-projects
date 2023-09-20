using ClassLibraryPokeGame.Enums;

namespace ClassLibraryPokeGame.SubClasses
{
    public class WaterPokemon : Pokemon
    {
        public WaterPokemon()
        {
            Type = PokeTypes.Water;
        }

        public void Bubble()
        {
            Console.WriteLine("Blublublub!");
        }

        public override void Eat(string food)
        {
            
        }
    }
}
