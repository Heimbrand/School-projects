using MyFirstClassDiagram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstClassDiagram
{
    internal class Particle
    {
        public Vector2 position { get; set; }
        
        public Vector2 speed { get; set; }
       
        public int immageoffsetX { get; set; }  
      
        public int immageoffsetY { get; set; }
        
        public bool CollidesWith(GameObject other)
        {
            return true;
        }
    }
}

class Meteor : GameObject
{
    public MeteorType type { get; set; }
    public float ExplosionScale { get; set; }

    public void Meter(meteorType MeterorType)
    {

    }
    public void Update(gameTime GameTime)
    {

    }
}