using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa1
{
    internal class Esaldia
    {
        private string esaldiaBatuta;
        public string Zatia { get; set; }
        public string EsaldiaBatuta
        {
            get { return esaldiaBatuta; }
        }
        public void Batu()
        {
            esaldiaBatuta += " " + Zatia;
        }



    }
}
