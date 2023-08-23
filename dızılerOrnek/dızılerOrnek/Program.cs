using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dızılerOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen 5 adet sınav notunuzu giriniz:");
            int[] notlar;
            notlar = new int[5];
            for (int i = 0; i < 5; i++)
            {
               notlar[i]= Convert.ToInt32(Console.ReadLine());
            }

            Console.Clear();
            Console.WriteLine("Değiştirmek  isteğiniz not varsa, 1'e basınız.\nSilmek istediğiniz notunuz varsa 2'ye basınız.\n Notlarınızı yüksekten düşüğe doğru sıralamak için 3'e basınız.");
            int secim = int.Parse(Console.ReadLine());
            switch (secim) 
            {
                case 1:
                    Console.WriteLine("Hangi notunuzu değiştirmek istiyorsunuz?");
                    int not = int.Parse(Console.ReadLine());
                    int notunIndexi =  Array.IndexOf(notlar, not);
                    if(notunIndexi != -1) 
                    {
                        // kullanıcının yazdığı notun bulunması durumu
                        Console.WriteLine("Güncel notunuzu yazınız.");
                        int yeniNot = int.Parse(Console.ReadLine());
                        notlar[notunIndexi] = yeniNot;
                        Console.WriteLine("Notunuz güncellendi.");

                        foreach (var item in notlar)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Böyle bir not girilmedi.");
                    }
                    break;
                    case 2:
                    Console.WriteLine("Hangi notu silmek istiyorsunuz?");
                     not = int.Parse(Console.ReadLine());
                     notunIndexi= Array.IndexOf(notlar, not);
                    if (notunIndexi != -1)
                    {
                        Array.Clear(notlar, notunIndexi, 1);
                        Console.WriteLine("Notunuz silindi.");
                        foreach (var item in notlar)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    else
                            Console.WriteLine("Böyle bir not girilmedi.");                   
                    break;
                    case 3:
                        Array.Sort(notlar);
                        Array.Reverse(notlar);
                    foreach (var item in notlar)
                    {
                        Console.WriteLine(item);
                    }
                    break;
                    default:
                    Console.WriteLine("Yanlış seçim yaptınız.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
//uygulama bizden 5 adet sınav notu istesin ve bu notları bir dizide tutsun.
// sonra şöyle bir ekran belirsin.
//- Değiştirmek istediğiniz not varsa 1'e basınız.
//- Silmek istediğiniz not varsa 2'ye basınız.
//- Notlarınızı yükselten düşüğe sıralamak için 3'e basınız.
// kullanıcının seçimine göre gereken işlemler yapılsın.
