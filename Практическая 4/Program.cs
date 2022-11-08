using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Pract3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zametka faa = new Zametka();
            faa.Name = "  Придти на пары";
            faa.Description = "  С первой по пятую";
            Zametka fab = new Zametka();
            fab.Name = "  Пойти погулять";
            fab.Description = "  Завтра";
            Zametka fac = new Zametka();
            fac.Name = "  Сходить в парикмахирскую";
            fac.Description = "  Постричся";
            Zametka fad = new Zametka();
            fad.Name = "  Сходить на рынок";
            fad.Description = "  Купит продукты";
            Zametka fae = new Zametka();
            fae.Name = "  Леч спать";
            fae.Description = "  В 12 вечера";
            List<string> dsa = new List<string>();
            dsa.Add("  Заметки 01.01.1111");
            dsa.Add("  Заметки 02.02.2222");
            dsa.Add("  Заметки 03.03.3333");
            while (true)
            {
                ConsoleKeyInfo a = Console.ReadKey();
                if (a.Key == ConsoleKey.RightArrow)
                {
                    Console.Clear();
                    Console.WriteLine(dsa[0]);
                    Console.WriteLine(faa.Name);
                    Console.WriteLine(fab.Name);
                    int position = 1;
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("->");
                    ConsoleKeyInfo clavisha = Console.ReadKey();
                    while (clavisha.Key != ConsoleKey.Enter)
                    {
                        if (clavisha.Key == ConsoleKey.UpArrow)
                        {
                            position--;
                            Console.Clear();
                            Console.WriteLine(dsa[0]);
                            Console.WriteLine(faa.Name);
                            Console.WriteLine(fab.Name);
                        }
                        else if (clavisha.Key == ConsoleKey.DownArrow)
                        {
                            position++;
                            Console.Clear();
                            Console.WriteLine(dsa[0]);
                            Console.WriteLine(faa.Name);
                            Console.WriteLine(fab.Name);
                        }
                        Console.SetCursorPosition(0, position);
                        Console.WriteLine("->");
                        clavisha = Console.ReadKey();
                    }
                    if (position == 1)
                    {
                        Console.Clear();
                        Console.WriteLine(faa.Name + "\n" + faa.Description + "\n" + "Время создания 01.01.0000");
                    }
                    while (clavisha.Key != ConsoleKey.Enter | a.Key != ConsoleKey.RightArrow)
                    {
                        if (clavisha.Key == ConsoleKey.UpArrow)
                        {
                            position--;
                            Console.Clear();
                            Console.WriteLine(dsa[0]);
                            Console.WriteLine(fab.Name);
                        }
                        else if (clavisha.Key == ConsoleKey.DownArrow)
                        {
                            position++;
                            Console.Clear();
                            Console.WriteLine(dsa[0]);
                            Console.WriteLine(fab.Name);
                        }
                        Console.SetCursorPosition(0, position);
                        Console.WriteLine("->");
                        clavisha = Console.ReadKey();
                    }
                    if (position == 2)
                    {
                        Console.Clear();

                        Console.WriteLine(fab.Name + "\n" + fab.Description + "\n" + "Время создания 01.01.0001");
                    }
                }
                ConsoleKeyInfo b = Console.ReadKey();
                if (b.Key == ConsoleKey.RightArrow)
                {
                    Console.Clear();
                    Console.WriteLine(dsa[1]);
                    Console.WriteLine(fac.Name);
                    Console.WriteLine(fad.Name);
                    int position2 = 1;
                    Console.SetCursorPosition(0, position2);
                    Console.WriteLine("->");
                    ConsoleKeyInfo clavisha2 = Console.ReadKey();
                    while (clavisha2.Key != ConsoleKey.Enter)
                    {
                        if (clavisha2.Key == ConsoleKey.UpArrow)
                        {
                            position2--;
                            Console.Clear();
                            Console.WriteLine(dsa[1]);
                            Console.WriteLine(fac.Name);
                            Console.WriteLine(fad.Name);
                        }
                        else if (clavisha2.Key == ConsoleKey.DownArrow)
                        {
                            position2++;
                            Console.Clear();
                            Console.WriteLine(dsa[1]);
                            Console.WriteLine(fac.Name);
                            Console.WriteLine(fad.Name);
                        }
                        Console.SetCursorPosition(0, position2);
                        Console.WriteLine("->");
                        clavisha2 = Console.ReadKey();
                    }
                    if (position2 == 1)
                    {
                        Console.Clear();
                        Console.WriteLine(fac.Name + "\n" + fac.Description + "\n" + "Время создания 0.11.0002");
                    }
                    while (clavisha2.Key != ConsoleKey.Enter)
                    {
                        if (clavisha2.Key == ConsoleKey.UpArrow)
                        {
                            position2--;
                            Console.Clear();
                            Console.WriteLine(dsa[1]);
                            Console.WriteLine(fac.Name);
                            Console.WriteLine(fad.Name);
                        }
                        else if (clavisha2.Key == ConsoleKey.DownArrow)
                        {
                            position2++;
                            Console.Clear();
                            Console.WriteLine(dsa[1]);
                            Console.WriteLine(fac.Name);
                            Console.WriteLine(fad.Name);
                        }
                        Console.SetCursorPosition(0, position2);
                        Console.WriteLine("->");
                        clavisha2 = Console.ReadKey();
                    }
                    if (position2 == 2)
                    {
                        Console.Clear();
                        Console.WriteLine(fad.Name + "\n" + fad.Description + "\n" + "Время создания 01.01.0003");
                    }
                }
                ConsoleKeyInfo c = Console.ReadKey();
                if (c.Key == ConsoleKey.RightArrow)
                {
                    Console.Clear();
                    Console.WriteLine(dsa[2]);
                    Console.WriteLine(fae.Name);
                    int position3 = 1;
                    Console.SetCursorPosition(0, position3);
                    Console.WriteLine("->");
                    ConsoleKeyInfo clavisha3 = Console.ReadKey();
                    while (clavisha3.Key != ConsoleKey.Enter)
                    {
                        if (clavisha3.Key == ConsoleKey.UpArrow)
                        {
                            position3--;
                            Console.Clear();
                            Console.WriteLine(dsa[1]);
                            Console.WriteLine(fae.Name);
                        }
                        else if (clavisha3.Key == ConsoleKey.DownArrow)
                        {
                            position3++;
                            Console.Clear();
                            Console.WriteLine(dsa[1]);
                            Console.WriteLine(fac.Name);
                            Console.WriteLine(fad.Name);
                        }
                        Console.SetCursorPosition(0, position3);
                        Console.WriteLine("->");
                        clavisha3 = Console.ReadKey();
                    }
                    if (position3 == 1)
                    {
                        Console.Clear();
                        Console.WriteLine(fae.Name + "\n" + fae.Description + "\n" + "Время создания 01.01.0004");
                    }
                }
            }
        }
    }
}