namespace WindowsFormsApplication3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Emporter = new System.Windows.Forms.Button();
            this.Sur_place = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.Quitter = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_entree_1 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.numeric_entree_1 = new System.Windows.Forms.NumericUpDown();
            this.button_entree_2 = new System.Windows.Forms.Button();
            this.numeric_entree_2 = new System.Windows.Forms.NumericUpDown();
            this.numeric_dessert_1 = new System.Windows.Forms.NumericUpDown();
            this.button_dessert_1 = new System.Windows.Forms.Button();
            this.button_calc = new System.Windows.Forms.Button();
            this.button_gotomain = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_entree_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_entree_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_dessert_1)).BeginInit();
            this.SuspendLayout();
            // 
            // Emporter
            // 
            this.Emporter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emporter.Location = new System.Drawing.Point(13, 13);
            this.Emporter.Name = "Emporter";
            this.Emporter.Size = new System.Drawing.Size(859, 205);
            this.Emporter.TabIndex = 0;
            this.Emporter.Text = "Emporter";
            this.Emporter.UseVisualStyleBackColor = true;
            this.Emporter.Click += new System.EventHandler(this.Emporter_Click);
            // 
            // Sur_place
            // 
            this.Sur_place.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sur_place.Location = new System.Drawing.Point(12, 224);
            this.Sur_place.Name = "Sur_place";
            this.Sur_place.Size = new System.Drawing.Size(859, 199);
            this.Sur_place.TabIndex = 1;
            this.Sur_place.Text = "Sur place";
            this.Sur_place.UseVisualStyleBackColor = true;
            this.Sur_place.Click += new System.EventHandler(this.Sur_place_Click);
            // 
            // Plus
            // 
            this.Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plus.Location = new System.Drawing.Point(13, 429);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(859, 218);
            this.Plus.TabIndex = 2;
            this.Plus.Text = "Plus";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Quitter
            // 
            this.Quitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quitter.Location = new System.Drawing.Point(13, 717);
            this.Quitter.Name = "Quitter";
            this.Quitter.Size = new System.Drawing.Size(859, 132);
            this.Quitter.TabIndex = 3;
            this.Quitter.Text = "Quitter";
            this.Quitter.UseVisualStyleBackColor = true;
            this.Quitter.Click += new System.EventHandler(this.Quitter_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Enabled = false;
            this.tabControl.Location = new System.Drawing.Point(14, 13);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(858, 769);
            this.tabControl.TabIndex = 4;
            this.tabControl.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.numeric_entree_2);
            this.tabPage1.Controls.Add(this.button_entree_2);
            this.tabPage1.Controls.Add(this.numeric_entree_1);
            this.tabPage1.Controls.Add(this.button_entree_1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(850, 743);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Entrée";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(850, 743);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Plat";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_entree_1
            // 
            this.button_entree_1.Location = new System.Drawing.Point(6, 6);
            this.button_entree_1.Name = "button_entree_1";
            this.button_entree_1.Size = new System.Drawing.Size(211, 38);
            this.button_entree_1.TabIndex = 0;
            this.button_entree_1.Text = "Potage d\'asperges au crabe\r\nSoupe pékinoise (piquant)";
            this.button_entree_1.UseVisualStyleBackColor = true;
            this.button_entree_1.Click += new System.EventHandler(this.button_entree_1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(850, 743);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Boisson";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.numeric_dessert_1);
            this.tabPage4.Controls.Add(this.button_dessert_1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(850, 743);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Dessert";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // numeric_entree_1
            // 
            this.numeric_entree_1.Location = new System.Drawing.Point(223, 17);
            this.numeric_entree_1.Name = "numeric_entree_1";
            this.numeric_entree_1.Size = new System.Drawing.Size(32, 20);
            this.numeric_entree_1.TabIndex = 1;
            // 
            // button_entree_2
            // 
            this.button_entree_2.Location = new System.Drawing.Point(6, 50);
            this.button_entree_2.Name = "button_entree_2";
            this.button_entree_2.Size = new System.Drawing.Size(211, 53);
            this.button_entree_2.TabIndex = 2;
            this.button_entree_2.Text = "Soupe de verm. Transparentes au poulet\r\nSoupe de raviolis (wan tan)\r\nTonkinoise a" +
    "u bœuf et boulettes (pho)";
            this.button_entree_2.UseVisualStyleBackColor = true;
            this.button_entree_2.Click += new System.EventHandler(this.button_entree_2_Click);
            // 
            // numeric_entree_2
            // 
            this.numeric_entree_2.Location = new System.Drawing.Point(223, 68);
            this.numeric_entree_2.Name = "numeric_entree_2";
            this.numeric_entree_2.Size = new System.Drawing.Size(32, 20);
            this.numeric_entree_2.TabIndex = 3;
            // 
            // numeric_dessert_1
            // 
            this.numeric_dessert_1.Location = new System.Drawing.Point(223, 12);
            this.numeric_dessert_1.Name = "numeric_dessert_1";
            this.numeric_dessert_1.Size = new System.Drawing.Size(32, 20);
            this.numeric_dessert_1.TabIndex = 3;
            // 
            // button_dessert_1
            // 
            this.button_dessert_1.Location = new System.Drawing.Point(6, 6);
            this.button_dessert_1.Name = "button_dessert_1";
            this.button_dessert_1.Size = new System.Drawing.Size(211, 28);
            this.button_dessert_1.TabIndex = 2;
            this.button_dessert_1.Text = "Nougatine vietnamienne";
            this.button_dessert_1.UseVisualStyleBackColor = true;
            this.button_dessert_1.Click += new System.EventHandler(this.button_dessert_1_Click);
            // 
            // button_calc
            // 
            this.button_calc.Enabled = false;
            this.button_calc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_calc.ForeColor = System.Drawing.Color.Green;
            this.button_calc.Location = new System.Drawing.Point(18, 788);
            this.button_calc.Name = "button_calc";
            this.button_calc.Size = new System.Drawing.Size(539, 61);
            this.button_calc.TabIndex = 5;
            this.button_calc.Text = "Calculer";
            this.button_calc.UseVisualStyleBackColor = true;
            this.button_calc.Visible = false;
            this.button_calc.Click += new System.EventHandler(this.button_calc_Click);
            // 
            // button_gotomain
            // 
            this.button_gotomain.Enabled = false;
            this.button_gotomain.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_gotomain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_gotomain.Location = new System.Drawing.Point(563, 807);
            this.button_gotomain.Name = "button_gotomain";
            this.button_gotomain.Size = new System.Drawing.Size(309, 42);
            this.button_gotomain.TabIndex = 6;
            this.button_gotomain.Text = "Menu principal";
            this.button_gotomain.UseVisualStyleBackColor = true;
            this.button_gotomain.Visible = false;
            this.button_gotomain.Click += new System.EventHandler(this.button_gotomain_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 861);
            this.Controls.Add(this.button_gotomain);
            this.Controls.Add(this.button_calc);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.Quitter);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.Sur_place);
            this.Controls.Add(this.Emporter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Caisse";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_entree_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_entree_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_dessert_1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Emporter;
        private System.Windows.Forms.Button Sur_place;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Quitter;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button_entree_1;
        private System.Windows.Forms.NumericUpDown numeric_entree_2;
        private System.Windows.Forms.Button button_entree_2;
        private System.Windows.Forms.NumericUpDown numeric_entree_1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.NumericUpDown numeric_dessert_1;
        private System.Windows.Forms.Button button_dessert_1;
        private System.Windows.Forms.Button button_calc;
        private System.Windows.Forms.Button button_gotomain;
    }
}

