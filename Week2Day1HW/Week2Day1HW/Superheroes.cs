using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day1HW
{
    class Superheroes
    {
        private bool hasPowers = true;
        private int numCape;
        private bool hasAlterEgo;
        private bool hasSuperherocar;
        private bool hasLoveInterest;
        private bool hasCape;

        public Superheroes()
        {
        }

        public Superheroes(string myHero)
        {
            //Console.WriteLine(myHero);
        }

        public Superheroes(int initialNumCape)
        {
            numCape = initialNumCape;
        }

        public bool HasPowers
        {
            get
            {
                return HasPowers;
            }
        }

        public int NumCapes
        {
            get
            {
                return numCape;
            }

            set
            {
                if (value <= 0)
                {
                    numCape = 0;
                }
                else
                {
                    numCape = value;
                }
            }
        }
    }
}
