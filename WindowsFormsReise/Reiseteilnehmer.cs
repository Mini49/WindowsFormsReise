using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsReise
{
    class Reiseteilnehmer
    {
        private String email;
        private String nachname;
        private int teilnehmernummer;
        private String vorname;

        public Reiseteilnehmer(String email, String nachname, String vorname)
        {
            this.email = email;
            this.nachname = nachname;
            this.vorname = vorname;
        }

        public string Vorname
        {
            get
            {
                return vorname;
            }

            set
            {
                vorname = value;
            }
        }

        public int Teilnehmernummer
        {
            get
            {
                return teilnehmernummer;
            }

            set
            {
                teilnehmernummer = value;
            }
        }

        public string Nachname
        {
            get
            {
                return nachname;
            }

            set
            {
                nachname = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }


        public override string ToString()
        { 
            return nachname + " " + vorname;
        }
    }
}
