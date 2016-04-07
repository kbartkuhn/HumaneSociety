using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humanesociety
{
    class userinterface
    {

        Person person = new Person();
        Adoptioncenter adopt = new Adoptioncenter();
        Dog dog = new Dog("john", "breedofdog", 1, 1, 1);
        Cat cat = new Cat("taco", "taco", 1, 1, 1);
        Adopter adopter = new Adopter("fernando", "lary", 1);
        int choice;
 
        public void addanimals()
        {
            adopt.addcats();
            adopt.adddogs();
        }
        public int startingstuff()
        {
            Console.WriteLine("Hello, welcome to the Humane Society.");
            Console.WriteLine("To adopt an animal enter [1], to drop off an animal enter [2]");
            choice = int.Parse(Console.ReadLine());
            return choice;
        }
        public void adoptionmenu()
        {
            if (choice == 1)
            {
                person.addtoadopterlist();
                if (adopter.typeofspecies == 1)
                {
                    adopt.displaydoglist();
                    Console.WriteLine("Which dog would you like to adopt?");
                    string dogchoice = Console.ReadLine();
                    foreach (Dog dog in adopt.DogCages)
                    {
                        if (dogchoice.Equals(dog.nameofanimal, StringComparison.CurrentCultureIgnoreCase))
                        {
                            adopt.DogCages.Remove(dog);
                            Console.WriteLine("Congradulations you have adopted {0}", dog.nameofanimal);
                            Console.WriteLine("The adoption fee for animal in this shelter is $250");
                            adopt.adoptionfee();
                            afteradoption();
                        }
                        else
                        {
                            Console.WriteLine("That was an invalid entry, please try again.");
                            adoptionmenu();
                        }
                    }
                }
                else if (adopter.typeofspecies == 2)
                {
                    adopt.displaycatlist();
                    Console.WriteLine("Which cat would you like to adopt? Please enter the cats name to continue.");
                    string catchoice = Console.ReadLine();
                    foreach (Cat cat in adopt.CatCages)
                    {
                        if (catchoice.Equals(cat.nameofanimal, StringComparison.CurrentCultureIgnoreCase))
                        {
                            adopt.CatCages.Remove(cat);
                            Console.WriteLine("Congradulations, you have adopted {0}, he's a stupid cat", cat.nameofanimal);
                            adopt.adoptionfee();
                            afteradoption();
                        }
                        else
                        {
                            Console.WriteLine("That was an invalid entry, please try again.");
                            adoptionmenu();
                        }
                    }
                }
            }
            else if (choice == 2)
            {
                Console.WriteLine("Are you dropping off a cat or a dog? 1 for dog, 2 for cat");
                int dropoffchoice = int.Parse(Console.ReadLine());
                if (dropoffchoice == 1)
                {
                    adopt.adddog();
                    if (adopt.shots==2)
                    {
                        shotdecide();
                    }
                    else
                    {
                        afteradoption();
                    }
                }
                else if (dropoffchoice == 2)
                {
                    adopt.addacat();
                    if (adopt.shots == 2)
                    {
                        shotdecide();
                    }
                    else
                    {
                        afteradoption();
                    }
                }
            }

        }

        public void shotdecide()
        {
            Console.WriteLine("Would you like to get your animal up to date on his shots? Y/N");
            string shotshot = Console.ReadLine();
            switch (shotshot)
            {
                case "Y":
                    dog.giveshot();
                    Console.WriteLine("Your dog is now up to date on his shots");
                    afteradoption();
                    break;
                case "N":
                    Console.WriteLine("No wonder you are giving up your dog.");
                    afteradoption();
                    break;
                default:
                    Console.WriteLine("Invalid entry");
                    shotdecide();
                    break;
            }
        }

        public void afteradoption()
        {
            Console.WriteLine("Would you like to stay and do something else or leave the society?");
            Console.WriteLine("Please enter [S] to stay or [L] for leave.");
            string stayorgo = Console.ReadLine();
            switch (stayorgo)
            {
                case "S":
                    startingstuff();
                    adoptionmenu();
                    break;
                case "L":
                    Console.WriteLine("Have a nice day!");
                    break;
                default:
                    Console.WriteLine("Invalid entry");
                    afteradoption();
                    break;
            }
        }


    }

}

