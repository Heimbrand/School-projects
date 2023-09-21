using ClassLibraryPokeGame;
using ClassLibraryPokeGame.Pokemons;


Trainer olle = new Trainer();

Pokemon charizard = new Pokemon();
Pokemon pikachu = new Pokemon();
Pokemon charmeleon = new Pokemon();
Pokemon wartortle = new Pokemon();
Pokemon mew = new Pokemon();
Pokemon venusaur = new Pokemon();

mew.Name = "Mew";
charmeleon.Name = "Charmeleon";
venusaur.Name = "Venusaur";
wartortle.Name = "Wartortle";
pikachu.Name = "Pikachu";

olle.Catch(charmeleon);
olle.Catch(wartortle);
olle.Catch(mew);
olle.Catch(venusaur);
olle.Catch(pikachu);

Console.WriteLine("----------------------------");
charmeleon.Attack(wartortle);
Console.WriteLine("Wartortle lost 10 HealthPoints. Current HP: " + wartortle.HealthPoints);
Console.WriteLine("----------------------------");

Console.WriteLine("Olle has catched: " + olle.PokemonCollection.Count + " Pokémon's so far!");



