using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace EpostaKontrolKayit
{
    class PostaAl
    {
        string adress,tercih,tercih2;
        AdresKntrl k=new AdresKntrl();
        DosyaYrtAc d;
        internal PostaAl(DosyaYrtAc ds)
        {
            d = ds;
        }    
     internal void Al()
        {         
            do
            {
                Console.WriteLine(" Lütfen eposta adresi giriniz");
                adress = Console.ReadLine();
                if (k.Kontrol(adress))// kontrol  kılasına  giden  posta geçerli ise doyaya yaz
                {
                  d.DosyaYaz(adress);
                    Console.WriteLine("Yeni bir adres girmek için (E|e) bitirmek için (H|h)");
                    tercih = Console.ReadLine();
                    while (tercih != "E" && tercih != "e"&& tercih != "H"&& tercih != "h")
                    {
                        Console.WriteLine("Lütfen tercih degerlerinden birini giriniz");
                        tercih = Console.ReadLine();
                    }
                }
                else
                {// degilse tekrar iste
                    Console.WriteLine("Geçerli bir eposta adresi girmediniz");
                    Console.WriteLine("Yeni bir adres girmek için (E|e) bitirmek için (H|h)");
                    tercih = Console.ReadLine();
                    while (tercih != "E" && tercih != "e" && tercih != "H" && tercih != "h")
                    {
                        Console.WriteLine("Lütfen tercih degerlerinden birini giriniz");
                        tercih = Console.ReadLine();
                    }
                }
                       
            } while (tercih=="E"||tercih=="e");
            do
            {
                Console.WriteLine("Adresleri ekrana yazdırmak için (1) çıkmak için (2) tuşlayın");
                tercih2 = Console.ReadLine();
            } while (tercih2!="1"&& tercih2!="2");
            if (tercih2=="1")
            {              
                Console.Clear();
                d.DosyaOku();
            }
            else
            {
                Environment.Exit(0);
            }       
                     
        }            
    }
    
}
