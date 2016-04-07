using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humanesociety
{
    public abstract class Animal
    {
        public string nameofanimal;
        public string breed;
        public int shots;
        public int foodpreference;
        public int amountoffood;
        public bool medicalshots;
        
        
        public string getpetName()
        {
            Console.WriteLine("What is the name of the pet?");
            nameofanimal = Console.ReadLine();
            return nameofanimal;
        }
        public string getanimalBreed()
        {
            Console.WriteLine("Do you know what the breed of the animal is?, If so, please provide ");
            breed = Console.ReadLine();
            return breed;
        }
        public int getFoodType()
        {
            Console.WriteLine("What type of food does the animal like? 1) Dry Food 2) Wet food or 3) meat?");
            foodpreference = int.Parse(Console.ReadLine());
            return foodpreference;
        }
        public int animalhaveshots()
        {
            Console.WriteLine("Is the animal up to date on its shots? Please enter 1 for yes and 2 for no");
            shots = int.Parse(Console.ReadLine());
            return shots;
        }

            public bool checkshots()
        {
           if (shots == 1)
                medicalshots = true;
            else medicalshots = false;
            return medicalshots;
        }
        
        public int getamountoffood()
        {
            Console.WriteLine("How many cups of food does the animal eat per day?");
            amountoffood = int.Parse(Console.ReadLine());
            return amountoffood;
        }
        
       
    }
}

