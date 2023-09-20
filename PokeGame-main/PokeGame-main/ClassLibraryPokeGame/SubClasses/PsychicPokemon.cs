using ClassLibraryPokeGame.Enums;

namespace ClassLibraryPokeGame.SubClasses
{
    public class PsychicPokemon : Pokemon
    {
        public PsychicPokemon()
        {
            Type = PokeTypes.Psychic;
        }
        public void Confusion()
        {
            Console.WriteLine("All your base are belong to us");
        }

        public override void Eat(string food)
        {
            
        }
    }
}
