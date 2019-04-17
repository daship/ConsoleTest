using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    public class Prodcut
    {
        public string name { set;get;}


        public string getname()
        {
            return name;
        }

        protected DateTime getdate()
        {
            return DateTime.Now;
        }
    }
}
