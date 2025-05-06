using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.IyiYontem
{
    internal class OracleDatabase : ICRUD
    {
        public List<string> Listele()
        {
            // oracle veritabanından verileri listele
            return new List<string> { "oracle1", "oracle2", "oracle3" };
        }
    }
}
