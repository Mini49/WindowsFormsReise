using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsReise
{
    public partial class Form1 : Form
    {

  
        List<Reise> reisen;

        public Form1()
        {
            InitializeComponent();
            reisen = new List<Reise>();
            
            reisen.Add(new Reise(Convert.ToDateTime("23/10/2017"), 30, 3, Convert.ToDateTime("30/10/2017"), "Frankreich"));
            reisen.Add(new Reise(Convert.ToDateTime("15/01/2017"), 70, 20, Convert.ToDateTime("04/11/2018"), "Bangladesch"));
            reisen.Add(new Reise(Convert.ToDateTime("22/08/2017"), 5, 0, Convert.ToDateTime("25/08/2017"), "Schweden"));

            comboBoxReise.DataSource = reisen;
            
        }


        private void comboBoxReise_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Reise aktuell = (Reise)comboBoxReise.SelectedItem;
            labelMaxTeilnehmerNr.Text = aktuell.MaxTeilnehmer.ToString();
            
        }

        private void buttonHinzufügen_Click(object sender, EventArgs e)
        {
           
            Reise aktuell = (Reise)comboBoxReise.SelectedItem;
            if(aktuell.TeilnehmerAufnehmen(new Reiseteilnehmer(textBoxEmail.Text, textBoxNachname.Text, textBoxVorname.Text))==false)
            {
                MessageBox.Show("Die Reise ist ausgebucht");
            }
                         
            listBoxReiseteilnehmer.DataSource = null;
            listBoxReiseteilnehmer.DataSource = aktuell.AlleTeilnehmer;    
        }

        private void buttonLoeschen_Click(object sender, EventArgs e)
        {
            Reise aktuell = (Reise)comboBoxReise.SelectedItem;
            aktuell.AlleTeilnehmer.Remove((Reiseteilnehmer)listBoxReiseteilnehmer.SelectedItem);
            listBoxReiseteilnehmer.DataSource = null;
            listBoxReiseteilnehmer.DataSource = aktuell.AlleTeilnehmer;
        }
    }
}
