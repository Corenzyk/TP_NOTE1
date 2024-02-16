using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_NOTE1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }

    public class Pension
    {
        private string genre;
        private double salaireMoyAnn;
        private int nombreTrimestre;
        private int nombreEnfants;
        private int ageDepartRetraite;
        private int anneeNaissance;

        Pension(string sexe, int salMoyAnnu, int nbTrim, int nbEnfant, int ageDepRetraite, int DateNaiss)
        {
            genre = sexe; 
            salaireMoyAnn = salMoyAnnu;
            nombreTrimestre = nbTrim;
            nombreEnfants = nbEnfant;
            ageDepartRetraite = ageDepRetraite;
            anneeNaissance = DateNaiss;
        }

    }
}
