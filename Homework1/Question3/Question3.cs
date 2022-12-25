//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Homework1.Question3
//{
//    internal class Question3
//    {
//        private static void Main(string[] args)
//        {

//            //Klavyeden girilen 6 basamaklı bir sayının tüm basamaklarındaki sayıları toplayıp yazdıran programı hazırlayınız.

//            int sayi, sonuc = 0;
//            Console.WriteLine("Lütfen 6 basamaklı bir sayı giriniz: ");
//            sayi = Convert.ToInt32(Console.ReadLine());
//            while (sayi > 0)
//            {
//                sonuc = sonuc + (sayi % 10);
//                sayi = sayi / 10;
//            }
            
//            Console.WriteLine("Girdiğiniz sayının rakamları toplamı: " + sonuc);
//            Console.ReadKey();





//        }
//    }
//}
