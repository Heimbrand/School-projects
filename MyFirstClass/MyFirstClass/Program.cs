




using MyFirstClass;
using System;

Pokémon pikachu = new Pokémon();
pikachu._name = "pikachu";
pikachu._type = "electric";
pikachu. _level = 66;
pikachu._catchphrase = "PIKA PIKA PIKAAAA!!1!!111";

Pokémon Blastoise = new Pokémon();
Blastoise._name = "Blastoise";
Blastoise._type = "Water";
Blastoise._level = 99;
Blastoise._catchphrase = "Hello, how are you. I am under water";

Console.WriteLine(Blastoise._name);
Console.WriteLine(Blastoise._type);
Console.WriteLine(Blastoise._catchphrase);
Console.WriteLine(Blastoise._level);
Console.WriteLine("--------------------");
Console.WriteLine(pikachu._name);
Console.WriteLine(pikachu._type);
Console.WriteLine(pikachu._catchphrase);
Console.WriteLine(pikachu._level);