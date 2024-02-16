using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KrekluApdruka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void Teksts_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Zime_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Bilde_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void skaits_ValueChanged(object sender, EventArgs e)
        {

        }

        private void piegade_CheckedChanged(object sender, EventArgs e)
        {

        }












        
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string veids = "";

            if (Teksts.Checked)
            {
                veids = "Teksts";
            }
            else if (Zime.Checked)
            {
                veids = "Zime";
            }
            else if (Bilde.Checked)
            {
                veids = "Bilde";
            }
            int daudzums = Convert.ToInt32(Math.Round(skaits.Value, 0));

            tkreklupasutisana(daudzums, veids, piegade.Checked);
        }
        private void tkreklupasutisana(int skaits, string veids, bool piegade)
        {
            double summas = 0;
            double atlaide_summa = 0;

            if (veids == "Teksts")
            {
                summas = summas + 5;
            }
            else if (veids == "Zime")
            {
                summas = summas + 7;
            }
            else if (veids == "Bilde")
            {
                summas = summas + 20;
            }

            
            summas = summas * skaits;
            if (piegade)
            {
                if (summas < 50)
                {
                    summas = summas + 15;
                }


            }
            if (summas > 100)
            {

               atlaide_summa = summas - (summas * 0.05);

            }
            else
            {
                atlaide_summa = summas;
            }

            summa.Text = $"{atlaide_summa.ToString("0.00")}";

            summa2.Text = $"{summas.ToString("0.00")}";
        }

    }
}
