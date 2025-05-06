using DIP.KotuYontem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.IyiYontem
{
    internal class DatabaseManager
    {
        public DatabaseManager()
        {
            
        }

        // ctor injectoin
        private /*readonly*/ ICRUD veritabani; // readonly yapmadık çünkü method injection kullandık
        public DatabaseManager(ICRUD _veritabani) // icrud implemente etmiş herhangi bir class buraya verilebilir. sql, oracle, mysql
        {
            veritabani = _veritabani;            
        }

        // method injection
        public void MethodInjection(ICRUD db)
        {
            veritabani = db;
        }

        // property injection
        public ICRUD PropertyInjection
        {
            get { return veritabani; }
            set { veritabani = value; }
        }

        public List<string> VerileriListele()
        {
            return veritabani.Listele();
        }
    }
}
