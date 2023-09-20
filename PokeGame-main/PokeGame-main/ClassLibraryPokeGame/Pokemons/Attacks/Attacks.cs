using ClassLibraryPokeGame.Enums;

namespace ClassLibraryPokeGame.Pokemons.Attacks;

public abstract class Attacks
{
    public double damage { get; }
    public string Name { get; }
    public PokeTypes Type { get; }

    protected Attacks(double damage, string name, PokeTypes type)
    {
        this.damage = damage;
        Name = name;
        Type = type;
    }
}


