using System;
using System.Collections.Generic;
using System.Text;

namespace HWDay1
{
    class Task4
    {
        public void TaskT4()
        {
            string A, B;
            ConsoleKeyInfo Exit;
            do
            {
                Console.Clear();
                Console.WriteLine("TASK 4");
                Console.WriteLine("Press  - PRESS ANY KEY -  to Start...");
                Exit = Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Введите два целых положительных числа A и B (А < В)...\n");
                Console.WriteLine("A = "); A = Console.ReadLine();
                Console.WriteLine("B = "); B = Console.ReadLine();
                if (Int32.TryParse(A, out int Ai) && Int32.TryParse(B, out int Bi) &&
                    int.Parse(A) <= int.Parse(B) && int.Parse(A) >= 0)
                {
                    for (int i = Ai; i <= Bi; i++)
                    {
                        string temp = null;
                        for (int j = 0; j <= i - 1; j++)
                            temp += i.ToString();
                        Console.WriteLine(temp);
                    }
                    Console.WriteLine(
                        "Еще разок?..\n\n" +
                        "- PRESS ANY KEY -");
                }
                else
                {
                    Console.WriteLine(
                        "Попробуйте еще раз.  -! Необходимо соблюсти условия... !-\n\n" +
                        "- PRESS ANY KEY -");
                }
                Console.WriteLine("Для выхода нажать  - ESC -");
                Exit = Console.ReadKey();

            }
            while (Exit.Key != ConsoleKey.Escape);

            /*for (int i = int.Parse(A); i <= int.Parse(B); i++)
            {
                string temp = null;
                for (int j = 0; j <= i - 1; j++)
                    temp += i.ToString();
                Console.WriteLine(temp);
            }*/






        }
    }
}
