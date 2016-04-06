using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humanesociety
{
   public class Person
    {
        public string firstname;
        public string lastname;
        public int getspecies;
        public int animalofinterest;

        public List<Adopter> listofadopters = new List<Adopter>();
    public string getfirstname()
        {
            Console.WriteLine("What is your first name?");
            firstname = Console.ReadLine();
            return firstname;
        }
    public string getlastname ()
        {
            Console.WriteLine("What is your last name?");
            lastname = Console.ReadLine();
            return lastname;
        }
    public int getspeciestype()
        {
            Console.WriteLine("What type of species are you interested in adopting?");
            Console.WriteLine("1 for dogs or 2 for cats");
            int getspecies = int.Parse(Console.ReadLine());
            return getspecies;
        }
        public int addtoadopterlist()
        {
            string name1 = getfirstname();
            string name2 = getlastname();
            animalofinterest = getspeciestype();
            listofadopters.Add(new Adopter(name1, name2, animalofinterest));
            return animalofinterest;
        }
     }
}
