using System.Diagnostics;

namespace Week4Project2
{
    internal class Program
    {
        public static Random random;
        static void Main(string[] args)
        {
            random = new Random();

            
            Rectangle r = new Rectangle();
            MakeRectangle(out r.w, out r.l, 1, 50);

            Console.WriteLine("Length: " + r.l);
            Console.WriteLine("Width: " + r.w);
            Console.WriteLine("Area: " + Utility.Area(r.w, r.l));
            Console.WriteLine("Perimeter: " + Utility.Perimeter(r.w, r.l));
           
        }

        public static void MakeRectangle(out int w, out int l, int min, int max)
        {
            w = random.Next(min, max);
            l = random.Next(min, max);
        }
    }

    public class Rectangle
    {
        public int w;
        public int l;
        

        public Rectangle()
        {
            w = 0;
            l = 0;
        }

    }

    public class Utility
    {

        public static int Area(int w, int l)
        {
            return w * l;
         }

        public static int Perimeter(int w, int l)
        {
            return 2 * (l + w);
        }
    }
}