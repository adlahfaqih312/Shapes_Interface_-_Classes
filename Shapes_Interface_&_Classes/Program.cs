namespace Shapes_Interface___Classes
{
    internal class Program
    {
        public interface IShape
        {
           public double CalculateArea();

        }
        public class Circle : IShape
        {
            public int r;
            public static double pi=3.14;
            public Circle(int r)
            {
                this.r = r;
            }
            
            public double CalculateArea()
            {
                int radious = this.r;
                double area = 0;
                area = pi * (radious * radious);
                Console.WriteLine(area);
                return area;
            }

        }
        public class Rectangular : IShape
        {
            public int a, b;
            public Rectangular(int a,int b)
            {
                this.a = a;
                this.b = b;
            }
            public double  CalculateArea()
            {
                int width = this.a;
                int length = this.b;
                int area = 0;
                area = width * length;
                Console.WriteLine(area);
                return area;
            }

        }
        static void Main(string[] args)
        {
            int r = 2;
            int width = 2;
            int length = 2;
            IShape circle = new Circle(r);
            IShape rectangle = new Rectangular(width,length);
            Console.Write("The area of the Circle when R=2 : "); circle.CalculateArea();
            Console.Write("The area of the Rectangle when width=2 & length=2 : "); rectangle.CalculateArea();
        }
    }
}
