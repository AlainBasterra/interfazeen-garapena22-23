using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa_3
{
    internal class Langilea : Kontaktua
    {
        public float Soldata { get; set; }
        public string SegurtasunSoziala { get; set; }
        public override string Emaila
        {
            get => base.Emaila;
            set
            {
                if (value.Length > 8 && value.Substring(value.Length - 8) == "@uni.eus")
                {
                    base.Emaila = value;
                }
                else
                {
                    Exception ex = new Exception("@uni.eus izan behar da");
                    throw ex;
                }
            }
        }
        public override string Gorde()
        {
            string mezua = "Langilea ondo gorde da";
            return mezua;
        }
    }
}
