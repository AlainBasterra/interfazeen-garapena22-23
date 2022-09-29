using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zenbakiak
{
    public class Zenbakiak
    {
        float[] zenbakiak = new float[4];
        public float[] Zenbakiak
        {
            get { return zenbakiak; }
            set { zenbakiak = value; }
        }
        public Zenbakiak()
        {

        }
        public static float eragiketa(List<Zenbakiak> znbk)
        {
            float emaitza = 0;
            emaitza = (znbk[0].zenbakiak + (2 * znbk[1].zenbakiak) + (3 * znbk[2].zenbakiak) + (4 * znbk[3].zenbakiak)) / 4;
            return emaitza;
        }
    }
}
