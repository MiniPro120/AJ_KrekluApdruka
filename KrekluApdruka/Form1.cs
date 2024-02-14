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
            double  summas = 0;

            if (Teksts.Checked)
            {
                summas = summas + 5;
            }
            else if (Zime.Checked)
            {
                summas = summas + 7;
            }
            else if (Bilde.Checked)
            {
                summas = summas + 20;
            }

            int daudzums = Convert.ToInt32(Math.Round(skaits.Value, 0));
            summas = summas * daudzums;
            if (piegade.Checked)
            {
                if(summas < 50)
                {
                    summas = summas + 15;
                }
                else if(summas > 50)
                {
                    summas = summas;
                }
                
            }
            if (summas > 100)
            {
                summas = summas  - (summas * 0.05);

            }

            summa.Text = $"{summas.ToString("0.00")}";
        }
    }
}
