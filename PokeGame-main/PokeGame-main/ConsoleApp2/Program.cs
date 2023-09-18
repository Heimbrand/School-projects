using PokeGame;

// Här instansieras klassen Pokemon och ett objekt av typen Pokemon läggs i variabeln pikachu
// Detta görs med en konstruktor i klassen Pokemon som har 2 parametrar, name och type.
Pokemon pikachu = new Pokemon("Pikachu", PokeTypes.Electric);

// Här instansieras klassen Pokemon och ett objekt av typen Pokemon läggs i variabeln charmander
// Detta görs med en tom konstruktor och sedan tilldelas värden till Name och Type
Pokemon charizard = new Pokemon();
charizard.Name = "Charizard";
charizard.Type = PokeTypes.Fire;

// Här anropas metoden Attack på objektet charmander och en referens till objektet pikachu skickas in som argument
charizard.Attack(pikachu);
// Här anropas metoden Attack på objektet pikachu och en referens till objektet charmander skickas in som argument
pikachu.Attack(charizard);

// Här skrivs värdet på propertyn HealthPoints ut för båda objekten pikachu och charmander
Console.WriteLine("Pikachu health points: " + pikachu.HealthPoints);
Console.WriteLine("Charmander health points: " + charizard.HealthPoints);

//Console.WriteLine(pikachu.Name);
//Console.WriteLine(pikachu.Type);
//Console.WriteLine(charmander.Name);
//Console.WriteLine(charmander.Type);

//charmander.Type = "tjoho0";

//Console.WriteLine(charmander.Name);
//Console.WriteLine(charmander.Type);

Console.WriteLine("______________________");

Trainer olle = new Trainer();


Pokemon mewtwo = new Pokemon("Mewtwo", PokeTypes.Psychic);
Pokemon blastoise = new Pokemon("Blastoise", PokeTypes.Water);
//Pokemon venusaur = new Pokemon("Venusaur", PokeTypes.Grass);

//olle.Catch(venusaur);
olle.Catch(mewtwo);
olle.Catch(blastoise);
olle.Catch(pikachu);
olle.Catch(charizard);

Console.WriteLine(olle.PokemonCollection.Count);

Console.WriteLine("___________________________________");

FirePokemon charmeleon = new FirePokemon();

charmeleon.Name = "Charmeleon";

olle.Catch(charmeleon);

WaterPokemon wartorlte = new WaterPokemon();

wartorlte.Name = "Wartortle";

olle.Catch(wartorlte);
GrassPokemon venusaur = new GrassPokemon();
venusaur.Name = "Venusaur";

PsychicPokemon mew = new PsychicPokemon();
mew.Name = "Mew";

olle.Catch(mew);
olle.Catch(venusaur);


foreach (Pokemon pokemon in olle.PokemonCollection)
{
    if(pokemon is GrassPokemon grass)
    {
       grass.HyperBeam();
    }
    else if (pokemon is PsychicPokemon psychic) 
    {
        psychic.Confusion();
    }

    Console.WriteLine(pokemon.Name);
    Console.WriteLine(pokemon.Type);

}
Console.WriteLine("---------------------------------");
