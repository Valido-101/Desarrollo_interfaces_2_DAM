using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_informes
{
    public class Class1
    {
        private string str1;
        private int int1;

        public Class1(string str1, int int1)
        {
            this.str1 = str1;
            this.int1 = int1;
        }

        public string Str1 { get => str1; set => str1 = value; }
        public int Int1 { get => int1; set => int1 = value; }
    }
}
