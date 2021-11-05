using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Coin_Class_Project_Chapter_9
{
    class Coin
    {
        //Field to represent side up
        private string sideUp;

        Random Rand = new Random();

        //Constructor
        public Coin()
        {
            sideUp = "Heads";
        }

        //Toss method simulates tossing the coin
        public void Toss()
        {
            //Random Rand = new Random();
            if (Rand.Next(2) == 0)
            {
                sideUp = "Heads";

            }

            else
            {
                sideUp = "Tails";
            }

            
        }

        public string GetSideUp()
        {
            return sideUp;
        }
    }
}
