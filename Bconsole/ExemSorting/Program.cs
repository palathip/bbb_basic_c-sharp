using System;
using System.Collections.Generic;

namespace ExemSorting
{
    class Program
    {
        static List<int> numberlist = new List<int>();
        static void Main(string[] args)
        {

            Console.WriteLine("************ Program Sort Number ************");
        
            Boolean swt = true;
            int min = 8;                                
            int count = 0;

            while (swt)
            { // waiting for insery trycatch
                
                Console.Write($"Input Number {count+1}:");
                int number = int.Parse(Console.ReadLine());
                numberlist.Add(number);
                count++;
                if (number == 0)
                {
                    if (count < min)                    // minimum < 8 continue loop
                    {
                        count--;
                        numberlist.Remove(number);
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("****************** Sort Data *******************");
                        Console.Write("Sort Number =>");
                        if (numberlist.Count % 2 == 1)
                        {
                            for (int i = 0; i < numberlist.Count-1; i++)
                            {
                                numberlist.Sort();
                                if (i % 2 == 1)
                                {
                                    Console.Write($"{numberlist[i]} ");
                                }
                            }
                            for (int i = 0; i < numberlist.Count-1; i++)
                            {
                                numberlist.Reverse();
                                if (i % 2 == 0)
                                {
                                    Console.Write($"{numberlist[i]} ");
                                }
                            }
                        }
                        else
                        {
                            for (int i = 0; i < numberlist.Count-1; i++)
                            {
                                numberlist.Sort();
                                if (i % 2 == 0)
                                {
                                    Console.Write($"{numberlist[i]} ");
                                }
                            }
                            for (int i = 0; i < numberlist.Count-1; i++)
                            {
                                numberlist.Reverse();
                                if (i % 2 == 0)
                                {
                                    Console.Write($"{numberlist[i]} ");
                                }
                            }
                        }
                    }
                    swt = false;
                }

            }
        }
    }
}
