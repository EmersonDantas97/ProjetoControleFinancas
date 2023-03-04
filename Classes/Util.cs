using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor
{
    internal static class Util
    {
        internal static string FormataData(string Data, string Formato)
        {
            DateTime temp;
            
            if (!DateTime.TryParse(Data, out temp))
            {
                return "0000-00-00";
            }

            return temp.ToString(Formato);
        }
    }
}
