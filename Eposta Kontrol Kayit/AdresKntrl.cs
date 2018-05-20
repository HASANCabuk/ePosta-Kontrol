using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace EpostaKontrolKayit
{
    class AdresKntrl
    {
        static Regex r;         
        internal bool Kontrol(string posta)//regex  ve posta kontrol
        {

           //r = new Regex(@"^[A-Za-z0-9]{1,15}[.]{1}[A-Za-z0-9]{1,20}[@]{1}[A-Za-z0-9]{1,25}[.]{1}([a-z]{2,3}|[a-z]{2,3}[.]{1}[a-z]{2,3})$");
            r = new Regex(@"^[A-Za-z0-9]{1,15}[.]{1}[A-Za-z0-9]{1,20}@[A-Za-z0-9]{1,25}[.]{1}([a-z]{2,3}|[a-z]{2,3}[.]{1}[a-z]{2,3})$");
            // r = new Regex(@"^\w{1,15}[.]{1}\w{1,20}[@]{1}\w{1,25}[.]{1}([a-z]{2,3}|[a-z]{2,3}[.]{1}[a-z]{2,3})$");
            if (r.IsMatch(posta))
            {
                return true;
            }
            else              
            return false;
            }
    }
}
