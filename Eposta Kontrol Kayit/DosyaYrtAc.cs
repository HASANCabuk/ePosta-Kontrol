using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace EpostaKontrolKayit
{
     internal class DosyaYrtAc
    {
        FileStream fs;
        private string dosya;     
        private string[] adSoyad;
        private string[] sirket;
        private string[] lines;
        private int ks = 1, ss = 1;  // sayaclar    
         internal DosyaYrtAc(string dosya)
        {
            this.dosya = dosya;
            try
            {
                if (!dosya.Contains("."))//dosyanın . içermemsi durumda  hata yakalanır
                {

                }
                
            }
            catch (DirectoryNotFoundException ex)
            {
                fs = null;
                throw ex;

            }           
        }
       internal  void  DosyaYaz(string posta)// dosyaya  yazma metodu
        {
            fs = new FileStream(AppDomain.CurrentDomain.BaseDirectory+dosya, FileMode.Append, FileAccess.Write);//  yoksa yaratıp varsa üstüne yazma icin acılan dosya nesnesi
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(posta);
            sw.Close();
            fs.Close();                               
        }
        internal void DosyaOku()// dosya okuma metodu
        {
      
            try
            {          
               lines = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + dosya);// dosyayı  bir string dizisine aldım
                sirket = new string[lines.Length];
                adSoyad = new string[lines.Length];
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] temp = lines[i].Split(new[] { '@', '.' });// dizinin her satırını böldüm
                    adSoyad[i] = temp[0] + temp[1];
                    sirket[i] = temp[2];
                    Console.WriteLine("Adı Soyadı:{0} {1}\nKurum Adı:{2}", temp[0], temp[1], temp[2]);
                }
               Farkli();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
               
            }
           
        }
        internal void Farkli()
        {
            Array.Sort(adSoyad);
            Array.Sort(sirket);
            for (int i = 0; i <adSoyad.Length-1; i++)
            {
                if (adSoyad[i]!=adSoyad[i+1])
                {
                    ks++;
                }
                if (sirket[i]!=sirket[i+1])
                {
                    ss++;
                }
            }
            if (adSoyad.Length==0)
            {
                Console.WriteLine("Dosyada herhangi bir bilgi bulunamadı");
            }else
            Console.WriteLine("Toplam kişi sayısı :{0}\nToplam şirket sayısı:{1}",ks,ss);
        }                       
    }
}
