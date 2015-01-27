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
        public Form1()
        {
            InitializeComponent();
        }

        private void switch_to_product(bool invert)
        {
            Quitter.Enabled = invert;
            Quitter.Visible = invert;
            Emporter.Enabled = invert;
            Emporter.Visible = invert;
            Sur_place.Enabled = invert;
            Sur_place.Visible = invert;
            Plus.Enabled = invert;
            Plus.Visible = invert;
            tabControl.Visible = !invert;
            tabControl.Enabled = !invert;
            button_calc.Visible = !invert;
            button_calc.Enabled = !invert;
            button_gotomain.Visible = !invert;
            button_gotomain.Enabled = !invert;
        }

        private void Quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Emporter_Click(object sender, EventArgs e)
        {
            switch_to_product(false);
        }

        private void Sur_place_Click(object sender, EventArgs e)
        {
            switch_to_product(false);
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            switch_to_product(false);
        }

        private void button_gotomain_Click(object sender, EventArgs e)
        {
            switch_to_product(true);
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

        private double calc_recette()
        {
            return (double)numeric_dessert_1.Value * 3.30 +
                   (double)numeric_dessert_2.Value * 4.70 +
                   (double)numeric_dessert_3.Value * 5.20 +
                   (double)numeric_dessert_4.Value * 1.90 +
                   (double)numeric_dessert_5.Value * 3.70 +
                   (double)numeric_dessert_6.Value * 3.90 +
                   (double)numeric_dessert_7.Value * 1.00 +

                   (double)numeric_entree_1.Value * 5.60 +
                   (double)numeric_entree_2.Value * 6.80 +
                   (double)numeric_entree_3.Value * 4.90 +
                   (double)numeric_entree_4.Value * 5.00 +
                   (double)numeric_entree_5.Value * 6.30 +
                   (double)numeric_entree_6.Value * 6.00 +
                   (double)numeric_entree_7.Value * 6.70 +
                   (double)numeric_entree_8.Value * 5.10 +
                   (double)numeric_entree_9.Value * 6.30 +

                   (double)numeric_plat_1.Value * 8.20 +
                   (double)numeric_plat_2.Value * 10.0 +
                   (double)numeric_plat_3.Value * 6.50 +
                   (double)numeric_plat_4.Value * 6.80 +
                   (double)numeric_plat_5.Value * 7.30 +
                   (double)numeric_plat_6.Value * 7.20 +
                   (double)numeric_plat_7.Value * 7.30 +
                   (double)numeric_plat_8.Value * 6.90 +
                   (double)numeric_plat_9.Value * 7.70 +
                   (double)numeric_plat_10.Value * 6.50 +
                   (double)numeric_plat_11.Value * 7.20 +
                   (double)numeric_plat_12.Value * 7.00 +
                   (double)numeric_plat_13.Value * 13.5 +
                   (double)numeric_plat_14.Value * 7.30 +
                   (double)numeric_plat_15.Value * 7.90 +
                   (double)numeric_plat_16.Value * 8.20 +
                   (double)numeric_plat_17.Value * 3.80 +
                   (double)numeric_plat_18.Value * 3.00 +
                   (double)numeric_plat_19.Value * 4.10 +

                   (double)numeric_plat_20.Value * 17.5 +
                   (double)numeric_plat_21.Value * 12.9 +

                   (double)numeric_boisson_1.Value * 3.50 +
                   (double)numeric_boisson_2.Value * 3.50 +
                   (double)numeric_boisson_3.Value * 2.50 +
                   (double)numeric_boisson_4.Value * 1.90 +
                   (double)numeric_boisson_5.Value * 2.50 +
                   (double)numeric_boisson_6.Value * 2.90 +
                   (double)numeric_boisson_7.Value * 2.50 +
                   (double)numeric_boisson_8.Value * 4.50 +
                   (double)numeric_boisson_9.Value * 7.00 +
                   (double)numeric_boisson_10.Value * 13.9 +
                   (double)numeric_boisson_11.Value * 9.90 +
                   (double)numeric_boisson_12.Value * 14.9 +
                   (double)numeric_boisson_13.Value * 9.90 +
                   (double)numeric_boisson_14.Value * 9.90 +
                   (double)numeric_boisson_15.Value * 14.9 +
                   (double)numeric_boisson_16.Value * 9.20 +
                   (double)numeric_boisson_17.Value * 13.5 +
                   (double)numeric_boisson_18.Value * 11.9 +
                   (double)numeric_boisson_19.Value * 3.50 +
                   (double)numeric_boisson_20.Value * 7.90 +
                   (double)numeric_boisson_21.Value * 11.5 +
                   (double)numeric_boisson_22.Value * 32.0 +
                   (double)numeric_boisson_23.Value * 20.0 
                   ;



        }

        private void enregistre_prix(double prix)
        {
            FileStream log_stream = new FileStream("log.txt", FileMode.Append);
            StreamWriter log = new StreamWriter(log_stream);
            
            log.WriteLine(DateTime.Now.ToString() + " : " + prix.ToString("#,#.00#;(#,#.00#)") + " €");
            log.Close();
            log_stream.Close();
        }

        private void button_calc_Click(object sender, EventArgs e)
        {
            double recette = calc_recette();
            MessageBox.Show(recette.ToString("#,#.00#;(#,#.00#)") + " €", "Recette");
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


    }
}
