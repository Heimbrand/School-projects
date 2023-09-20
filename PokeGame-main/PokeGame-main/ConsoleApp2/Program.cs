using ClassLibraryPokeGame;
using ClassLibraryPokeGame.SubClasses;

//Pokemon pikachu = new Pokemon("Pikachu", PokeTypes.Electric);
//Pokemon charizard = new Pokemon();
//charizard.Name = "Charizard";
//charizard.Type = PokeTypes.Fire;

//charizard.Attack(pikachu);
//pikachu.Attack(charizard);

//Console.WriteLine("Pikachu health points: " + pikachu.HealthPoints);
//Console.WriteLine("Charmander health points: " + charizard.HealthPoints);

//Console.WriteLine("______________________");



Trainer olle = new Trainer();

Console.WriteLine(olle.PokemonCollection.Count);


FirePokemon charmeleon = new FirePokemon();
PsychicPokemon wartortle = new PsychicPokemon();
WaterPokemon mew = new WaterPokemon();
GrassPokemon venusaur = new GrassPokemon();

mew.Name = "Mew";
charmeleon.Name = "Charmeleon";
venusaur.Name = "Venusaur";
wartortle.Name = "Wartortle";

olle.Catch(charmeleon);
olle.Catch(wartortle);
olle.Catch(mew);
olle.Catch(venusaur);

charmeleon.Attack(wartortle);
charmeleon.Eat(string food);
Console.WriteLine("---------------------------------");
