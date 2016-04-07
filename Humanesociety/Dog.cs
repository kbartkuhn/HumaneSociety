using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humanesociety
{
    public class Dog : Animal
    {
        
     
        public Dog(string Name, string breedofdog, int Shots, int typeoffood, int foodquanity)
        {
            nameofanimal = Name;
            breed = breedofdog;
            shots = Shots;
            foodpreference = typeoffood;
            amountoffood = foodquanity;
        }
        public List<Dog> listofdogs = new List<Dog>();

        public int giveshot()
        {
            shots = 1;
            return shots;
        }














    }
}
