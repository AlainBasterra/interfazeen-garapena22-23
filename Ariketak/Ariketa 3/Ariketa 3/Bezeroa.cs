using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa_3
{
    internal class Bezeroa : Kontaktua
    {
        public string Kategoria { get; set; }
        public override string Gorde()
        {
            string mezua = "Bezeroa ondo gorde da";
            return mezua;
        }
    }
}
