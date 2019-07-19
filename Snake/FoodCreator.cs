using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator
    {
        int MapWidht;
        int MapHeight;
        char sym;

        Random random = new Random();
        public FoodCreator(int MapWidht, int MapHeight, char sym)
        {
            this.MapWidht = MapWidht;
            this.MapHeight = MapHeight;
            this.sym = sym;
        }
        public Point CreateFood()
        {
            int x = random.Next(2, MapWidht - 2);
            int y = random.Next(2, MapHeight - 2);
            return new Point(x, y, sym);
        }
    }
}
