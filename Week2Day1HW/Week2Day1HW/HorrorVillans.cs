using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day1HW
{
    class HorrorVillans
    {
        private bool hasMovies = true;
        private int numMovies;
        private bool hasMask;
        private bool hasSharpWepons;
        private bool hasMagicalProperties;
        private bool hasHerorinesThatDontDie;

        public HorrorVillans()
        {
        }

        public HorrorVillans(string myKiller)
        {
            //Console.WriteLine(myKiller);
        }

        public HorrorVillans(int initialNumMovies)
        {
            numMovies = initialNumMovies;
        }

        public bool HasMovies
        {
            get
            {
                return HasMovies;
            }
        }

        public int NumMovies
        {
            get
            {
                return numMovies;
            }

            set
            {
                if (value < 1)
                {
                    numMovies = 3;
                }
                else
                {
                    numMovies = value;
                }
            }
        }
    }
}
