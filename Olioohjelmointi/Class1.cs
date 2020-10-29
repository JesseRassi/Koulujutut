using System;
using System.Collections.Generic;
using System.Text;

namespace Oliohjelmointi_harjoitukset
{
    
    class Monitori
    {

        public bool paalla;
        public string merkki;

        //Oletusmuodostin
        public Monitori()
        {
            merkki = "";
            paalla = false;

        }

        public Monitori(string monitorinMerkki)
        {
            merkki = monitorinMerkki;
            paalla = false;

        }

        public Monitori(string merkki, bool paalla)
        {
            this.merkki = merkki;
            this .paalla = paalla;


        }
        public void TulostaTiedot()
        {
            Console.WriteLine("MONITORIN TIEDOT");
            Console.WriteLine("merkki: " + merkki);
            if(paalla)
            {
                Console.WriteLine("Monitori on päällä.");
            }
            else
            {
                Console.WriteLine("Monitori ei ole päällä.");

            }
        }
        public void Kaynnista()
        {
            paalla = true;
        }

        public void Sammuta()
        {
            paalla = false;
        }
    }
}
