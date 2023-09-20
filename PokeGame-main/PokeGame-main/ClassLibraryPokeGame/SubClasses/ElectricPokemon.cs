namespace ClassLibraryPokeGame.SubClasses
{
    internal abstract class ElectricPokemon : Pokemon
    {
        public override void Eat(string food)
        {
            throw new NotImplementedException();
        }

        public override void Attack(Pokemon target)
        {
            base.Attack(target);
        }

        public void Thunderbolt() 
        {
            Console.WriteLine("BZZZZZZBZZZZZZBZZZZZ");
        }
    }
}
