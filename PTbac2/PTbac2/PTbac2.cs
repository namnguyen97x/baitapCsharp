using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTbac2
{
   class PTbac2
    {
        private double a { get; set; }
        private double b { get; set; }
        private double c { get; set; }
        private double delta;
        private double x;
        public PTbac2(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void Cal()
        {
            if (a != 0)
            {
                delta = Math.Pow(b, 2) - 4 * a * c;
                if(delta > 0)
                {
                    Console.WriteLine($"Phương trình có 2 nghiệm phân biệt: \nx1 = {(-b + Math.Sqrt(delta)) / (2 * a)}" +
                        $"\nx2 = {(-b - Math.Sqrt(delta)) / (2 * a)}");
                } else if (delta == 0)
                {
                    Console.WriteLine($"Phương trình có nghiệm kép -b / 2 * a : {-b / (2 * a)}");
                } else
                {
                    Console.WriteLine("Phương trình vô nghiệm");
                }
               

            } else
            {
                Console.WriteLine("Phương trình trở thành bậc 1 có dạng: bx + c = 0");
                if (b != 0)
                {
                    x = -c / b;
                    Console.WriteLine($"ta có nghiệm là x = - c / b : {x} ");
                } else
                {
                    if( c == 0)
                    {
                        Console.Write("Phương trình có vô số nghiệm");
                    }
                    else
                    {
                        Console.Write("Phương trình có vô nghiệm");
                    }
                }
            }
        }
    }
}
