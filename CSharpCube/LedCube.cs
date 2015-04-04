using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCube
{
    class Led
    {
        public int x = 0;
        public int y = 0;
        public int z = 0;
        public Led(int _x, int _y, int _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }
    }

    class LedCube
    {
        public string command = "{000FF0000}";
        public Led[] leds = new Led[64];
        int idx = 0; 
        int x = 0;
        int y=0;
        int z=0;
        public LedCube() {
            for (x = 0; x < 4; x=x+1) 
            {
              for (y=0; y<4;y=y+1) 
              {
                for (z=0; z<4; z=z+1) 
                {
                   leds[idx] = new Led(x,y,z);
                   idx++;
                }
              }
            }
        }

    }
}
