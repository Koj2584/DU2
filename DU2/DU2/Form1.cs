using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DU2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cislo, soucet = 0, pocet = 0, mini = int.MaxValue, pocetInterval = 0;
            try
            {
                for (int i = 0; i < textBox1.Lines.Count(); i++)
                {
                    cislo = Convert.ToInt32(textBox1.Lines[i]);
                    pocet++;
                    soucet += cislo;
                    if (cislo < mini)
                        mini = cislo;
                    if (cislo >= 5 && cislo < 30)
                        pocetInterval++;
                }
                label2.Text = "Průměr čísel je " + ((double)soucet / pocet);
                label3.Text = "Minimální číslo je " + mini;
                label4.Text = "Počet čísel v intervalu <5;30) je " + pocetInterval;
            }
            catch
            {
                MessageBox.Show("Nesprávný formát!!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
