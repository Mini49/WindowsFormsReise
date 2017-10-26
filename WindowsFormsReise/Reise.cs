using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsReise
{
    class Reise
    {
        private List<Reiseteilnehmer> alleTeilnehmer;

        private int anzahlTeilnehmer;
        private DateTime bis;
        private int maxTeilnehmer;
        private decimal preis;
        private DateTime von;
        private String ziel;


        public Reise(DateTime bis, int maxTeilnehmer, decimal preis, DateTime von, String ziel)
        {
            AlleTeilnehmer = new List<Reiseteilnehmer>();
            AnzahlTeilnehmer = 0;
            this.bis = bis;
            this.maxTeilnehmer = maxTeilnehmer;
            this.preis = preis;
            this.von = von;
            this.ziel = ziel;
        }

        public Boolean TeilnehmerAufnehmen(Reiseteilnehmer teilnehmer)
        {
            if(AnzahlTeilnehmer<maxTeilnehmer)
            {
                alleTeilnehmer.Add(teilnehmer);
                anzahlTeilnehmer = alleTeilnehmer.Count();
                return true;
            }
            return false;
        }



        public override string ToString()
        {
            return ziel;
        }


        public DateTime Bis
        {
            get
            {
                return bis;
            }

            set
            {
                bis = value;
            }
        }

        public int MaxTeilnehmer
        {
            get
            {
                return maxTeilnehmer;
            }

            set
            {
                maxTeilnehmer = value;
            }
        }

        public decimal Preis
        {
            get
            {
                return preis;
            }

            set
            {
                preis = value;
            }
        }

        public DateTime Von
        {
            get
            {
                return von;
            }

            set
            {
                von = value;
            }
        }

        public string Ziel
        {
            get
            {
                return ziel;
            }

            set
            {
                ziel = value;
            }
        }

        internal List<Reiseteilnehmer> AlleTeilnehmer
        {
            get
            {
                return alleTeilnehmer;
            }

            set
            {
                alleTeilnehmer = value;
            }
        }

        public int AnzahlTeilnehmer
        {
            get
            {
                return anzahlTeilnehmer;
            }

            set
            {
                anzahlTeilnehmer = value;
            }
        }
    }
}
