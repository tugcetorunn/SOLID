using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.KotuYontem
{
    internal class VeritabaniYoneticisi
    {
        SqlVeritabani sql = new SqlVeritabani();
        // sql ile tightly coupling hale gelir.

        // oracle ile çalışmak istersek
        // sql i sil ve oracle i ekle - ocp yi ezeriz.

        // çözüm
        // sınıfı loosely coupling hale getir.
    }
}
