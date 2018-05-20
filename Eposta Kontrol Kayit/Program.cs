using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpostaKontrolKayit
{
    class Program
    {
        static void Main(string[] args)
        {
    
            DosyaYrtAc d = new DosyaYrtAc("Postalar.txt");// Dosya acma ve yazma  icin constructor metoduna text dosyası verildi
            PostaAl panda = new PostaAl(d);
            panda.Al();
            Console.ReadKey();          

        }
    }
}
