namespace TP_NOTE1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_annNaiss = new System.Windows.Forms.TextBox();
            this.txt_salMoyAnn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.num_nbEnfant = new System.Windows.Forms.NumericUpDown();
            this.num_nbTrim = new System.Windows.Forms.NumericUpDown();
            this.num_ageRetraite = new System.Windows.Forms.NumericUpDown();
            this.but_Calc = new System.Windows.Forms.Button();
            this.rb_Femme = new System.Windows.Forms.RadioButton();
            this.rb_Homme = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_result = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_nbEnfant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_nbTrim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_ageRetraite)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_annNaiss
            // 
            this.txt_annNaiss.Location = new System.Drawing.Point(210, 110);
            this.txt_annNaiss.Name = "txt_annNaiss";
            this.txt_annNaiss.Size = new System.Drawing.Size(213, 20);
            this.txt_annNaiss.TabIndex = 0;
            // 
            // txt_salMoyAnn
            // 
            this.txt_salMoyAnn.Location = new System.Drawing.Point(210, 261);
            this.txt_salMoyAnn.Name = "txt_salMoyAnn";
            this.txt_salMoyAnn.Size = new System.Drawing.Size(213, 20);
            this.txt_salMoyAnn.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Année de naissance :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Age de départ à la retraite :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre de trimestre :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Salaire moyen :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nombre d\'enfants :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.num_nbEnfant);
            this.panel1.Controls.Add(this.num_nbTrim);
            this.panel1.Controls.Add(this.num_ageRetraite);
            this.panel1.Controls.Add(this.but_Calc);
            this.panel1.Controls.Add(this.rb_Femme);
            this.panel1.Controls.Add(this.rb_Homme);
            this.panel1.Location = new System.Drawing.Point(16, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 381);
            this.panel1.TabIndex = 8;
            // 
            // num_nbEnfant
            // 
            this.num_nbEnfant.Location = new System.Drawing.Point(194, 272);
            this.num_nbEnfant.Name = "num_nbEnfant";
            this.num_nbEnfant.Size = new System.Drawing.Size(213, 20);
            this.num_nbEnfant.TabIndex = 5;
            // 
            // num_nbTrim
            // 
            this.num_nbTrim.Location = new System.Drawing.Point(194, 179);
            this.num_nbTrim.Name = "num_nbTrim";
            this.num_nbTrim.Size = new System.Drawing.Size(213, 20);
            this.num_nbTrim.TabIndex = 4;
            // 
            // num_ageRetraite
            // 
            this.num_ageRetraite.Location = new System.Drawing.Point(194, 127);
            this.num_ageRetraite.Name = "num_ageRetraite";
            this.num_ageRetraite.Size = new System.Drawing.Size(213, 20);
            this.num_ageRetraite.TabIndex = 3;
            // 
            // but_Calc
            // 
            this.but_Calc.Location = new System.Drawing.Point(264, 316);
            this.but_Calc.Name = "but_Calc";
            this.but_Calc.Size = new System.Drawing.Size(75, 23);
            this.but_Calc.TabIndex = 2;
            this.but_Calc.Text = "Calculer";
            this.but_Calc.UseVisualStyleBackColor = true;
            this.but_Calc.Click += new System.EventHandler(this.button_Click);
            // 
            // rb_Femme
            // 
            this.rb_Femme.AutoSize = true;
            this.rb_Femme.Location = new System.Drawing.Point(305, 27);
            this.rb_Femme.Name = "rb_Femme";
            this.rb_Femme.Size = new System.Drawing.Size(59, 17);
            this.rb_Femme.TabIndex = 1;
            this.rb_Femme.TabStop = true;
            this.rb_Femme.Text = "Femme";
            this.rb_Femme.UseVisualStyleBackColor = true;
            // 
            // rb_Homme
            // 
            this.rb_Homme.AutoSize = true;
            this.rb_Homme.Location = new System.Drawing.Point(208, 27);
            this.rb_Homme.Name = "rb_Homme";
            this.rb_Homme.Size = new System.Drawing.Size(61, 17);
            this.rb_Homme.TabIndex = 0;
            this.rb_Homme.TabStop = true;
            this.rb_Homme.Text = "Homme";
            this.rb_Homme.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(479, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Résultat :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Informations";
            // 
            // txt_result
            // 
            this.txt_result.AcceptsTab = true;
            this.txt_result.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_result.Enabled = false;
            this.txt_result.Location = new System.Drawing.Point(537, 27);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(251, 389);
            this.txt_result.TabIndex = 11;
            this.txt_result.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_salMoyAnn);
            this.Controls.Add(this.txt_annNaiss);
            this.Controls.Add(this.panel1);
            this.Enabled = false;
            this.Name = "Form1";
            this.Text = "Retraite de base";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_nbEnfant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_nbTrim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_ageRetraite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txt_annNaiss;
        public System.Windows.Forms.TextBox txt_salMoyAnn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.RadioButton rb_Femme;
        public System.Windows.Forms.RadioButton rb_Homme;
        private System.Windows.Forms.Button but_Calc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.RichTextBox txt_result;
        public System.Windows.Forms.NumericUpDown num_nbEnfant;
        public System.Windows.Forms.NumericUpDown num_nbTrim;
        public System.Windows.Forms.NumericUpDown num_ageRetraite;
    }
}

