using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
     /// <summary>
     /// дополнительный метод размера
     /// </summary>
     /// <returns>размер</returns>
        static int GetSize()
        {
            Console.Write("введит ервзмер массива = ");
            int size;
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.WriteLine("ошибка");
            }
            return size;
        }
        /// <summary>
        /// метод ввода массива
        /// </summary>
        /// <param name="size"></param>
        /// <returns>массив</returns>
        static int[] Input(int size) 
        {
            int[] array = new int[size];
            for(int i = 0; i < size; i++)
            {
                Console.Write($"array[{i}]= ");
                array[i] = int.Parse(Console.ReadLine());
                
            }
            return array;
            
        }
        /// <summary>
        /// метод вывода
        /// </summary>
        /// <param name="array"></param>
        static void Output(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"array[{i}]={array[i]}");
            }

        }
        /// <summary>
        /// основной метод
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int size = GetSize();
            int[] array = Input(size);
            Console.WriteLine();
            Output(array);


            Console.Read();
        }
    }
}
