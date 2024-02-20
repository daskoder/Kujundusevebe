using System.Drawing;

namespace Kujundusevebe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geomeetri kujundi valik: ruut, ristkülik, ring ja teemant");
            Console.WriteLine("----------------------------------------------------------");
            string a = Console.ReadLine();
            if (a == "ruut")
            {
                ruut();
            }
            else if (a =="ristkülik")
            {
                ristkülik();
            }
            else if (a =="ring")
            {
                ring();
            }                   
            else if (a == "teemant")
            {
                teemant();
            }
            else 
            {
                Console.WriteLine("ERROR");
            }
        }
        static void ruut()
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Sisesta ruudu suurus");
            int size = int.Parse(Console.ReadLine());
            for (int row = 1; row <= size; row++)
            {
                for (int column = 1; column <= size; column++)
                {
                    string mark;
                    if (row == column || row + column <= size + 1)
                    {
                        mark = "*";
                    }
                    else
                    {
                        mark = "*";
                    }
                    Console.Write(mark);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Ruudu pindala on " + size * size +
                " ja ümbermmõõt on " + size * 4 + " ühikut");

        }
        static void ristkülik()
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Sisesta ristküliku kõrgus");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Sisesta ristküliku laius");
            int c = int.Parse(Console.ReadLine());
            for (int row = 0;row<b;row++)
            {
                for (int bruh = 1; bruh<=c;bruh++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Ristküliku ümbermõõt on "+2*(b+c)+" ja pindala on "+ b*c + " ühikut");
        }
        static void ring()
        {
            Console.WriteLine("----------------------------------------------------------");
            
            
            double radius;
            double thickness = 0.4;

            char symbol = '*';

            do
            {
                Console.WriteLine("Sisesta ringi raadius");
                if (!double.TryParse(Console.ReadLine(), out radius) || radius <= 0)
                {
                    Console.WriteLine("radius peab olema positiivne number");
                }
            }
            while (radius <= 0);

            Console.WriteLine();
            double rIn = radius - thickness, rOut = radius + thickness;

            for (double y = radius; y >= -radius; --y)
            {
                for (double x = -radius; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            double ymbermoot = 2 * (Math.PI * radius);
            Console.WriteLine("Ringi ümbermõõt on: " + ymbermoot+ " ühikut");
            double pindala = Math.PI * (radius * radius);
            Console.WriteLine("Ringi pindala on: " + pindala + " ühikut");

            Console.ReadKey();
        }
        static void teemant()
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Sisesta teemanti külge suurus");
            Console.WriteLine("----------------------------------------------------------");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------------------------");
            int i, j, count = 1;
            count = number - 1;
            for (j = 1; j <= number; j++)
            {
                for (i = 1; i <= count; i++)
                    Console.Write(" ");
                count--;
                for (i = 1; i <= 2 * j - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
            count = 1;
            for (j = 1; j <= number - 1; j++)
            {
                for (i = 1; i <= count; i++)
                    Console.Write(" ");
                count++;
                for (i = 1; i <= 2 * (number - j) - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Teemandi ümbermõõt on "+ 4*number+ " ja pindala on "+ (2*number-1)+ " ühikut");
            
            
        }












    }
}