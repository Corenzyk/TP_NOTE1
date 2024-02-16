using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_NOTE1
{
    public partial class Form1 : Form
    {
        public string sexe;
        public Form1()
        {
            InitializeComponent();
        }

        public void button_Click(object sender, EventArgs e)
        {
            bool erreur = true;
            if ((!rb_Femme.Checked && !rb_Homme.Checked)||(rb_Femme.Checked && rb_Homme.Checked))
            {
                MessageBox.Show("Aucun genre n'est sélectionné", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                erreur = false;
            }
            else
            {
                if (rb_Femme.Checked)
                {
                    sexe = rb_Femme.Text;
                }
                else
                {
                    sexe = rb_Homme.Text;
                }
            }
            if (txt_annNaiss.Text == "")
            {
                MessageBox.Show("Aucune date de naissance n'est rentré", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                erreur = false;
            }
            if (txt_salMoyAnn.Text == "")
            {
                MessageBox.Show("Aucun salaire annuel moyen n'est rentré", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                erreur = false;
            }
            if (num_ageRetraite.Text == "0")
            {
                MessageBox.Show("Aucun âge de départ à la retraite n'est rentré", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                erreur = false;
            }
            if (num_nbTrim.Text == "0")
            {
                MessageBox.Show("Aucun nombre de trimestre n'est rentré n'est choisie", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                erreur = false;
            }
            if (erreur == true)
            {
                Pension P = new Pension(sexe, Convert.ToDouble(txt_salMoyAnn.Text), Convert.ToInt32(num_nbTrim.Text), Convert.ToInt32(num_nbEnfant.Text), Convert.ToInt32(num_ageRetraite.Text), Convert.ToInt32(txt_annNaiss.Text));
                double pensionMensuel = P.calculMontantPensionMensuel(P.calculTauxLiquidation(P.calculDecote(P.calculNombreTrimRequis())), P.calculNombreTrimRequis());
                txt_result.Text = "Votre montant de pension mensuel s'éléve à : "+pensionMensuel+" €";
            }
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
        public string Genre
            {get {return genre;} set{genre=value;}}
        public double SalaireMoyAnn
        { get { return salaireMoyAnn; } set { salaireMoyAnn = value; } }
        public int NombreTrimestre
        { get { return nombreTrimestre ; } set { nombreTrimestre = value; } }
        public int NombreEnfants
        { get { return nombreEnfants ; } set { nombreEnfants = value; } }
        public int AgeDepartRetraite
        { get { return ageDepartRetraite; } set { ageDepartRetraite = value; } }
        public int AnneeNaissance
        { get { return anneeNaissance; } set { anneeNaissance = value; }}

        public Pension(string sexe, int salMoyAnnu, int nbTrim, int nbEnfant, int ageDepRetraite, int DateNaiss)
        {
            genre = sexe; 
            salaireMoyAnn = salMoyAnnu;
            nombreTrimestre = nbTrim;
            nombreEnfants = nbEnfant;
            ageDepartRetraite = ageDepRetraite;
            anneeNaissance = DateNaiss;
        }

        public void calculTrimGenre()
        {
            if (Genre == "Femme")
            {
                NombreTrimestre += 4;
            }
        }

        public int calculNombreTrimRequis()
        {
            int nbTrimRequis = 0;
            if (AnneeNaissance <= 1962)
            {
                nbTrimRequis = 169;
            }
            if (AnneeNaissance < 1964 && AnneeNaissance >= 1963)
            {
                nbTrimRequis = 170;
            }
            if (AnneeNaissance < 1965 && AnneeNaissance >= 1964)
            {
                nbTrimRequis = 171;
            }
            if (AnneeNaissance >= 1965)
            {
                nbTrimRequis = 172;
            }
            return nbTrimRequis;
        }

        public int calculDecote(int nbTrimRequis)
        {
            int decote = nbTrimRequis - NombreTrimestre;
            return decote;
        }

        public double calculTauxLiquidation(int decote)
        {
            double tauxLiquid = 50 - (decote * 1.25);
            if (tauxLiquid < 37.5)
                tauxLiquid = 37.5;
            return tauxLiquid;
        }

        public double calculMontantPensionMensuel(double tauxLiquid, int nbTrimRequis)
        {
            double pensionMensuel = (((SalaireMoyAnn * tauxLiquid) / 100) * NombreTrimestre / nbTrimRequis) / 12;
            return pensionMensuel;
        }
    }
}
