using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private double money;
        private List<Product> bagOfProducts = new List<Product>();

        public Person(string name, double money)
        {
            this.Name = name;
            this.Money = money;
        }
        public List<Product> BagOfProducts
        {
            get { return bagOfProducts; }
            set { bagOfProducts = value; }
        }

        public double Money
        {
            get { return money; }
             set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                } 
                money = value; 
            }
        }

        public string Name
        {
            get { return name; }
            private set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            }
        }

    }
}
