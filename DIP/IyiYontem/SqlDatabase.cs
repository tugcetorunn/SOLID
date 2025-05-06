using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.IyiYontem
{
    internal class SqlDatabase : ICRUD
    {
        public List<string> Listele()
        {
            // sql veritabanından verileri listele
            return new List<string> { "sql1", "sql2", "sql3" };
        }
    }
}
