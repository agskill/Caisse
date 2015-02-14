using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public enum menu
        {
            m_principal,
            m_produits,
            m_plus
        };

        private bool b_emporter;

        public Form1()
        {
            InitializeComponent();
        }

        private void switch_to_product(menu choix)
        {
            Quitter.Enabled = (choix == menu.m_principal);
            Quitter.Visible = (choix == menu.m_principal);
            Emporter.Enabled = (choix == menu.m_principal);
            Emporter.Visible = (choix == menu.m_principal);
            Sur_place.Enabled = (choix == menu.m_principal);
            Sur_place.Visible = (choix == menu.m_principal);
            Plus.Enabled = (choix == menu.m_principal);
            Plus.Visible = (choix == menu.m_principal);
            tabControl.Visible = (choix == menu.m_produits);
            tabControl.Enabled = (choix == menu.m_produits);
            button_calc.Visible = (choix == menu.m_produits);
            button_calc.Enabled = (choix == menu.m_produits);
            button_gotomain.Visible = (choix != menu.m_principal);
            button_gotomain.Enabled = (choix != menu.m_principal);
            button_reset.Visible = (choix == menu.m_plus);
            button_reset.Enabled = (choix == menu.m_plus);
            textBox_log.Enabled = (choix == menu.m_plus);
            textBox_log.Visible = (choix == menu.m_plus);
            button_raz.Enabled = (choix == menu.m_produits);
            button_raz.Visible = (choix == menu.m_produits);
            label_prix.Enabled = (choix == menu.m_produits);
            label_prix.Visible = (choix == menu.m_produits);
        }

        private void Quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Emporter_Click(object sender, EventArgs e)
        {
            b_emporter = true;
            numeric_ValueChanged(sender, e);
            switch_to_product(menu.m_produits);
        }

        private void Sur_place_Click(object sender, EventArgs e)
        {
            b_emporter = false;
            numeric_ValueChanged(sender, e);
            switch_to_product(menu.m_produits);
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            switch_to_product(menu.m_plus);
            try
            {
                FileStream fstream = new FileStream("log.txt", FileMode.Open);
                StreamReader sreader = new StreamReader(fstream);
                textBox_log.Text = sreader.ReadToEnd();
                textBox_log.SelectionStart = textBox_log.Text.Length;
                textBox_log.SelectionLength = 0;
                textBox_log.ScrollToCaret();
                sreader.Close();
                fstream.Close();
            }
            catch
            {

            }
        }

        private void button_gotomain_Click(object sender, EventArgs e)
        {
            switch_to_product(menu.m_principal);
        }

        private void button_entree_1_Click(object sender, EventArgs e)
        {
            numeric_entree_1.Value++;
        }

        private void button_entree_2_Click(object sender, EventArgs e)
        {
            numeric_entree_2.Value++;
        }

        private void button_entree_3_Click(object sender, EventArgs e)
        {
            numeric_entree_3.Value++;
        }

        private void button_entree_4_Click(object sender, EventArgs e)
        {
            numeric_entree_4.Value++;
        }

        private void button_entree_5_Click(object sender, EventArgs e)
        {
            numeric_entree_5.Value++;
        }

        private void button_entree_6_Click(object sender, EventArgs e)
        {
            numeric_entree_6.Value++;
        }

        private void button_entree_7_Click(object sender, EventArgs e)
        {
            numeric_entree_7.Value++;
        }

        private void button_entree_8_Click(object sender, EventArgs e)
        {
            numeric_entree_8.Value++;
        }

        private void button_entree_9_Click(object sender, EventArgs e)
        {
            numeric_entree_9.Value++;
        }

        private void button_dessert_1_Click(object sender, EventArgs e)
        {
            numeric_dessert_1.Value++;
        }

        private struct produit
        {
            public string name;
            public double nombre;
            public double prix;
            public produit(string name, double nombre, double prix)
            {
                this.name = name;
                this.nombre = nombre;
                this.prix = prix;
            }
        };

        private double calc_recette()
        {
            return calc_recette(false);
        }

        private double calc_recette(bool print)
        {
            double divers_10 = 0;
            double divers_20 = 0;
            double.TryParse(numeric_plat_22.Text, out divers_10);
            double.TryParse(numeric_plat_23.Text, out divers_20);
            List<produit> produits = new List<produit>();
            produits.Add(new produit(button_dessert_1.Text, (double)numeric_dessert_1.Value, 3.30));
            produits.Add(new produit(button_dessert_2.Text, (double)numeric_dessert_2.Value, 4.70));
            produits.Add(new produit(button_dessert_3.Text, (double)numeric_dessert_3.Value, 5.20));
            produits.Add(new produit(button_dessert_4.Text, (double)numeric_dessert_4.Value, 1.90));
            produits.Add(new produit(button_dessert_5.Text, (double)numeric_dessert_5.Value, 3.70));
            produits.Add(new produit(button_dessert_6.Text, (double)numeric_dessert_6.Value, 3.90));
            produits.Add(new produit(button_dessert_7.Text, (double)numeric_dessert_7.Value, 1.00));

            produits.Add(new produit(button_entree_1.Text, (double)numeric_entree_1.Value, 5.60));
            produits.Add(new produit(button_entree_2.Text, (double)numeric_entree_2.Value, 6.80));
            produits.Add(new produit(button_entree_3.Text, (double)numeric_entree_3.Value, 4.90));
            produits.Add(new produit(button_entree_4.Text, (double)numeric_entree_4.Value, 5.00));
            produits.Add(new produit(button_entree_5.Text, (double)numeric_entree_5.Value, 6.30));
            produits.Add(new produit(button_entree_6.Text, (double)numeric_entree_6.Value, 6.00));
            produits.Add(new produit(button_entree_7.Text, (double)numeric_entree_7.Value, 6.70));
            produits.Add(new produit(button_entree_8.Text, (double)numeric_entree_8.Value, 5.10));
            produits.Add(new produit(button_entree_9.Text, (double)numeric_entree_9.Value, 6.30));
            produits.Add(new produit(button_entree_10.Text, (double)numeric_entree_10.Value, 4.80));

            produits.Add(new produit(button_plat_1.Text, (double)numeric_plat_1.Value, 8.20));
            produits.Add(new produit(button_plat_2.Text, (double)numeric_plat_2.Value, 10.00));
            produits.Add(new produit(button_plat_3.Text, (double)numeric_plat_3.Value, 6.50));
            produits.Add(new produit(button_plat_4.Text, (double)numeric_plat_4.Value, 6.80));
            produits.Add(new produit(button_plat_5.Text, (double)numeric_plat_5.Value, 7.30));
            produits.Add(new produit(button_plat_6.Text, (double)numeric_plat_6.Value, 7.00));
            produits.Add(new produit(button_plat_7.Text, (double)numeric_plat_7.Value, 7.30));
            produits.Add(new produit(button_plat_8.Text, (double)numeric_plat_8.Value, 6.90));
            produits.Add(new produit(button_plat_9.Text, (double)numeric_plat_9.Value, 7.70));
            produits.Add(new produit(button_plat_10.Text, (double)numeric_plat_10.Value, 6.50));
            produits.Add(new produit(button_plat_11.Text, (double)numeric_plat_11.Value, 7.20));
            produits.Add(new produit(button_plat_12.Text, (double)numeric_plat_12.Value, 7.00));
            produits.Add(new produit(button_plat_13.Text, (double)numeric_plat_13.Value, 13.50));
            produits.Add(new produit(button_plat_14.Text, (double)numeric_plat_14.Value, 7.30));
            produits.Add(new produit(button_plat_15.Text, (double)numeric_plat_15.Value, 7.90));
            produits.Add(new produit(button_plat_16.Text, (double)numeric_plat_16.Value, 8.20));
            produits.Add(new produit(button_plat_17.Text, (double)numeric_plat_17.Value, 3.80));
            produits.Add(new produit(button_plat_18.Text, (double)numeric_plat_18.Value, 3.00));
            produits.Add(new produit(button_plat_19.Text, (double)numeric_plat_19.Value, 4.10));

            produits.Add(new produit(button_plat_20.Text, (double)numeric_plat_20.Value, 17.5));
            produits.Add(new produit(button_plat_21.Text, (double)numeric_plat_21.Value, 12.9));

            produits.Add(new produit(button_boisson_1.Text, (double)numeric_boisson_1.Value, 3.50));
            produits.Add(new produit(button_boisson_2.Text, (double)numeric_boisson_2.Value, 3.50));
            produits.Add(new produit(button_boisson_3.Text, (double)numeric_boisson_3.Value, 2.50));
            produits.Add(new produit(button_boisson_4.Text, (double)numeric_boisson_4.Value, 1.90));
            produits.Add(new produit(button_boisson_5.Text, (double)numeric_boisson_5.Value, 2.50));
            produits.Add(new produit(button_boisson_6.Text, (double)numeric_boisson_6.Value, 2.90));
            produits.Add(new produit(button_boisson_7.Text, (double)numeric_boisson_7.Value, 2.50));
            produits.Add(new produit(button_boisson_8.Text, (double)numeric_boisson_8.Value, 4.50));
            produits.Add(new produit(button_boisson_9.Text, (double)numeric_boisson_9.Value, 7.00));
            produits.Add(new produit(button_boisson_10.Text, (double)numeric_boisson_10.Value, 13.90));
            produits.Add(new produit(button_boisson_11.Text, (double)numeric_boisson_11.Value, 9.90));
            produits.Add(new produit(button_boisson_12.Text, (double)numeric_boisson_12.Value, 14.90));
            produits.Add(new produit(button_boisson_13.Text, (double)numeric_boisson_13.Value, 9.90));
            produits.Add(new produit(button_boisson_14.Text, (double)numeric_boisson_14.Value, 9.90));
            produits.Add(new produit(button_boisson_15.Text, (double)numeric_boisson_15.Value, 14.90));
            produits.Add(new produit(button_boisson_16.Text, (double)numeric_boisson_16.Value, 9.20));
            produits.Add(new produit(button_boisson_17.Text, (double)numeric_boisson_17.Value, 13.50));
            produits.Add(new produit(button_boisson_18.Text, (double)numeric_boisson_18.Value, 11.90));
            produits.Add(new produit(button_boisson_19.Text, (double)numeric_boisson_19.Value, 3.50));
            produits.Add(new produit(button_boisson_20.Text, (double)numeric_boisson_20.Value, 7.90));
            produits.Add(new produit(button_boisson_21.Text, (double)numeric_boisson_21.Value, 11.50));
            produits.Add(new produit(button_boisson_22.Text, (double)numeric_boisson_22.Value, 32.00));
            produits.Add(new produit(button_boisson_23.Text, (double)numeric_boisson_23.Value, 20.00));
            produits.Add(new produit(button_boisson_24.Text, (double)numeric_boisson_24.Value, 3.50));
            produits.Add(new produit(button_boisson_25.Text, (double)numeric_boisson_25.Value, 2.50));
            produits.Add(new produit(button_boisson_26.Text, (double)numeric_boisson_26.Value, 3.70));
            produits.Add(new produit(button_boisson_27.Text, (double)numeric_boisson_27.Value, 3.90));

            string facture = "Prix\tQuantité\t\tProduit\n" +
                             "=====================================\n";

            double prix_total = 0;
            foreach(produit p in produits)
            {
                if (p.nombre != 0)
                {
                    prix_total += p.nombre * p.prix;
                    facture += string.Format("{0} €\tx{1}\t\t{2}\n", p.prix.ToString("#,#.00#;(#,#.00#)"), p.nombre, p.name);
                }
            }
            prix_total += divers_10 + divers_20;
            if (divers_10 != 0)
                facture += string.Format("{0:0.00} €\t\t\tDivers 10%\n", divers_10);
            if (divers_20 != 0)
                facture += string.Format("{0:0.00} €\t\t\tDivers 20%\n", divers_20);
            facture += "=====================================\n";
            facture += string.Format("Prix total:\t\t\t{0:0.00} €\n", prix_total);
            if (b_emporter)
            {
                facture += string.Format("Réduction -10% a emporter :\t-{0:0.00} €\n", prix_total * 0.1);
                facture += string.Format("Prix final :\t\t\t{0:0.00} €\n", prix_total * 0.9);
                prix_total *= 0.9;
            }
            if (print)
            {
                MessageBox.Show(facture);
            }
            return prix_total;
        }

        private void enregistre_prix(double prix)
        {
            FileStream log_stream = new FileStream("log.txt", FileMode.Append);
            StreamWriter log = new StreamWriter(log_stream);
            
            log.WriteLine(DateTime.Now.ToString() + string.Format(" : {0:0.00} €", prix));
            log.Close();
            log_stream.Close();
        }

        private void button_calc_Click(object sender, EventArgs e)
        {
            double recette = calc_recette(true);
            MessageBox.Show(string.Format("{0:0.00} €", recette), "Recette");
            enregistre_prix(recette);
        }

        private void button_dessert_2_Click(object sender, EventArgs e)
        {
            numeric_dessert_2.Value++;
        }

        private void button_dessert_3_Click(object sender, EventArgs e)
        {
            numeric_dessert_3.Value++;
        }

        private void button_dessert_4_Click(object sender, EventArgs e)
        {
            numeric_dessert_4.Value++;
        }

        private void button_plat_1_Click(object sender, EventArgs e)
        {
            numeric_plat_1.Value++;
        }

        private void button_plat_2_Click(object sender, EventArgs e)
        {
            numeric_plat_2.Value++;
        }

        private void button_plat_3_Click(object sender, EventArgs e)
        {
            numeric_plat_3.Value++;
        }

        private void button_plat_4_Click(object sender, EventArgs e)
        {
            numeric_plat_4.Value++;
        }

        private void button_plat_5_Click(object sender, EventArgs e)
        {
            numeric_plat_5.Value++;
        }

        private void button_plat_6_Click(object sender, EventArgs e)
        {
            numeric_plat_6.Value++;
        }

        private void button_plat_7_Click(object sender, EventArgs e)
        {
            numeric_plat_7.Value++;
        }

        private void button_plat_8_Click(object sender, EventArgs e)
        {
            numeric_plat_8.Value++;
        }

        private void button_plat_9_Click(object sender, EventArgs e)
        {
            numeric_plat_9.Value++;
        }

        private void button_plat_10_Click(object sender, EventArgs e)
        {
            numeric_plat_10.Value++;
        }

        private void button_plat_11_Click(object sender, EventArgs e)
        {
            numeric_plat_11.Value++;
        }

        private void button_plat_12_Click(object sender, EventArgs e)
        {
            numeric_plat_12.Value++;
        }

        private void button_plat_13_Click(object sender, EventArgs e)
        {
            numeric_plat_13.Value++;
        }

        private void button_plat_14_Click(object sender, EventArgs e)
        {
            numeric_plat_14.Value++;
        }

        private void button_plat_15_Click(object sender, EventArgs e)
        {
            numeric_plat_15.Value++;
        }

        private void button_plat_16_Click(object sender, EventArgs e)
        {
            numeric_plat_16.Value++;
        }

        private void button_plat_17_Click(object sender, EventArgs e)
        {
            numeric_plat_17.Value++;
        }

        private void button_plat_18_Click(object sender, EventArgs e)
        {
            numeric_plat_18.Value++;
        }

        private void button_plat_19_Click(object sender, EventArgs e)
        {
            numeric_plat_19.Value++;
        }

        private void button_plat_20_Click(object sender, EventArgs e)
        {
            numeric_plat_20.Value++;
        }

        private void button_plat_21_Click(object sender, EventArgs e)
        {
            numeric_plat_21.Value++;
        }

        private void button_boisson_1_Click(object sender, EventArgs e)
        {
            numeric_boisson_1.Value++;
        }

        private void button_boisson_2_Click(object sender, EventArgs e)
        {
            numeric_boisson_2.Value++;
        }

        private void button_boisson_6_Click(object sender, EventArgs e)
        {
            numeric_boisson_6.Value++;
        }

        private void button_boisson_19_Click(object sender, EventArgs e)
        {
            numeric_boisson_19.Value++;
        }

        private void button_boisson_3_Click(object sender, EventArgs e)
        {
            numeric_boisson_3.Value++;
        }

        private void button_boisson_4_Click(object sender, EventArgs e)
        {
            numeric_boisson_4.Value++;
        }

        private void button_boisson_5_Click(object sender, EventArgs e)
        {
            numeric_boisson_5.Value++;
        }

        private void button_boisson_10_Click(object sender, EventArgs e)
        {
            numeric_boisson_10.Value++;
        }

        private void button_boisson_11_Click(object sender, EventArgs e)
        {
            numeric_boisson_11.Value++;
        }

        private void button_boisson_14_Click(object sender, EventArgs e)
        {
            numeric_boisson_14.Value++;
        }

        private void button_boisson_15_Click(object sender, EventArgs e)
        {
            numeric_boisson_15.Value++;
        }

        private void button_boisson_20_Click(object sender, EventArgs e)
        {
            numeric_boisson_20.Value++;
        }

        private void button_boisson_21_Click(object sender, EventArgs e)
        {
            numeric_boisson_21.Value++;
        }

        private void button_boisson_16_Click(object sender, EventArgs e)
        {
            numeric_boisson_16.Value++;
        }

        private void button_boisson_17_Click(object sender, EventArgs e)
        {
            numeric_boisson_17.Value++;
        }

        private void button_boisson_12_Click(object sender, EventArgs e)
        {
            numeric_boisson_12.Value++;
        }

        private void button_boisson_13_Click(object sender, EventArgs e)
        {
            numeric_boisson_13.Value++;
        }

        private void button_boisson_7_Click(object sender, EventArgs e)
        {
            numeric_boisson_7.Value++;
        }

        private void button_boisson_8_Click(object sender, EventArgs e)
        {
            numeric_boisson_8.Value++;
        }

        private void button_boisson_9_Click(object sender, EventArgs e)
        {
            numeric_boisson_9.Value++;
        }

        private void button_boisson_18_Click(object sender, EventArgs e)
        {
            numeric_boisson_18.Value++;
        }

        private void button_dessert_5_Click(object sender, EventArgs e)
        {
            numeric_dessert_5.Value++;
        }

        private void button_dessert_6_Click(object sender, EventArgs e)
        {
            numeric_dessert_6.Value++;
        }

        private void button_dessert_7_Click(object sender, EventArgs e)
        {
            numeric_dessert_7.Value++;
        }

        private void numeric_plat_22_TextChanged(object sender, EventArgs e)
        {
            double result;
            button_plat_22.Enabled = double.TryParse(numeric_plat_22.Text, out result);
            numeric_ValueChanged(sender, e);
        }


        private void numeric_plat_23_TextChanged(object sender, EventArgs e)
        {
            double result;
            button_plat_23.Enabled = double.TryParse(numeric_plat_23.Text, out result);
            numeric_ValueChanged(sender, e);
        }

        private void button_boisson_22_Click(object sender, EventArgs e)
        {
            numeric_boisson_22.Value++;
        }

        private void button_boisson_23_Click(object sender, EventArgs e)
        {
            numeric_boisson_23.Value++;
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Remettre à zéro ?", "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                File.Delete("log.txt");
                textBox_log.Text = "";
            }
        }

        private void button_raz_Click(object sender, EventArgs e)
        {
            numeric_boisson_1.Value = 0;
            numeric_boisson_2.Value = 0;
            numeric_boisson_3.Value = 0;
            numeric_boisson_4.Value = 0;
            numeric_boisson_5.Value = 0;
            numeric_boisson_6.Value = 0;
            numeric_boisson_7.Value = 0;
            numeric_boisson_8.Value = 0;
            numeric_boisson_9.Value = 0;
            numeric_boisson_10.Value = 0;
            numeric_boisson_11.Value = 0;
            numeric_boisson_12.Value = 0;
            numeric_boisson_13.Value = 0;
            numeric_boisson_14.Value = 0;
            numeric_boisson_15.Value = 0;
            numeric_boisson_16.Value = 0;
            numeric_boisson_17.Value = 0;
            numeric_boisson_18.Value = 0;
            numeric_boisson_19.Value = 0;
            numeric_boisson_20.Value = 0;
            numeric_boisson_21.Value = 0;
            numeric_boisson_22.Value = 0;
            numeric_boisson_23.Value = 0;
            numeric_boisson_24.Value = 0;
            numeric_boisson_25.Value = 0;
            numeric_boisson_26.Value = 0;
            numeric_boisson_27.Value = 0;

            numeric_plat_1.Value = 0;
            numeric_plat_2.Value = 0;
            numeric_plat_3.Value = 0;
            numeric_plat_4.Value = 0;
            numeric_plat_5.Value = 0;
            numeric_plat_6.Value = 0;
            numeric_plat_7.Value = 0;
            numeric_plat_8.Value = 0;
            numeric_plat_9.Value = 0;
            numeric_plat_10.Value = 0;
            numeric_plat_11.Value = 0;
            numeric_plat_12.Value = 0;
            numeric_plat_13.Value = 0;
            numeric_plat_14.Value = 0;
            numeric_plat_15.Value = 0;
            numeric_plat_16.Value = 0;
            numeric_plat_17.Value = 0;
            numeric_plat_18.Value = 0;
            numeric_plat_19.Value = 0;
            numeric_plat_20.Value = 0;
            numeric_plat_21.Value = 0;
            numeric_plat_22.Text = "";
            numeric_plat_23.Text = "";

            numeric_entree_1.Value = 0;
            numeric_entree_2.Value = 0;
            numeric_entree_3.Value = 0;
            numeric_entree_4.Value = 0;
            numeric_entree_5.Value = 0;
            numeric_entree_6.Value = 0;
            numeric_entree_7.Value = 0;
            numeric_entree_8.Value = 0;
            numeric_entree_9.Value = 0;
            numeric_entree_10.Value = 0;

            numeric_dessert_1.Value = 0;
            numeric_dessert_2.Value = 0;
            numeric_dessert_3.Value = 0;
            numeric_dessert_4.Value = 0;
            numeric_dessert_5.Value = 0;
            numeric_dessert_6.Value = 0;
            numeric_dessert_7.Value = 0;
        }

        private void numeric_ValueChanged(object sender, EventArgs e)
        {
            double rec = calc_recette();
            label_prix.Text = string.Format("Prix: {0:0.00} €", rec);
        }

        private void button_entree_10_Click(object sender, EventArgs e)
        {
            numeric_entree_10.Value++;
        }

        private void button_boisson_24_Click(object sender, EventArgs e)
        {
            numeric_boisson_24.Value++;
        }

        private void button_boisson_25_Click(object sender, EventArgs e)
        {
            numeric_boisson_25.Value++;
        }

        private void button_boisson_26_Click(object sender, EventArgs e)
        {
            numeric_boisson_26.Value++;
        }

        private void button_boisson_27_Click(object sender, EventArgs e)
        {
            numeric_boisson_27.Value++;
        }
    }
}
