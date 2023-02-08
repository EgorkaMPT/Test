using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Test
{
    internal class Test1 : Save
    {
        static string Name;
        static int ID = 1;
        static int Seco;
        static List<Users> rez = new List<Users>();
        protected static void perehod()
        {
            Console.Clear();
            Console.WriteLine("Введите имя\n");
            Name = Console.ReadLine();
            Console.Clear();
            pechatanie();
            ID = 1;
        }
        protected static void pechatanie()
        {

            string txt = "Как же я устал с этой перездачей. Можно просто выйти в окно пж. Я очень сильно надеюсь что сдам её, но мне почему-то кажется что я на комиссию пойду. Папа(Софа) топ.";
            char[] text = txt.ToCharArray();
            int i = 0;
            int position = 0;
            int sop = 0;
            ConsoleKeyInfo key;
            do
            {
                Console.Clear();
                Console.WriteLine(txt);
                Console.WriteLine("\nЧтобы начать нажмите Enter");
                key = Console.ReadKey();
            } while (key.Key != ConsoleKey.Enter);
            Console.Clear();
            Console.WriteLine(txt);
            Thread po = new Thread(potok);
            po.Start();
            do
            {
                Console.SetCursorPosition(sop, position);
                key = Console.ReadKey(true);
                if (key.KeyChar == text[i])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(sop, position);
                    Console.WriteLine(text[i]);
                    i++;
                    sop++;
                    if (sop == 120)
                    {
                        sop = 0;
                        position++;
                    }
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(sop, position);
                    Console.WriteLine(text[i]);
                    Console.ResetColor();
                }
            } while (ID != 0 && i != text.Length);
            ID = 0;
            Users h = new Users();
            h.Name = Name;
            h.Min = i * 60 / Seco;
            h.Sec = (float)i / Seco;
            rez.Add(h);
        }
        private static void potok()
        {
            Seco = -1;
            int i = 60;

            while (i != 0)
            {
                if (ID != 0)
                {
                    Console.SetCursorPosition(5, 10);
                    if (i == 60)
                    {
                        Console.WriteLine("1:00");
                    }
                    if (i < 60)
                    {
                        Console.WriteLine($"0:{i}");
                    }
                    i = i - 1;
                    Seco++;
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 10);
                    Console.WriteLine(" ");
                }
            }
            ID = 0;
            Console.SetCursorPosition(5, 10);
            Console.WriteLine("0:0");
            Thread.Sleep(400);
            Console.SetCursorPosition(5, 10);
            Console.WriteLine("Чтобы продолжить - нажмите любую клавишу...");
        }
    }
}