using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Определить, является ли введённое пользователем число чётным.


            Console.WriteLine("Введите число и эта программа определит чётное оно или нет:");
            

            int ch = Convert.ToInt32(Console.ReadLine());

            
            if (ch % 2 == 1)
                Console.WriteLine("Не чётное");
            else 
                Console.WriteLine  ("Чётное");


            Console.ReadLine();


        }
    }
}
