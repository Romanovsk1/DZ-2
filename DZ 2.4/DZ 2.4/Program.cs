using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Для полного закрепления понимания простых типов найдите
             * любой чек, либо фотографию этого чека в интернете 
             * и схематично нарисуйте его в консоли, только за место динамических,
             * по вашему мнению, данных (это может быть дата, название магазина, сумма покупок)
             * подставляйте переменные, которые были заранее заготовлены до вывода на консоль.              
             */


            DateTime dateTime = DateTime.Now;
            string NameMagazin = "Ресторан KFC";
            int OrderNumber = 229;
            int KKTNumber = 5965;
            decimal INNNumber = 63545435435;
            decimal a1 = 99.9m;
            decimal a2 = 19.9m;
            decimal a3 = 19.9m;
            decimal a4 = 99.9m;
            decimal a5 = 75.9m;
            decimal a6 = 99.9m;
            decimal allsymma = a1 + a2 + a3 + a4 + a5 + a6;
            int KolTovPosition = 6;
            int DokNumber = 129168;
            int SaleNumber = 84;
            byte KASSANumber = 1;


            Console.WriteLine($"                    {NameMagazin}                    ");
            Console.WriteLine("______________________________________________________"); 
            Console.WriteLine($"ККТ № {KKTNumber}                         ИНН: {INNNumber}  "); 
            Console.WriteLine($"Заказ № {OrderNumber}");
            Console.WriteLine("Код ресторана Козлов Артём");
            Console.WriteLine("                  *  КАССОВЫЙ ЧЕК  *                    ");
            Console.WriteLine($"Картофель фри большой                              {a1}");
            Console.WriteLine($"Соус сырный                                        {a2}");
            Console.WriteLine($"Соус кисло-сладкий чилли                           {a3}");
            Console.WriteLine($"Шефбургер                                          {a4}");
            Console.WriteLine($"Кока-кола 0.5л                                     {a5}");
            Console.WriteLine($"Купон 1737 Чизбургер + Миринда 0.3л                {a6}");
            Console.WriteLine($"Количество товарных позиций                        {KolTovPosition} ");
            Console.WriteLine("_______________________________________________________");
            Console.WriteLine($"ИТОГ                                             * {allsymma}");
            Console.WriteLine("КАССИР Козлов Артём                                    ");
            Console.WriteLine($"ДАТА {dateTime}                                       ");
            Console.WriteLine($"ДОК. № {DokNumber}                        Продажа № {SaleNumber}   ");
            Console.WriteLine($"Касса № {KASSANumber}                              ФП ");
            Console.WriteLine("  ЭКЛЗ 42100996541                                     ");
            Console.WriteLine("  00022887 #013196                                     ");
            
            
            Console.ReadLine();


        }
    }
}
