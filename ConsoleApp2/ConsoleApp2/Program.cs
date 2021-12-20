using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte r1 = 4;
            short t1 = 345;

            int myfirst = int.MinValue;
            int mysecond = int.MaxValue;

            long my3 = long.MinValue;
            long my4 = long.MaxValue;
            
            double a3 = 5354353.53d;
            decimal b1 = 525432643645646356363m;

            bool a1 = true;
            bool a2 = false;


            bool isEveryth = r1 == 4;
            System.Console.WriteLine(isEveryth);

            bool is7= t1 < 350 && t1 > 3500; // && = и
            // || = или 
            System.Console.WriteLine(is7);

            bool a = true;
            bool b = false;
            bool c = true;
            
            bool d = a == true && b == true;

            System.Console.WriteLine(c);

            int u1 = 10;
            int u2 = 15;
            int u3 = u1 + u2;

            

            switch (u3)
            {
                case 0:
                    {

                        System.Console.WriteLine("10");

                        break;
                    }
                case 25:
                    {
                        System.Console.WriteLine("25");
                        break;
                    }
            
            
            
            
            
            
            
            
            }


            








        }

        
        
            
        }
    }

