using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void button_dessert_1_Click(object sender, EventArgs e)
        {
            numeric_dessert_1.Value++;
        }

        private double calc_recette()
        {
            return (double)numeric_dessert_1.Value * 3.30 +
                   (double)numeric_entree_1.Value * 5.60 +
                   (double)numeric_entree_2.Value * 6.80;
        }

        private void button_calc_Click(object sender, EventArgs e)
        {
            MessageBox.Show(calc_recette().ToString("#,#.00#;(#,#.00#)") + " €", "Recette");
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void numeric_dessert_1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button_entree_3_Click(object sender, EventArgs e)
        {

        }

        private void button_entree_6_Click(object sender, EventArgs e)
        {

        }
    }
}
