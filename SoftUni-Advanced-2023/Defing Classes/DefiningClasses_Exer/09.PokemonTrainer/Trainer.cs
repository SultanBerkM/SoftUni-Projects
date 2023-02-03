using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.PokemonTrainer
{
    public class Trainer
    {
        private string name;
        private int badge = 0;
        private List<Pokemon> collectionOfPokemons = new List<Pokemon>();
        private int count;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }


        public List<Pokemon> CollectionOfPokemons
        {
            get { return collectionOfPokemons; }
            set { collectionOfPokemons = value; }
        }


        public int Badges
        {
            get { return badge; }
            set { badge = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Trainer(string trainerName, Pokemon pokemon)
        {
            this.Name = trainerName;
            this.collectionOfPokemons.Add(pokemon);
        }
       
    }
}
