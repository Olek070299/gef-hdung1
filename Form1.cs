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
            test.Gesamtleistungkamera = double.Parse(textBox1.Text);
             test.Gesamtleistung14rad = double.Parse(textBox6.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            test.getblaulichtwirk();
            test.getuvwirkfkt();
            test.getverbrennungsgefahrwirkfkt();
            test.getspektrumcounts();

           


        }

       

        private void button5_Click(object sender, EventArgs e)
        {
            test.beamgageöffnen();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            test.readdata();


            pictureBox1.Image = test.Bitma;
        }

        private void button7_Click(object sender, EventArgs e)
        {
          


         
           
            test.getBlaulicht();
           
            test.getNetzhautthermisch();
            test.getNetzhautthermischschwacherreiz();

            test.getaktinischesUVHautAuge();
            test.getAugeUVA();
            test.getIRSTRahlung();





            pictureBox1.Image = test.Bitma;
           
            listBox1.Items.Add("EwertA="+test.ExpositionsgrenzwertA);
            listBox1.Items.Add("EwertB=" + test.ExpositionsgrenzwertB);
            listBox1.Items.Add("EwertC=" + test.ExpositionsgrenzwertC);
            listBox1.Items.Add("EwertD=" + test.ExpositionsgrenzwertD);
            listBox1.Items.Add("EwertE=" + test.ExpositionsgrenzwertE);
            listBox1.Items.Add("EwertF=" + test.ExpositionsgrenzwertF);
            listBox1.Items.Add("EwertG=" + test.ExpositionsgrenzwertG);
            listBox1.Items.Add("EwertH=" + test.ExpositionsgrenzwertH);
            listBox1.Items.Add("EwertI=" + test.ExpositionsgrenzwertI);
            listBox1.Items.Add("EwertJ=" + test.ExpositionsgrenzwertJ);
            listBox1.Items.Add("EwertK=" + test.ExpositionsgrenzwertK);
            listBox1.Items.Add("EwertL=" + test.ExpositionsgrenzwertL);
            listBox1.Items.Add("EwertM=" + test.ExpositionsgrenzwertM);
            listBox1.Items.Add("EwertN=" + test.ExpositionsgrenzwertN);
            listBox1.Items.Add("EwertO=" + test.ExpositionsgrenzwertO);



            listBox1.Items.Add("EwertA"+test.ExpositionswertA);
            listBox1.Items.Add("Ewertb" + test.ExpositionswertB);
            listBox1.Items.Add("Ewertc" + test.ExpositionswertC);
            listBox1.Items.Add("Ewertd" + test.ExpositionswertD);
            listBox1.Items.Add("Ewerte" + test.ExpositionswertE);
            listBox1.Items.Add("Ewertf" + test.ExpositionswertF);
            listBox1.Items.Add("Ewertg" + test.ExpositionswertG);
            listBox1.Items.Add("Ewerth" + test.ExpositionswertH);
            listBox1.Items.Add("Ewerti" + test.ExpositionswertI);
            listBox1.Items.Add("Ewertj" + test.ExpositionswertJ);
            listBox1.Items.Add("Ewertk" + test.ExpositionswertK);
            listBox1.Items.Add("Ewertl" + test.ExpositionswertL);
            listBox1.Items.Add("Ewertm" + test.ExpositionswertM);
            listBox1.Items.Add("Ewertn" + test.ExpositionswertN);
            listBox1.Items.Add("Ewerto" + test.ExpositionswertO);

           



        }
        
         private void button9_Click(object sender, EventArgs e)
        {
            test.Empfangswinkel = double.Parse(textBox4.Text);
            test.Bildabstand = double.Parse(textBox5.Text);


            test.gethotspot(test.Empfangswinkel, test.Bildabstand);
            
            test.getAugeHautUVlichtgefahrTROS();
            test.getkataraktogeneseTROS();
            test.getHornhautverbrennungundkataraktogeneseTROS();
            test.gethautverbrennungTROS();
            

            test.getblaulichtgefahrAugeTROS(double.Parse(textBox4.Text));

            test.getVerbrennungsgefahrschwachervisuellerreizTROS(double.Parse(textBox4.Text));
            test.getVerbrennungsgefahrTROS(double.Parse(textBox4.Text));

           pictureBox1.Image =test.Bitma;




        }
        private void button3_Click(object sender, EventArgs e)
        {
            test.testbitmap();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            test.Time = double.Parse(textBox3.Text);
            
        }

      
    }
}
