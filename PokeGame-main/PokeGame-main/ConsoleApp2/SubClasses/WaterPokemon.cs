﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace PokeGame.SubClasses
{
    internal class WaterPokemon : Pokemon
    {
        public WaterPokemon()
        {
            Type = PokeTypes.Water;
        }

        public void Bubble()
        {
            Console.WriteLine("Blublublub!");
        }

    }
}
