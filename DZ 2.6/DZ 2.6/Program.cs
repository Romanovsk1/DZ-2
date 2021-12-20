using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_2._6
{

    [Flags]
    enum WeekDays
    {

             Monday = 0b_1000000,        //                                  64
             Tuesday = Monday >> 1,      // 0b_0100000                       32
             Wednesday = Monday >> 2,      // 0b_1000000 >> 2 = 0b_0010000   16
             Thursday = Monday >> 3,      // 0b_1000000 >> 3 = 0b_0001000    8
             Friday = Thursday >> 1,    // 0b_0001000 >> 1 = 0b_0000100      4
             Saturday = Friday >> 1,      // 0b_0000100 >> 1 = 0b_0000010    2
             Sunday = Wednesday >> 4,   // 0b_0010000 >> 4 = 0b_0000001      1

             


             

    }

    internal class Program
    {
        static void Main(string[] args)
        {

            /* Для полного закрепления битовых масок,
             * попытайтесь создать универсальную структуру
             * расписания недели, к примеру, чтобы описать 
             * работу какого либо офиса.
             * Явный пример - офис номер 1 работает 
             * со вторника до пятницы, офис номер 2 работает 
             * с понедельника до воскресенья и выведите его на экран консоли.
             */

            WeekDays OfficeNumber1 = WeekDays.Tuesday & WeekDays.Wednesday & WeekDays.Thursday &
                WeekDays.Friday;
            WeekDays OfficeNumber2 = WeekDays.Monday & WeekDays.Tuesday & WeekDays.Wednesday &
             WeekDays.Thursday & WeekDays.Friday & WeekDays.Saturday & WeekDays.Sunday;

            

            WeekDays OF1 = (WeekDays)0b_0111100;
            WeekDays OF2 = (WeekDays)0b_1111111;


            //OF1 = OfficeNumber1;
            //OF2 = OfficeNumber2;
            
           
            Console.WriteLine("Введите день недели: ");


            string str = System.Console.ReadLine();
            WeekDays WeekDay = (WeekDays)Enum.Parse(typeof(WeekDays), str, ignoreCase: true);
            System.Console.WriteLine(WeekDay);


            switch (OfficeNumber1 | OF1 & OfficeNumber2 | OF2)
            { 
                case WeekDays.Monday:
                    System.Console.WriteLine("Не рабочий для 1 офиса. " + "Рабочий для 2 офиса.");
                    break;
                case WeekDays.Tuesday:
                    System.Console.WriteLine("Рабочий для 1 офиса. " + "Рабочий для 2 офиса.");
                    break;
                case WeekDays.Wednesday:
                    System.Console.WriteLine("Рабочий для 1 офиса. " + "Рабочий для 2 офиса.");
                    break;
                case WeekDays.Thursday:
                    System.Console.WriteLine("Рабочий для 1 офиса. " + "Рабочий для 2 офиса.");
                    break;
                case WeekDays.Friday:
                    System.Console.WriteLine("Рабочий для 1 офиса. " + "Рабочий для 2 офиса.");
                    break;
                case WeekDays.Saturday:
                    System.Console.WriteLine("Рабочий для 1 офиса. " + "Рабочий для 2 офиса.");
                    break;
                case WeekDays.Sunday:
                    System.Console.WriteLine("Не рабочий для 1 офиса. " + "Рабочий для 2 офиса.");
                    break;
                default:
                    System.Console.WriteLine("Не рабочий для 1 офиса. " + "Рабочий для 2 офиса.");
                    break;


                    
            }       
                   Console.ReadLine();
        }    
    
    }

}
