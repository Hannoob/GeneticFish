using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fish
{
    public class Food
    {
        public static List<Food> food = new List<Food>();

        public static int SpawnRate = 2;
        public static double SpawnProb = 100;
        public static int MaxFood = 250;

        private static Random random = new Random(88554);

        public Guid id { get; set; }
        public int Nutrition{ get; set; }
        public Point Position { get; set; }
        private double posX;
        private double posY;

        public Food() : this(10, 10, 10) { }

        public Food(int x, int y, int nutrition)
        {
            this.id = Guid.NewGuid();
            this.Nutrition = nutrition;
            this.Position = new Point(x, y);
            posX = x;
            posY = y;
        }

        public static void Drift(double x, double y)
        {
            food.ForEach(f =>
            {
                f.posX = f.posX + x*((double) f.Nutrition / 100);
                f.posY = f.posY + y*((double) f.Nutrition / 100);

                f.Position = new Point((int)f.posX, (int)f.posY);
            });
        }

        public static void Spawn(int width, int height)
        {
            if ((random.Next(1, 100) <= SpawnProb) && (food.Count < MaxFood))
            {
                for (int i = 0; i < SpawnRate; i++)
                {
                    var x = random.Next(width);
                    var y = random.Next(height);
                    food.Add( new Food(x, y, random.Next(1,5)) );
                }
            }
        }
    }
}
