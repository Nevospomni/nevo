using System;
using System.Text;

namespace LR6
{
class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            String Strok = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите позицию");
            Int32 Nom = Convert.ToInt32(Console.ReadLine());

            StringBuilder Strok2 = new StringBuilder(Strok);
            Strok = "";
            for (int i = 0;
            i < Strok2.Length - Nom;
            i++)
            { Strok = Strok + Strok2[i]; }
            Console.WriteLine(Strok);
            Console.ReadKey();
        }
    }
}
