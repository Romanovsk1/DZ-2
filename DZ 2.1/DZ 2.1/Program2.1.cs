using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Запросить у пользователя минимальную и максимальную температуру за сутки
            //и вывести среднесуточную температуру.


            Console.WriteLine("Здравствуйте, напишите минимальную температуру за сутки:");
            double tMinimal = Convert.ToDouble(Console.ReadLine());

            
            Console.WriteLine("Теперь напишите максимальную температуру за сутки:");
            double tMaximal = Convert.ToDouble(Console.ReadLine());
            

            double tSR = (tMinimal + tMaximal) / 2 ;                //Средняя температура
            Console.WriteLine(tSR);

        }
    }
}
