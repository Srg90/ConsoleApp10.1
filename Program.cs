using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task101 variant1 = new Task101(3, 58, 12);
            
            Console.Write("Градус: ");
            Console.WriteLine(variant1.Gradus);
            Console.Write("Минуты: ");
            Console.WriteLine(variant1.Minuts);
            Console.Write("Секунды: ");
            Console.WriteLine(variant1.Secunds);
            variant1.ToRadians();
            Console.ReadKey();
        }
    }

    class Task101
    {
        double gradus;
        double min;
        double sec;

        public double Gradus
        {

            set
            {
                
                if (value < 361 & value > -361)
                {
                    gradus = value;
                }
                else
                {
                    Console.WriteLine("Значение градуса введено неккоректно");
                }
                    
            }
            get
            {
                return gradus;
            }
        }
        public double Minuts
        {

            set
            {

                if (value < 61 & value >= 0)
                {
                    min = value;
                }
                else
                {
                    Console.WriteLine("Значение минут введено неккоректно");
                }

            }
            get
            {
                return min;
            }
        }
        public double Secunds
        {

            set
            {

                if (value < 61 & value >= 0)
                {
                    sec = value;
                }
                else
                {
                    Console.WriteLine("Значение секунд введено неккоректно");
                }

            }
            get
            {
                return sec;
            }
        }

        public Task101(double gradus, double min, double sec)
        {
            this.Gradus = gradus;
            this.Minuts = min;
            this.Secunds = sec;

        }

        public void ToRadians()
        {
            
            if (gradus < 0 & min >=0 & sec >= 0)
            {
                double R = (gradus - min / 60 - sec / 3600) * (Math.PI) / 180;
                Console.WriteLine();
                Console.WriteLine("Заданный угол в радианах = {0}", Math.Round(R, 5));
            }
            else if (gradus > 0 & min >= 0 & sec >= 0)
            {
                double R = (gradus + min / 60 + sec / 3600) * (Math.PI) / 180;
                Console.WriteLine();
                Console.WriteLine("Заданный угол в радианах = {0}", Math.Round(R, 5));
            }
        }
    }
}
