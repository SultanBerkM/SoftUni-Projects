using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories
{
    public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private double grams;


        public Dough(string flour, string technique, double grams)
        {
            this.FlourType = flour.ToLower();
            this.BakingTechnique = technique.ToLower();
            this.Grams = grams;
        }
        public double Grams
        {
            get { return grams; }
            private set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                grams = value;
            }
        }

        public string BakingTechnique
        {
            get { return bakingTechnique; }
            private set
            {


                if (value == "crispy" || value == "chewy" || value == "homemade")
                {
                    bakingTechnique = value;
                }
                else
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
               
            }
        }

        public string FlourType
        {
            get { return flourType; }
            private set
            {


                if (value == "Wholegrain" || value == "wholegrain"
                    || value == "White" || value == "white")
                {
                    flourType = value;
                }
                else
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                
            }
        }

        public double DoughCalories()
        {
            double flourModifier = 0;
            double bakingModifier = 0;

           

            if (this.FlourType == "white")
            {
                flourModifier = 1.5;
            }
            else if (this.FlourType == "wholegrain")
            {
                flourModifier = 1.0;
            }


            if (this.BakingTechnique == "crispy")
            {
                bakingModifier = 0.9;
            }
            else if (this.BakingTechnique == "chewy")
            {
                bakingModifier = 1.1;
            }
            else if (this.BakingTechnique == "homemade")
            {
                bakingModifier = 1.0;
            }

             
           return (2 * this.Grams) * flourModifier * bakingModifier; 
        }
    }
}
