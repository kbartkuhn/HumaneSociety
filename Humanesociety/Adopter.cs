using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humanesociety
{
   public class Adopter : Person

       
    {

        public string firstadoptername;
        public string lastadoptername;
        public int typeofspecies;
        public Adopter(string adoptfirstName, string adoptlastName, int speciesofinterest)
        {
            firstadoptername = adoptfirstName;
            lastadoptername = adoptlastName;
            typeofspecies = speciesofinterest;

             
        }
    }
}
