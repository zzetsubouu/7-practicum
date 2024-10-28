using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_practicum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Составить программные коды к следующим задачам с использованием всех трех циклов (с предусловием, с постусловием, с параметром):

            //1. вывести в столбик 10 раз слово "Привет"
            //int i = 0;

            //while (i < 10)
            //{
            //    Console.WriteLine("привет");
            //    i++;
            //}

            //do
            //{
            //    Console.WriteLine("привет");
            //    i++;
            //}
            //while (i < 10);

            //for (int j = 0; j < 10; j++)
            //{
            //    Console.WriteLine($"привет");
            //}




            //2.вывести в столбик первые 10 натуральных чисел
            //int i = 1;

            //while (i < 11)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //while (i < 11);

            //for (int j = 1; j < 11; j++)
            //{
            //    Console.WriteLine(j);
            //}




            //3.вывести в столбик первые 5 натуральных чисел в обратном порядке
            //int i = 5;

            //while (i>0)
            //{
            //    Console.WriteLine(i--);
            //}

            //do
            //{
            //    Console.WriteLine(i--);
            //}
            //while (i>0);

            //for (int j = 5;j>0;j--)
            //{
            //    Console.WriteLine(j);
            //}



            //4. вывести на экран целые числа из интервала от 1 до n
            //Console.Write("n = ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int i = 1;

            //while (i < n+1)
            //{
            //    Console.WriteLine(i++);
            //}

            //do
            //{
            //    Console.WriteLine(i++);
            //}
            //while (i < n);

            //for (int j = 1; j < n; j++)
            //{
            //    Console.WriteLine(j);
            //}



            //5. запросить у пользователя 5 слов, после чего вывести вначале дважды каждое нечетное слово и затем трижды каждое четное слово,
            //между выводимыми словами вставить разделитель в виде трех символьных пробелов (“   ”).






            //код, который просто выводит слова через 3 пробела:
            //первый метод
            //int j = 1;
            //string[] smas = new string[5];
            //for (int i = 0; i < smas.Length; i++)
            //{
            //    Console.WriteLine($"введите {j++} слово");
            //    smas[i] = Console.ReadLine();
            //}
            //foreach (string s in smas)
            //{
            //    Console.Write(s+"   ");
            //}

            //второй метод https://stackoverflow.com/questions/230454/how-to-fill-an-array-from-user-input-c
            //Console.WriteLine("введите 5 слов через пробел");
            //string word5 = Console.ReadLine();
            //string[] smas = word5.Split(' ');
            //foreach (string i in smas)
            //{
            //    Console.Write(i + "   ");
            //}

        }
    }
}
