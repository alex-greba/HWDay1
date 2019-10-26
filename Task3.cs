using System;
using System.Collections.Generic;
using System.Text;

namespace HWDay1
{
    class Task3
    {
        public void TaskT3()
        {
            Console.Clear();
            Console.WriteLine("TASK 3");
            Console.WriteLine("Для ВЫХОДА - нажмите  - ESC -\n" +
                "Необходимо вводить символы (для \"смены регистра\")... После ввода нажмите  - ENTER -\n");

            ConsoleKeyInfo Symbol;
            string textOriginal = null;
            string textShift = null;
            do
            {
                Symbol = Console.ReadKey();
                if (Symbol.Key != ConsoleKey.Enter)
                {
                    textOriginal += Symbol.KeyChar.ToString() + " ";
                    if ((Symbol.KeyChar >= 65 && Symbol.KeyChar <= 90) || (Symbol.KeyChar >= 1040 && Symbol.KeyChar <= 1071))
                    {
                        //int temp = Symbol.KeyChar + 32;
                        //char s = Convert.ToChar(temp);
                        //Console.WriteLine(s);
                        textShift += Convert.ToChar(Symbol.KeyChar + 32) + " ";
                    }
                    else if ((Symbol.KeyChar >= 97 && Symbol.KeyChar <= 122) || (Symbol.KeyChar >= 1072 && Symbol.KeyChar <= 1103))
                    {
                        textShift += Convert.ToChar(Symbol.KeyChar - 32) + " ";
                    }
                    else textShift += "- ";
                }
                else
                {
                    Console.WriteLine("       Оригинал: " + textOriginal);
                    Console.WriteLine("Правка Регистра: " + textShift);
                    //GoTo было бы самое - то
                    Console.WriteLine("\nДля ВЫХОДА - нажмите  - ESC -\n" +
                        "Ещё разок?..\n" +
                        "Необходимо вводить символы... (После ввода нажмите  - ENTER -)\n");
                    textOriginal = null;
                    textShift = null;

                };

            }
            while (Symbol.Key != ConsoleKey.Escape);



        }
    }
}
