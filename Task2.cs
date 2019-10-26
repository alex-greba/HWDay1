using System;
using System.Collections.Generic;
using System.Text;

namespace HWDay1
{
    class Task2
    {
        public void TaskT2()
        {
            Console.Clear();
            Console.WriteLine("TASK 2");
            Console.WriteLine("Введите номер вашего билета (может, он - \"счастливый\"): ");
            int sumF = 0;
            int sumL = 0;
            int count = 0;
            string TicketNumber = null;
            do
            {
                ConsoleKeyInfo TicketSymbol = Console.ReadKey();
                if (char.IsDigit(TicketSymbol.KeyChar))
                {
                    count++;
                    TicketNumber += TicketSymbol.KeyChar.ToString();
                    if (count < 4)
                        sumF += int.Parse(TicketSymbol.KeyChar.ToString());
                    else
                        sumL += int.Parse(TicketSymbol.KeyChar.ToString());
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n### INVALID ###"); 
                    Console.ResetColor();
                    return;
                };
            }
            while (count != 6);
            Console.ForegroundColor = ConsoleColor.Magenta;
            if (sumF == sumL)
                Console.WriteLine("\n\nУ Вас \"Счастливый Билет\" № " + TicketNumber + "\n\n" +
                    "Сумма первых    3-х цифр: " + TicketNumber.Substring(0, TicketNumber.Length - 3) + "\n" +
                    "      РАВНА\n" +
                    "Сумме последних 3-х цифр: " + TicketNumber.Substring(3));
            else
                Console.WriteLine("\n\nПовезет в другой раз: " + sumF + " != " + sumL);
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
