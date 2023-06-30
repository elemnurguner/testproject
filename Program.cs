using System;
namespace testproject
{
    class Program
    {
        static void Main(string[] args)
        {
            double alis, karOran, satis;
            Console.Write("Sayıyı Girin : ");
            alis = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kar Oranını Girin : ");
            karOran = Convert.ToDouble(Console.ReadLine());
            satis = alis+(alis * karOran / 100);
            Console.WriteLine("Satis Fiyati : {0}",satis);
            Console.ReadLine();
            Console.ReadKey();

        }
    }
}

