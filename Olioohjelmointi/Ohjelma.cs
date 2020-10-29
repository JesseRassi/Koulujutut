using System;

namespace Oliohjelmointi_harjoitukset
{
    class Ohjelma
    {
        static void Main(string[] args)
        {
            Monitori monitori2 = new Monitori("Samsung", false);
            monitori2.Kaynnista();
            monitori2.TulostaTiedot();

            Kosketusnaytto kosketusnaytto = new Kosketusnaytto();
            kosketusnaytto.TulostaTiedot();

            Kosketusnaytto kosketusnaytto2 = new Kosketusnaytto("Dell", true, 100);
            kosketusnaytto2.TulostaTiedot();
            //Monitori monitori = new Monitori();
            //monitori.merkki = "Dell";
            //monitori.TulostaTiedot();
            //Console.WriteLine(monitori.paalla);
            //Monitori monitori3 = new Monitori("Sony");
            //monitori3.Kaynnista();
            //monitori3.TulostaTiedot();




            Console.ReadKey();
        }

        class Monitori
        {

            protected bool paalla; // kapselointi periytyy mutta ei näy luokan ulkopuolelle.
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
                this.paalla = paalla;


            }
            public void TulostaTiedot()
            {
                Console.WriteLine("MONITORIN TIEDOT");
                Console.WriteLine("merkki: " + merkki);
                if (paalla)
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
        }//Monitori Luokan lopetus

        class Kosketusnaytto : Monitori // Peritään Monitori luokan kaikki osat.
        {
            public int kosketuskohta;
            
            //Oletusmuodostin
            public Kosketusnaytto():base()
            {
                //merkki = "";
                //paalla = false;
                kosketuskohta = 0;
            }

            //Muodostin
            public Kosketusnaytto(string merkki, int pkosketuskohta)
            {
                this.merkki = merkki;
                kosketuskohta = pkosketuskohta;
                this.paalla = false;
            }

            //Muodostin
            public Kosketusnaytto(string merkki, bool paalla, int pkosketuskohta) : base (merkki,paalla) // merkki ja paalla tulee Monitori luokasta.
            {
                //this.merkki = merkki;
                //this.paalla = paalla;
                kosketuskohta = pkosketuskohta;               
            }

            public new void TulostaTiedot() //Muista new kun ylikirjoitetaan!!
            {
                Console.WriteLine("KOSKETUSNÄYTÖN TIEDOT");
                Console.WriteLine("merkki: " + merkki);
                if (paalla)
                {
                    Console.WriteLine("Monitori on päällä.");
                }
                else
                {
                    Console.WriteLine("Monitori ei ole päällä.");
                }
                Console.WriteLine("Kosketuskohta: " + kosketuskohta);
            }
        }

    }
    
}
