using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Beamgage_Fertigg;
using Spektrum_Fertig;

namespace Gefärdungberechnen
{
    public partial class Form1 : Form
    {
        Gefaehrdungberechnen test = new Gefaehrdungberechnen();


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            test.Gesamtleistung = Convert.ToDouble(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            test.getblaulichtwirk();
            test.getuvwirkfkt();
            test.getverbrennungsgefahrwirkfkt();
            test.getspektrumcounts();

           


        }

        private void button4_Click(object sender, EventArgs e)
        {
            test.Flag= Convert.ToBoolean(textBox2.Text);

            test.spektrumnomrieren();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            test.beamgageöffnen();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            test.readdata();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            test.getGefährdungsstufe();

            pictureBox1.Image = test.Bitma;
           
                listBox1.Items.Add(test.ExpositionsgrenzwertA);


        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            test.testbitmap();
        }
    }
}
