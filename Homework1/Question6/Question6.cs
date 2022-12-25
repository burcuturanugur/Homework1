//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Homework1
//{
//    internal class Question6
//    {
//        private static void Main(string[] args)
//        {
//            //    Bir bankamatik müşterisine bankamatikten çekmek istediği para sorulacak.Çekeceği paraya göre kaç tane 200’lük, kaç tane 100’lük, kaç tane 50’lik, kaç tane 20’lik,
//            //kaç tane 10’luk ve kaç tane 5’lik verilmesi gerektiğini bulan programı yazın.

//            int paraMiktari,ikiYuz,ikiYuzKalan,yuz,yuzKalan,elli,elliKalan,yirmi,yirmiKalan,on,onKalan,bes,besKalan,bir;
//            Console.WriteLine("Lütfen çekmek istediğiniz tutarı giriniz: ");
//         paraMiktari=Convert.ToInt32(Console.ReadLine());
//            ikiYuz = paraMiktari / 200;
//            ikiYuzKalan = paraMiktari - (ikiYuz * 200);
//            yuz = ikiYuzKalan / 100;
//            yuzKalan= ikiYuzKalan-(yuz*100);
//            elli = yuzKalan / 50;
//            elliKalan = yuzKalan - (elli * 50);
//            yirmi = elliKalan / 20;
//            yirmiKalan=elliKalan- (yirmi * 20);
//            on = yirmiKalan / 10;
//            onKalan=yirmiKalan- (on * 10);  
//            bes=onKalan/5;
//            besKalan=onKalan-(bes*5);
//            bir=besKalan/1;
//            Console.WriteLine("200 TL'lik banknot sayısı: " + ikiYuz);
//            Console.WriteLine("100 TL'lik banknot sayısı: " +yuz);
//            Console.WriteLine("50 TL'lik banknot sayısı: " +elli);
//            Console.WriteLine("20 TL'lik banknot sayısı: " + yirmi);
//            Console.WriteLine("10 TL'lik banknot sayısı: " + on);
//            Console.WriteLine("5 TL'lik banknot sayısı: " + bes);
//            Console.WriteLine("1 TL'lik banknot sayısı: " + bir);






//        }
//        }
//}
