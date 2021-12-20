using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Запросить у пользователя порядковый номер текущего месяца и вывести его название.


            Console.WriteLine("Здравствуйте, введите номер текущего месяца: ");


            int operation = Convert.ToInt32(Console.ReadLine());


            switch (operation)
            {
                case 1:
                    Console.WriteLine("Январь");
                    break;
                case 2:
                    Console.WriteLine("Февраль");
                    break;
                case 3:
                    Console.WriteLine("Март");
                    break;
                case 4:
                    Console.WriteLine("Апрель");
                    break;
                case 5:
                    Console.WriteLine("Май");
                    break;
                case 6:
                    Console.WriteLine("Июнь");
                    break;
                case 7:
                    Console.WriteLine("Июль");
                    break;
                case 8:
                    Console.WriteLine("Август");
                    break;
                case 9:
                    Console.WriteLine("Сентябрь");
                    break;
                case 10:
                    Console.WriteLine("Октябрь");
                    break;
                case 11:
                    Console.WriteLine("Ноябрь");
                    break;
                case 12:
                    Console.WriteLine("Декабрь");
                    break;
                default:
                    Console.WriteLine("Неизвестная операция");
                    break;
            }


            //Запросить у пользователя минимальную и максимальную температуру за сутки
            //и вывести среднесуточную температуру


            Console.WriteLine("Напишите минимальную температуру за сутки:");
            double tMinimal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Теперь напишите максимальную температуру за сутки:");
            double tMaximal = Convert.ToDouble(Console.ReadLine());


            if (tMinimal > tMaximal)                   // если минимальная > максимальной то вывести
                Console.WriteLine("К сожалению вы перепутали значения минимальная температура" +
                    " и максимальная температура, ни чего страшного мы всёравно посчитаем=)");

            
            double tSR = (tMinimal + tMaximal) / 2;                  //Средняя температура
            Console.WriteLine($"Средняя температура за сутки:{tSR}");


            // Если пользователь указал месяц из зимнего периода,
            // а средняя температура > 0, вывести сообщение «Дождливая зима».


            if (tSR > 0 && operation == 1)             //январь
                Console.WriteLine("Дождливая зима");   
            else if (tSR > 0 && operation == 2)        //февраль
                Console.WriteLine("Дождливая зима");
            else if (tSR > 0 && operation == 12)       //декабрь
                Console.WriteLine("Дождливая зима");
            

            if (tSR < 15 && operation == 6)            //если средняя температура < 15 и месяц Июнь
                Console.WriteLine("Прохладный июнь");  
            else if (tSR > 35)                         //если средняя температура > 35
                Console.WriteLine("Жаркий денёк)");
            
        }
}   }    
