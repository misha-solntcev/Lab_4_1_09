using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 9. В заданном массиве найти максимальный элемент. 
    Элементы, стоящие после максимального элемента 
    заменить нулями. */

namespace Lab_4_1_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random random = new Random();
                        
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(50);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();                            

            int max = array[0];
            int index = 0;
            for (int i = 0; i < array.Length; i++)            
                if (array[i] > max)
                {
                    max = array[i];
                    index = i;
                }                
            Console.WriteLine($"index={index}, max={max}");

            for (int i = index + 1; i < array.Length; i++)            
                array[i] = 0;
            foreach (var item in array)
                Console.Write(item + " ");            

            Console.ReadKey();
        }
    }
}
