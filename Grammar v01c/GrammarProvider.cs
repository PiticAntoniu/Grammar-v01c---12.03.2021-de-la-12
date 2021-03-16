using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grammar_v01c
{
    public class GrammarProvider
    {
        static Grammar g = null;
        public static Grammar GetGrammar()
        {
            if (g == null)
            {
                g = new Grammar();
            }
            return g;
        }
    }
}
