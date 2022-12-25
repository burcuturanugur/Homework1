using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.Question5
{
    internal class Question5
    {
        private static void Main(string[] args)
        {
            //Girilen 4 haneli bir tam sayının yüzler hanesindeki sayı degerinin 3 ile bölümünden elde edilen kalanın aynı sayının birler hanesindeki deger ile farkını bulan programı yazın.
            int sayi, bin, binKalan, yuz, yuzKalan, on, onkalan, bir, fark;
            Console.WriteLine("4 basamaklı bir sayı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            string basamak = sayi.ToString();
            if (basamak.Length == 4)
            {
                bin = sayi / 1000;
                binKalan = sayi - bin * 1000;
                yuz = binKalan / 100;
                yuzKalan = binKalan - yuz * 100;
                on = yuzKalan / 10;
                onkalan = yuzKalan / (on * 10);
                bir = onkalan * 1;
                Console.WriteLine("Binler basamağı: " + bin + "Yüzler basamağı: " + yuz + "Onlar basamağı: " + on + "Birler basamağı: " + bir);
                fark = yuz - yuz / 3 * 3 - bir;
                Console.WriteLine("fark: " + fark);
            }
            else
            {
                Console.WriteLine("4 basamaklı bir sayı girmediniz!");
            }
            Console.ReadKey();


        }
    }
}
