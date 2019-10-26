using System;
using System.Collections.Generic;
using System.Text;

namespace HWDay1
{
    class Task1
    {
        public void TaskT1()
        {
            Console.WriteLine("TASK 1");
            ConsoleKeyInfo Symbol;
            Console.WriteLine("Вводим символы (до \".\", считаем \"пробелы\"): ");
            /*
            // !!! зависимо от раскладки клавиатуры
            int countSpase = 0;
            do
            {
                Symbol = Console.ReadKey();
                if (Symbol.Key == ConsoleKey.Spacebar)
                    countSpase++;
            }
            while (Symbol.Key != ConsoleKey.Oem2);
            Console.WriteLine("\nКоличество введенных пользователем пробелов = " + countSpase + "\n" +
                "_____________________________\n");*/

            // !!! НЕзависимо от раскладки клавиатуры
            int countSpace2 = 0;
            do
            {
                Symbol = Console.ReadKey();
                if (Symbol.KeyChar == ' ')
                    countSpace2++;
            }
            while (Symbol.KeyChar != '.');
            Console.WriteLine("\nКоличество введенных пользователем пробелов = " + countSpace2);
            Console.ReadKey();
        }
    }
}
