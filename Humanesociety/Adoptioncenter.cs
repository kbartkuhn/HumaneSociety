using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humanesociety
{
    class Adoptioncenter : Animal
    {
        public List<Dog> listofdogs = new List<Dog>();



        public int bankaccount;


        public int adoptionfee()
        {
            bankaccount += 250;
            return bankaccount;
        }

        public void adddogs()
        {
            listofdogs.Add(new Dog("Fuzzy", "Yellowlab", 1, 1, 3));
            listofdogs.Add(new Dog("Spots", "Rotweiler", 2, 1, 3));
            listofdogs.Add(new Dog("Tim", "blacklab", 1, 1, 3));
            listofdogs.Add(new Dog("Jimbobaggins", "rotweiler", 1, 3, 5));
        }


        public void displaycatlist()
        {
            Console.WriteLine("Here are all the cats we currently have for adoption");
            foreach (Cat cat in listofcats)
            {
                Console.WriteLine("Name : {0} Breed : {1}", cat.nameofanimal, cat.breed);
            }
        }

        public void displaydoglist()
        {
            Console.WriteLine("Here are all the dogs we currently have for adoption.");
            foreach (Dog dog in listofdogs)
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
            listofdogs.Add(new Dog(dogname, dogbreed, shottyshots, food, cupsoffood));
            return food;
        }

        public List<Cat> listofcats = new List<Cat>();

        Cat tom = new Cat("tom", "siemese", 1, 2, 2);
        Cat lucy = new Cat("lucy", "calico", 1, 2, 2);
        Cat sparkles = new Cat("Sparkles", "britishshorthair", 2, 1, 1);
        Cat princess = new Cat("princess", "mainecoon", 1, 1, 1);
        public void addcats()
        {
            listofcats.Add(tom);
            listofcats.Add(lucy);
            listofcats.Add(sparkles);
            listofcats.Add(princess);
        }
        public int addacat()
        {
            string catname = getpetName();
            string catbreed = getanimalBreed();
            int shots = animalhaveshots();
            int food = getFoodType();
            int cupsofstuff = getamountoffood();
            listofcats.Add(new Cat(catname, catbreed, shots, food, cupsofstuff));
            int catindex = (listofcats.Count() - 1);
            return catindex;
        }

        public List<Cage> cages;
        public Adoptioncenter()
        {
            cages = new List<Cage>();
        }
        public void addAnimal(Animal animal)
        {
            cages.Add(new Cage(animal));
        }
    }

}

