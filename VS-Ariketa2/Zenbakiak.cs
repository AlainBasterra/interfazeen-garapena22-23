using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zenbakiak
{
    public class Zenbakiak
    {
        public float zenb { get; set; }
        public float zenb2 { get; set; }
        public float zenb3 { get; set; }
        public float zenb4 { get; set; }

        public Zenbakiak()
        {

        }
        public static float eragiketa(List<Zenbakiak> znbk)
        {
            float emaitza = 0;
            emaitza = znbk[0].zenb + (2 * znbk[1].zenb) + (3 * znbk[2].zenb) + (4 * znbk[3].zenb);
            emaitza /= 4;
            return emaitza;
        }
    }
}
