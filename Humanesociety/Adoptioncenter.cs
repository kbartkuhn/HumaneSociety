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


       Dog fernando = new Dog("Fernando", "Blacklab", 1, 1, 3);
        public void adddogs()
        {
            DogCages.Add(new Dog("Fuzzy", "Yellowlab", 1, 1, 3));
            DogCages.Add(new Dog("Spots", "Rotweiler", 2, 1, 3));
            DogCages.Add(fernando);
            DogCages.Add(new Dog("Jimbobaggins", "Rotweiler", 1, 3, 5));
        }


        public void displaycatlist()
        {
            Console.WriteLine("Here are all the cats we currently have for adoption");
            foreach (Cat cat in CatCages)
            {
                Console.WriteLine("Name: {0}", cat.nameofanimal);
                Console.WriteLine("Breed : {0}", cat.breed);
                Console.WriteLine("");
            }
        }

        public void displaydoglist()
        {
            Console.WriteLine("Here are all the dogs we currently have for adoption.");
            foreach (Dog dog in DogCages)
            {
                Console.WriteLine("Name: {0}", dog.nameofanimal);
                Console.WriteLine("Breed : {0}", dog.breed);
                Console.WriteLine("");
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

        Cat tom = new Cat("Tom", "Siemese", 1, 2, 2);
        Cat lucy = new Cat("Lucy", "Calico", 1, 2, 2);
        Cat sparkles = new Cat("Sparkles", "British Shorthair", 2, 1, 1);
        Cat princess = new Cat("Princess", "Maine Coon", 1, 1, 1);
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

