using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Week2Day1HW
{
    class VideoGameSystem
    {
        private bool hasControllers = true;
        private int numControllers;
        private bool hasWifi;
        private bool hasCartridges;
        private bool hasCD;
        private bool hasDigitalDownload;

        public VideoGameSystem()
        {
        }

        public VideoGameSystem(string myNintendo)
        {
            //Console.WriteLine(myNintendo);
        }

        public VideoGameSystem(int initialNumControllers)
        {
            numControllers = initialNumControllers;
        }

        public bool HasControllers
        {
            get
            {
                return HasControllers;
            }
        }

        public int NumControllers
        {
            get
            {
                return numControllers;
            }

            set
            {
                if (value < 1)
                {
                    numControllers = 2;
                }
                else
                {
                    numControllers = value;
                }
            }
        }
    }
}
