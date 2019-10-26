using System;
using System.Collections.Generic;
using System.Text;

namespace HWDay1
{
    class Task5
    {
        public void TaskT5()
        {
            Console.Clear();
            Console.WriteLine("TASK 5");
            Console.WriteLine("Введите целое число N (>0) (чтение слева->направо): ");
            Start: string n = Console.ReadLine(); //sorry for GoTo
            if (Int32.TryParse(n, out int nn))
            {
                char[] nChar = n.ToCharArray();
                Array.Reverse(nChar);
                string nReverse = null;
                foreach (char c in nChar)
                {
                    nReverse += c.ToString();
                }
                int N = int.Parse(nReverse);
                Console.WriteLine(N);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("ВВЕДИТЕ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("     ЦЕЛОЕ ЧИСЛО N (>0): ");
                Console.ResetColor();
                goto Start; //sorry for GoTo
            }
        }
    }
}
