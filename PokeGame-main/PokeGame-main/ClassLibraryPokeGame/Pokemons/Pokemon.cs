using ClassLibraryPokeGame.Enums;

namespace ClassLibraryPokeGame.Pokemons
{
    public class Pokemon
    {
        // Property för health points 
        // Databehållaren "bakom" en property kallas för fält.
        private int _healthPoints = 100;
        public int HealthPoints
        {
           
            get { return _healthPoints; }
           
            set { _healthPoints = value; }
        }

      
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        // Property för Type
        private PokeTypes _type;
        public PokeTypes Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public Pokemon() //Konstruktor utan parametrar, den är identisk med en defaultkonstruktor
        {
            
        }

        // Detta är en konstruktor med parametrar. En klass kan ha hur många konstruktorer som man vill, bara alla har olika signatur.
        public Pokemon(string name, PokeTypes type) 
        {
            _name = name;
            _type = type;
        }

        // Detta är en instans-metod. Till skillnad från statiska metoder anropas dessa enbart genom objekt.
        public virtual void Attack(Pokemon target)
        {
            target.HealthPoints -= 10;
            Console.WriteLine(Name + " Attacks " + target.Name);
        }

        

    }
}
