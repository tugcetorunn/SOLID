using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    internal static class DosyaYoneticisi
    {
        public static string DosyadanOku(Dosya dosya)
        {
            return dosya.Oku();
        }
    }
}
