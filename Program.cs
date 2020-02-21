using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrija
{
    class Program
    {
        static void Main(string[] args)
        {
             duz Duz = new duz();
            Console.WriteLine("Unesite koordinate duzi");
           
            Console.WriteLine("Unesite koordinate prve tacke");
            double b = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Unesite drugu koordinatu prve tacke");
            double c = double.Parse(Console.ReadLine());
           
            Console.WriteLine("Unesite koordinatu druge tacke");
            double d = double.Parse(Console.ReadLine());
           
            Console.WriteLine("Unesite drugu koordinatu druge tacke");
            double e = double.Parse(Console.ReadLine());



            double a = Duz.duzinaDuza(b, c, d, e);
            Console.WriteLine(a);
           
           

            
                  
            
            

           



            Console.ReadKey();

        }
    }
     class duz
    {
        public double x1;
        public double y1;
        
        public double x2;
        public double y2;
         public duz()
        {
            x1 = 22;
            y1 = 25;

            x2 = 55;
            y2 = 65;
        }

        public double duzinaDuza(double x1, double y1, double x2, double y2)
        {
            if (x1 > x2 && y1 > y2)
            { 

                double duzina = Math.Sqrt((x1 - x2) + (y1 - y2));


            return duzina;
        }
            else
            {
                return 0;
            }
        }

    }
}
