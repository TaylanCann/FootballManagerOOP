using System;
using System.Collections.Generic;

namespace FootballManagerOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Footballer> fbFootballers = new List<Footballer>();
            List<Footballer> gsFootballers = new List<Footballer>();

            _addFenerbahceFootballers(fbFootballers);
            _addGalatasarayFootballers(gsFootballers);

            Fenerbahce fenerbahçe = new Fenerbahce(fbFootballers);
            Galatasaray galatasaray = new Galatasaray(gsFootballers);

            for (int i = 0; i < 10; i++)
            {
                fenerbahçe.Match(fenerbahçe, galatasaray);
                Console.WriteLine();
            }

        }

        private static void _addFenerbahceFootballers(List<Footballer> fbFootballers)
        {
            Footballer MesutOzil = new Footballer();
            MesutOzil.Overall = 82;
            MesutOzil.Position = new Midfielder();
            fbFootballers.Add(MesutOzil);

            Footballer AlexDeSouza = new Footballer();
            AlexDeSouza.Overall = 88;
            AlexDeSouza.Position = new Midfielder();
            fbFootballers.Add(AlexDeSouza);

            Footballer EduDracena = new Footballer();
            EduDracena.Overall = 37;
            EduDracena.Position = new Defance();
            fbFootballers.Add(EduDracena);

            Footballer VolkanDemirel = new Footballer();
            VolkanDemirel.Overall = 78;
            VolkanDemirel.Position = new GoalKeaper();
            fbFootballers.Add(VolkanDemirel);
        }

        private static void _addGalatasarayFootballers(List<Footballer> gsFootballers)
        {
            Footballer SabriSarıoglu = new Footballer();
            SabriSarıoglu.Overall = 92;
            SabriSarıoglu.Position = new Defance();
            gsFootballers.Add(SabriSarıoglu);

            Footballer GeorgeHagi = new Footballer();
            GeorgeHagi.Overall = 87; // Because of Alex :d
            GeorgeHagi.Position = new Midfielder();
            gsFootballers.Add(GeorgeHagi);

            Footballer TarıkCamdal = new Footballer();
            TarıkCamdal.Overall = 29;
            TarıkCamdal.Position = new Defance();
            gsFootballers.Add(TarıkCamdal);
            
            Footballer ArdaTuran = new Footballer();
            ArdaTuran.Overall = 69;
            ArdaTuran.Position = new Midfielder();
            gsFootballers.Add(ArdaTuran);
        }


    }
}
