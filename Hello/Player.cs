using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Player
    {
        public string name = "Sunny";
        private int health = 100;
        public int getHealth(int h)
        {
            return health;
        }
        public void setHealth(int h) {
            health = h;
        }
    }
}
