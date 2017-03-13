using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParcialTech
{
    public  class Utilidades
    {
        public static int TOINT(string n)
        {
            int num;
            int.TryParse(n, out num);
            return num;
        }
    }
}
