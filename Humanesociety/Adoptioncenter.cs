using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humanesociety
{
    class Adoptioncenter : Animal
    {
        public List<Dog> DogCages = new List<Dog>();



        public int bankaccount;


        public int adoptionfee()
        {
            bankaccount += 250;
            return bankaccount;
        }

        public void adddogs()
        {
            DogCages.Add(new Dog("Fuzzy", "Yellowlab", 1, 1, 3));
            DogCages.Add(new Dog("Spots", "Rotweiler", 2, 1, 3));
            DogCages.Add(new Dog("Tim", "blacklab", 1, 1, 3));
            DogCages.Add(new Dog("Jimbobaggins", "rotweiler", 1, 3, 5));
        }


        public void displaycatlist()
        {
            Console.WriteLine("Here are all the cats we currently have for adoption");
            foreach (Cat cat in CatCages)
            {
                Console.WriteLine("Name : {0} Breed : {1}", cat.nameofanimal, cat.breed);
            }
        }

        public void displaydoglist()
        {
            Console.WriteLine("Here are all the dogs we currently have for adoption.");
            foreach (Dog dog in DogCages)
            {
                Console.WriteLine("Name : {0} Breed : {1}", dog.nameofanimal, dog.breed);
            }
        }
        public int adddog()
        {
            string dogname = getpetName();
            string dogbreed = getanimalBreed();
            int shottyshots = animalhaveshots();
            int food = getFoodType();
            int cupsoffood = getamountoffood();
            DogCages.Add(new Dog(dogname, dogbreed, shottyshots, food, cupsoffood));
            return shottyshots;
        }

        public List<Cat> CatCages = new List<Cat>();

        Cat tom = new Cat("tom", "siemese", 1, 2, 2);
        Cat lucy = new Cat("lucy", "calico", 1, 2, 2);
        Cat sparkles = new Cat("Sparkles", "britishshorthair", 2, 1, 1);
        Cat princess = new Cat("princess", "mainecoon", 1, 1, 1);
        public void addcats()
        {
            CatCages.Add(tom);
            CatCages.Add(lucy);
            CatCages.Add(sparkles);
            CatCages.Add(princess);
        }
        public int addacat()
        {
            string catname = getpetName();
            string catbreed = getanimalBreed();
            int shots = animalhaveshots();
            int food = getFoodType();
            int cupsofstuff = getamountoffood();
            CatCages.Add(new Cat(catname, catbreed, shots, food, cupsofstuff));
            return food;
        }

        
        
   
    }

}

