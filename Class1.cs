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

    



            

            class Gefaehrdungberechnen
            {

        private string risikostufeaktinischesUV;
        public string RisikostufeaktinischesUV { get { return risikostufeaktinischesUV; } set { risikostufeaktinischesUV = value; } }


        private string risikostufeAugeUVA;
        public string RisikostufeAugeUVA { get { return risikostufeAugeUVA; } set { risikostufeAugeUVA = value; } }


        private string risikostufeBlaulicht;
        public string RisikostufeBlaulicht { get { return risikostufeBlaulicht; } set { risikostufeBlaulicht = value; } }


        private string risikostufeBlaulichtkleinequelle;
        public string RisikostufeBlaulichtkleinequelle { get { return risikostufeBlaulichtkleinequelle; } set { risikostufeBlaulichtkleinequelle = value; } }


        private string risikostufeNetzhauthermisch;
        public string RisikostufeNetzhautthermisch { get { return risikostufeNetzhauthermisch; } set { risikostufeNetzhauthermisch = value; } }


        private string risikostufeNetzhauthermischschwachereiz;
        public string Risikostufethermischschwacherreiz { get { return risikostufeNetzhauthermischschwachereiz; } set { risikostufeNetzhauthermischschwachereiz = value; } }



        private string risikostufeIRstrahlung;
        public string RisikostufeIRstrahlung { get { return risikostufeIRstrahlung; } set { risikostufeIRstrahlung = value; } }


        private double gesamtleistung14rad;
        public double Gesamtleistung14rad { get { return gesamtleistung14rad; } set { gesamtleistung14rad = value; } }


        private double gesamtleistungKamera;
        public double Gesamtleistungkamera { get { return gesamtleistungKamera; } set { gesamtleistungKamera = value; } }

        private List<double> prozentualerAnteil;

        public List<double> ProzentualerAnzeil { get { return prozentualerAnteil; } set { prozentualerAnteil = value; } }
     



        private double gewichteteLeistung;
        public double GewichteteLeistung { get { return gewichteteLeistung; } set { gewichteteLeistung = value; } }

        private double aperaturradius;
        public double Aperaturradius { get { return aperaturradius; } set { aperaturradius = value; } }



        private List<double> blaulichtgefahrwirkfkt;
                public List<double> Blaulichtgefahrwirkfkt
                {
                    get { return blaulichtgefahrwirkfkt; }
                    set { blaulichtgefahrwirkfkt = value; }
                }
        private List<double> zwspeicherliste=new List<double>();
        public List<double> Zwspeicherliste
        {
            get { return zwspeicherliste; }
            set { zwspeicherliste = value; }
        }


        private Bitmap bitma;
       public Bitmap Bitma { set { bitma = value; } get { return bitma; } }

        private Bitmap bitma17;
        public Bitmap Bitma17 { set { bitma17 = value; } get { return bitma17; } }

        private Bitmap bitma11;
        public Bitmap Bitma11 { set { bitma11 = value; } get { return bitma11; } }

        private Bitmap bitma100;
        public Bitmap Bitma100 { set { bitma100 = value; } get { return bitma100; } }



        int x = 0;
        int y = 0;



        private List<double> uvgefahrwirkfkt;
                public List<double> UVgefahrwirkfkt
                {
                    get { return uvgefahrwirkfkt; }
                    set { uvgefahrwirkfkt = value; }
                }

                private List<double> verbrennungsgefahrwirkfkt;
                public List<double> Verbrennungsgefahrwirkfkt
                {
                    get { return verbrennungsgefahrwirkfkt; }
                    set { verbrennungsgefahrwirkfkt = value; }
                }
        private List<double> spektrumcounts;
        public List<double> Spektrumcounts
        {
            get { return spektrumcounts; }
            set { spektrumcounts = value; }
        }


        private double expositionsgrenzwertA;
        public double ExpositionsgrenzwertA { get { return expositionsgrenzwertA; } set { expositionsgrenzwertA = value; } }


        private double photochemischeNetzhautgefaehrdung;
        public double PhotochemischeNetzhautgefaehrdung { get { return photochemischeNetzhautgefaehrdung; } set { photochemischeNetzhautgefaehrdung = value; } }


        private double thermischeNetzhautgefaehrdung;
        public double ThermischeNetzhautgefaehrdung { get { return thermischeNetzhautgefaehrdung; } set { thermischeNetzhautgefaehrdung = value; } }

        private double thermischeNethautgefahrimIRA;
        public double ThermischeNethautgefahrimIRA { get { return thermischeNethautgefahrimIRA; } set { thermischeNethautgefahrimIRA = value; } }

        private double aktinischeUVGefahrauge;
        public double aktinischeUVgefahrauge { get { return aktinischeUVgefahrauge; } set { aktinischeUVgefahrauge = value; } }


        private double augegefahrimUVA;
        public double AugegafahrimUVA { get { return augegefahrimUVA; } set { augegefahrimUVA = value; } }

        private double gefahraugeIR;
        public double GefahraugeIR { get { return gefahraugeIR; } set { gefahraugeIR = value; } }

        private double photchemischeNetzhautgefahrkleineQuelle;
        public double PhotochemischeNetzhautgefaehrdungkleineQuelle { get { return photchemischeNetzhautgefahrkleineQuelle; } set { photchemischeNetzhautgefahrkleineQuelle = value; } }





        private double expositionsgrenzwertB;
        public double ExpositionsgrenzwertB { get { return expositionsgrenzwertB; } set { expositionsgrenzwertB = value; } }

        private double expositionsgrenzwertC;
        public double ExpositionsgrenzwertC { get { return expositionsgrenzwertC; } set { expositionsgrenzwertC = value; } }

        private double expositionsgrenzwertD;
        public double ExpositionsgrenzwertD { get { return expositionsgrenzwertD; } set { expositionsgrenzwertD = value; } }
        private double empfangswinkel;
        public double Empfangswinkel { get { return empfangswinkel; } set { empfangswinkel = value; } }

        private double expositionsgrenzwertE;
        public double ExpositionsgrenzwertE { get { return expositionsgrenzwertE; } set { expositionsgrenzwertE = value; } }

        private double expositionsgrenzwertF;
        public double ExpositionsgrenzwertF { get { return expositionsgrenzwertF; } set { expositionsgrenzwertF = value; } }

        private double expositionsgrenzwertG;
        public double ExpositionsgrenzwertG { get { return expositionsgrenzwertG; } set { expositionsgrenzwertG = value; } }

        private double expositionsgrenzwertH;
        public double ExpositionsgrenzwertH { get { return expositionsgrenzwertH; } set { expositionsgrenzwertH = value; } }

        private double expositionsgrenzwertI;
        public double ExpositionsgrenzwertI { get { return expositionsgrenzwertI; } set { expositionsgrenzwertI = value; } }

        private double expositionsgrenzwertJ;
        public double ExpositionsgrenzwertJ { get { return expositionsgrenzwertJ; } set { expositionsgrenzwertJ = value; } }

        private double expositionsgrenzwertK;
        public double ExpositionsgrenzwertK { get { return expositionsgrenzwertK; } set { expositionsgrenzwertK = value; } }

        private double expositionsgrenzwertL;
        public double ExpositionsgrenzwertL { get { return expositionsgrenzwertL; } set { expositionsgrenzwertL = value; } }

        private double expositionsgrenzwertM;
        public double ExpositionsgrenzwertM { get { return expositionsgrenzwertM; } set { expositionsgrenzwertM = value; } }

        private double expositionsgrenzwertN;
        public double ExpositionsgrenzwertN { get { return expositionsgrenzwertN; } set { expositionsgrenzwertN = value; } }

        private double expositionsgrenzwertO;
        public double ExpositionsgrenzwertO{ get { return expositionsgrenzwertO; } set { expositionsgrenzwertO = value; } }



        private double expositionswertA;
        public double ExpositionswertA { get { return expositionswertA; } set { expositionswertA = value; } }


        private double expositionswertB;
        public double ExpositionswertB { get { return expositionswertB; } set { expositionswertB = value; } }

        private double expositionswertC;
        public double ExpositionswertC { get { return expositionswertC; } set { expositionswertC = value; } }

        private double expositionswertD;
        public double ExpositionswertD { get { return expositionswertD; } set { expositionswertD = value; } }

       

        private double expositionswertE;
        public double ExpositionswertE { get { return expositionswertE; } set { expositionswertE = value; } }

        private double expositionswertF;
        public double ExpositionswertF { get { return expositionswertF; } set { expositionswertF = value; } }

        private double expositionswertG;
        public double ExpositionswertG { get { return expositionswertG; } set { expositionswertG = value; } }

        private double expositionswertH;
        public double ExpositionswertH { get { return expositionswertH; } set { expositionswertH = value; } }

        private double expositionswertI;
        public double ExpositionswertI { get { return expositionswertI; } set { expositionswertI = value; } }

        private double expositionswertJ;
        public double ExpositionswertJ { get { return expositionswertJ; } set { expositionswertJ = value; } }

        private double expositionswertK;
        public double ExpositionswertK { get { return expositionswertK; } set { expositionswertK = value; } }

        private double expositionswertL;
        public double ExpositionswertL { get { return expositionswertL; } set { expositionswertL = value; } }

        private double expositionswertM;
        public double ExpositionswertM { get { return expositionswertM; } set { expositionswertM = value; } }

        private double expositionswertN;
        public double ExpositionswertN { get { return expositionswertN; } set { expositionswertN = value; } }

        private double expositionswertO;
        public double ExpositionswertO { get { return expositionswertO; } set { expositionswertO = value; } }




        private List<double> aktinischesUV;

        public List<double> AktinischesUV { get { return aktinischesUV; } set { aktinischesUV = value; } }

        private List<double> augeUVA;

        public List<double> AugeUVA { get { return augeUVA; } set { augeUVA = value; } }

        private List<double> blaulichtkleinequelle;

        public List<double> Blaulichtkleinequelle { get { return blaulichtkleinequelle; } set { blaulichtkleinequelle = value; } }

        private List<double> augeir;

        public List<double> Augeir { get { return augeir; } set { augeir = value; } }

        private List<double> hautthermisch;

        public List<double> Hautthermisch { get { return hautthermisch; } set { hautthermisch = value; } }

        private List<double> blaulicht;

        public List<double> Blaulicht { get { return blaulicht; } set { blaulicht = value; } }


        private List<double> netzhautthermisch;

        public List<double> Netzhautthermisch { get { return netzhautthermisch; } set { netzhautthermisch = value; } }

        private List<double> netzhautthermischschwacherreiz;

        public List<double> Netzhautthermischschwacherreiz { get { return netzhautthermischschwacherreiz; } set { netzhautthermischschwacherreiz = value; } }














        private bool flag;

        public bool Flag { get { return flag; } set { flag = value; } }

        Hotspot source = new Hotspot();

        Spektrum spektrumcnt = new Spektrum();


        private List<double> normiersp = new List<double>();
        public List<double> Normiersp
        {
            get { return normiersp; }
            set { normiersp = value; }
        }

        private double time;

        public double Time { get { return time; } set { time = value; } }


        private List<double> wellenlaenge = new List<double>();
        public List<double> Wellenlaenge
        {
            get { return wellenlaenge; }
            set { wellenlaenge = value; }
        }

        private List<double> empfangswinkel62471 = new List<double>() {0.0017,0.011,0.1 };

        public List <double> Empfangswinkel62471 { get { return empfangswinkel62471; } set { empfangswinkel62471 = value; } }


        private double raumwinkel;

        public double Raumwinkel { get { return raumwinkel; } set { raumwinkel = value; } }

        private double bestrahlungsstärke;

        public double Bestrahlungsstärke { get { return bestrahlungsstärke; } set { bestrahlungsstärke = value; } }

        private double aperaturdurchmesser;

        public double Aperaturdurchmesser { get { return aperaturdurchmesser; } set { aperaturdurchmesser = value; } }

        private double strahldichte;

        public double Strahldichte { get { return strahldichte; } set { strahldichte = value; } }

        private double bildabstand;

        public double Bildabstand { get { return bildabstand; } set { bildabstand = value; } }




        public void getblaulichtwirk()
                {
                    blaulichtgefahrwirkfkt = new List<double>();


                    Spektrum blaulicht = new Spektrum();
                    blaulicht.readTextFile(@"E:\Bachelorarbeit Versuch 1\Wirkfunktion_Blaulicht.txt");
                    for (int i = 0; i < blaulicht.Counts.Count; i++)
                    {
                        blaulichtgefahrwirkfkt.Add(blaulicht.Counts[i]);

                    }
                }
                public void getuvwirkfkt()
                {
                    Spektrum uvlicht = new Spektrum();

                    uvgefahrwirkfkt = new List<double>();

                    uvlicht.readTextFile(@"E:\Bachelorarbeit Versuch 1\Uvlichtspektrum.txt");

                    for (int i = 0; i < uvlicht.Counts.Count; i++)
                    {
                        uvgefahrwirkfkt.Add(uvlicht.Counts[i]);

                    }

                }


                public void getverbrennungsgefahrwirkfkt()
                {
                    Spektrum Verbrennung = new Spektrum();

                    verbrennungsgefahrwirkfkt = new List<double>();

                    Verbrennung.readTextFile(@"E:\Bachelorarbeit Versuch 1\Verbrennungsgefahrwirkfkt1.txt");

                    for (int i = 0; i < Verbrennung.Counts.Count; i++)
                    {
                        verbrennungsgefahrwirkfkt.Add(Verbrennung.Counts[i]);

                    }
                }

                   public void getspektrumcounts()
        {

         
            spektrumcounts = new List<double>();

            spektrumcnt.readTextFile(@"E:\Bachelorarbeit Versuch 1\Spektrum_1111.txt");
            spektrumcnt.flaechenormieren();
            for(int i = 0; i < spektrumcnt.Counts.Count; i++)
            {

                
                spektrumcounts.Add(spektrumcnt.Counts[i]);
                wellenlaenge.Add(spektrumcnt.Wellenlaenge[i]);
              
            }
                
        }


      

        

        public void beamgageöffnen()
        {
            source.Run();
        }


            public void testcoldpixel()
        {
            source.KaltePixelFinden();

        }

        public void testhotpixels()
        {
            source.HeißePixelFinden();
        }

        public void gefiltertefkt()
        {
            source.RichtigeFrameFunktionMitHundKPixeln();
        }

        public void readdata()
        {

            source.NewFrameFunction();
            source.picturemachen(1280, 1024);

            bitma = source.Bitmaaaaa;
            
        }


        public void testbitmap()
        {

            source.testbitmap();

        }



        public void gethotspot(double empfangswinkel,double bildabstand)
        {
            prozentualerAnteil = new List<double>() { 0, 0, 0, 0 };


            if (empfangswinkel == 0.0017)
            {
                source.getHotspot(0.0017, bildabstand, 0.00000369, 0.00000369, source.Bitmaaaaa.Height, source.Bitmaaaaa.Width, 0.1);
                prozentualerAnteil[0] = source.ProzentualerAnteil;
                bitma17 = source.Bitmaaaaa;

                prozentualerAnteil[3] = source.ProzentualerAnteil;

                source.getHotspot(0.011, bildabstand, 0.00000369, 0.00000369, source.Bitmaaaaa.Height, source.Bitmaaaaa.Width, 0.1);
                prozentualerAnteil[1] = source.ProzentualerAnteil;
                bitma11 = source.Bitmaaaaa;

                source.getHotspot(0.1, bildabstand, 0.00000369, 0.00000369, source.Bitmaaaaa.Height, source.Bitmaaaaa.Width, 0.1);
                prozentualerAnteil[2] = source.ProzentualerAnteil;
                bitma100 = source.Bitmaaaaa;
            }
            else if (empfangswinkel == 0.011)
            {
                source.getHotspot(0.011, bildabstand, 0.00000369, 0.00000369, source.Bitmaaaaa.Height, source.Bitmaaaaa.Width, 0.1);
                prozentualerAnteil[1] = source.ProzentualerAnteil;
                bitma11 = source.Bitmaaaaa;
                prozentualerAnteil[3] = source.ProzentualerAnteil;
                source.getHotspot(0.0017, bildabstand, 0.00000369, 0.00000369, source.Bitmaaaaa.Height, source.Bitmaaaaa.Width, 0.1);
                prozentualerAnteil[0] = source.ProzentualerAnteil;
                bitma17 = source.Bitmaaaaa;
                source.getHotspot(0.1, bildabstand, 0.00000369, 0.00000369, source.Bitmaaaaa.Height, source.Bitmaaaaa.Width, 0.1);
                prozentualerAnteil[2] = source.ProzentualerAnteil;
                bitma100 = source.Bitmaaaaa;

            }

            else
            {

                source.getHotspot(0.0017, bildabstand, 0.00000369, 0.00000369, source.Bitmaaaaa.Height, source.Bitmaaaaa.Width, 0.1);
                prozentualerAnteil[0] = source.ProzentualerAnteil;
                bitma17 = source.Bitmaaaaa;

                source.getHotspot(0.011, bildabstand, 0.00000369, 0.00000369, source.Bitmaaaaa.Height, source.Bitmaaaaa.Width, 0.1);
                prozentualerAnteil[1] = source.ProzentualerAnteil;
                bitma11 = source.Bitmaaaaa;

                source.getHotspot(0.1, bildabstand, 0.00000369, 0.00000369, source.Bitmaaaaa.Height, source.Bitmaaaaa.Width, 0.1);
                prozentualerAnteil[2] = source.ProzentualerAnteil;
                bitma100 = source.Bitmaaaaa;
                prozentualerAnteil[3] = source.ProzentualerAnteil;
            }

        }
              
           



            public void getAugeHautUVlichtgefahrTROS() {


            zwspeicherliste.Clear();

            aperaturdurchmesser = 1.4 * 0.2;


            aperaturradius = aperaturdurchmesser / 2;

            bestrahlungsstärke = gesamtleistung14rad / (Math.PI * (aperaturradius*aperaturradius));


            expositionsgrenzwertA = 30;
                                               
              expositionswertA = 0.0;

           for(int i = 0; i <= 221; i++)
            {
                zwspeicherliste.Add(bestrahlungsstärke * uvgefahrwirkfkt[i] * spektrumcounts[i]);

            }

          for(int i = 0; i < zwspeicherliste.Count; i++)
            {
                expositionswertA = expositionswertA + zwspeicherliste[i];

            }

            expositionswertA = expositionswertA * time;
           
            }


        public void getkataraktogeneseTROS() {

            expositionsgrenzwertB = 10000;
           
            for (int i = 0; i < wellenlaenge.Count; i++)
            {

                if (wellenlaenge[i] == 315) {
                    x = i;
                }
                else if (wellenlaenge[i] == 400) { y = i;

                }


            }
            expositionswertB = 0;
            zwspeicherliste.Clear();
            for (int i = x; i <= y; i++)
            {

                zwspeicherliste.Add(bestrahlungsstärke * spektrumcounts[i]);

            }

            for (int i = 0; i < zwspeicherliste.Count; i++)
            {
                expositionswertB = expositionswertB + zwspeicherliste[i];
            }

            expositionswertB = expositionswertB * time;


        }

        //Beginn Risikobewertung für c,d

        public void getblaulichtgefahrAugeTROS(double empfangswinkel)


        {

            expositionsgrenzwertC = Math.Pow(10,6) / time;
            expositionsgrenzwertD = 100;
            expositionsgrenzwertE = 100 / time;
            expositionsgrenzwertF = 0.01;

         
            if (time <= 10000 && empfangswinkel >= 11E-3)
            {

               
                zwspeicherliste.Clear();
                expositionswertC = 0;

                gewichteteLeistung = gesamtleistungKamera * prozentualerAnteil[3];
                aperaturdurchmesser = empfangswinkel * bildabstand;

                aperaturradius = aperaturdurchmesser / 2;

                bestrahlungsstärke = gewichteteLeistung / (Math.PI * (aperaturradius * aperaturradius));

                raumwinkel= (Math.PI * (aperaturradius * aperaturradius))/(bildabstand*bildabstand);

                strahldichte = bestrahlungsstärke / raumwinkel;


                expositionswertD = 0;
                for (int i = 0; i < wellenlaenge.Count; i++)
                {

                    if (wellenlaenge[i] == 300)
                    {
                        x = i;
                    }
                    else if (wellenlaenge[i] == 700)
                    {
                        y = i;
                    }
                }
                for (int i = x; i <= y; i++)
                {

                    zwspeicherliste.Add(strahldichte * blaulichtgefahrwirkfkt[i] * spektrumcounts[i]);
                }
                expositionswertC = 0;
                for (int i = 0; i < zwspeicherliste.Count; i++)
                {
                    expositionswertC = expositionswertC + zwspeicherliste[i];

                }





            }


            else if (time <= 10000 && empfangswinkel < 11E-3)
            {


                zwspeicherliste.Clear();


               

                gewichteteLeistung = gesamtleistungKamera *prozentualerAnteil[3];
                aperaturdurchmesser = empfangswinkel * bildabstand;

                aperaturradius = aperaturdurchmesser / 2;

                bestrahlungsstärke = gewichteteLeistung / (Math.PI * (aperaturradius * aperaturradius));

                raumwinkel = (Math.PI * (aperaturradius * aperaturradius)) / (bildabstand * bildabstand);

                strahldichte = bestrahlungsstärke / raumwinkel;


                expositionswertF = 0;
                for (int i = 0; i < wellenlaenge.Count; i++)
                {

                    if (wellenlaenge[i] == 300)
                    {
                        x = i;
                    }
                    else if (wellenlaenge[i] == 700)
                    {
                        y = i;
                    }
                }
                for (int i = x; i <= y; i++)
                {

                    zwspeicherliste.Add(bestrahlungsstärke * blaulichtgefahrwirkfkt[i] * spektrumcounts[i]);
                }
                expositionswertE = 0;
                for (int i = 0; i < zwspeicherliste.Count; i++)
                {
                    expositionswertE = expositionswertE + zwspeicherliste[i];

                }


            }










            else if (time > 10000 && empfangswinkel >= 11E-3)
            {
                expositionswertC = 0;


                gewichteteLeistung = gesamtleistungKamera * prozentualerAnteil[3];
                aperaturdurchmesser = empfangswinkel * bildabstand;

                aperaturradius = aperaturdurchmesser / 2;

                bestrahlungsstärke = gewichteteLeistung / (Math.PI * (aperaturradius * aperaturradius));

                raumwinkel = (Math.PI * (aperaturradius * aperaturradius)) / (bildabstand * bildabstand);

                strahldichte = bestrahlungsstärke / raumwinkel;

                zwspeicherliste.Clear();


                for (int i = 0; i < wellenlaenge.Count; i++)
                {

                    if (wellenlaenge[i] == 300)
                    {
                        x = i;
                    }
                    else if (wellenlaenge[i] == 700)
                    {
                        y = i;
                    }
                }
                for (int i = x; i <= y; i++)
                {

                    zwspeicherliste.Add(strahldichte * blaulichtgefahrwirkfkt[i] * spektrumcounts[i]);
                }
                expositionswertD = 0;
                for (int i = 0; i < zwspeicherliste.Count; i++)
                {
                    expositionswertD = expositionswertD + zwspeicherliste[i];

                }
               

            }

            else if (time > 10000 && empfangswinkel < 11E-3) { 



               
                zwspeicherliste.Clear();
                expositionswertE = 0;

                

                gewichteteLeistung = gesamtleistungKamera * prozentualerAnteil[3];
                aperaturdurchmesser = empfangswinkel * bildabstand;

                aperaturradius = aperaturdurchmesser / 2;

                bestrahlungsstärke = gewichteteLeistung / (Math.PI * (aperaturradius * aperaturradius));

                raumwinkel = (Math.PI * (aperaturradius * aperaturradius)) / (bildabstand * bildabstand);

                strahldichte = bestrahlungsstärke / raumwinkel;

                expositionswertF = 0;
                for (int i = 0; i < wellenlaenge.Count; i++)
                {

                    if (wellenlaenge[i] == 300)
                    {
                        x = i;
                    }
                    else if (wellenlaenge[i] == 700)
                    {
                        y = i;
                    }
                }
                for (int i = x; i <= y; i++)
                {

                    zwspeicherliste.Add(bestrahlungsstärke * blaulichtgefahrwirkfkt[i] * spektrumcounts[i]);
                }
                expositionswertF = 0;
                for (int i = 0; i < zwspeicherliste.Count; i++)
                {
                    expositionswertF = expositionswertF + zwspeicherliste[i];

                }
                
            }

        }


        public void getVerbrennungsgefahrTROS(double empfangswinkel)
        {

            expositionsgrenzwertG = 2.8 * Math.Pow(10,7) / empfangswinkel;
            expositionsgrenzwertH = 5 * Math.Pow(10, 7) / (empfangswinkel * Math.Pow(time,0.25));
            expositionsgrenzwertI = (8.89 * Math.Pow(10, 8)) / empfangswinkel;

          
            if (time > 10)
            {
                zwspeicherliste.Clear();
                expositionswertH = 0;
                expositionswertI = 0;

                gewichteteLeistung = gesamtleistungKamera * prozentualerAnteil[3];
                aperaturdurchmesser = empfangswinkel * bildabstand;

                aperaturradius = aperaturdurchmesser / 2;

                bestrahlungsstärke = gewichteteLeistung / (Math.PI * (aperaturradius * aperaturradius));

                raumwinkel = (Math.PI * (aperaturradius * aperaturradius)) / (bildabstand * bildabstand);

                strahldichte = bestrahlungsstärke / raumwinkel;



                expositionswertG = 0;
                for (int i = 0; i < wellenlaenge.Count; i++)
                {

                    if (wellenlaenge[i] == 380)
                    {
                        x = i;
                    }
                    else if (wellenlaenge[i] == 1400)
                    {
                        y = i;
                    }
                }
                for (int i = x; i <= y; i++)
                {

                    zwspeicherliste.Add(strahldichte *verbrennungsgefahrwirkfkt[i] * spektrumcounts[i]);
                }
                expositionswertG = 0;
                for (int i = 0; i < zwspeicherliste.Count; i++)
                {
                    expositionswertG = expositionswertG + zwspeicherliste[i];

                }
              
            }
            else if (10E-6<=time&&time<=10)
            {
                zwspeicherliste.Clear();
                expositionswertG = 0;
                expositionswertI = 0;

                gewichteteLeistung = gesamtleistungKamera * prozentualerAnteil[3];
                aperaturdurchmesser = empfangswinkel * bildabstand;

                aperaturradius = aperaturdurchmesser / 2;

                bestrahlungsstärke = gewichteteLeistung / (Math.PI * (aperaturradius * aperaturradius));

                raumwinkel = (Math.PI * (aperaturradius * aperaturradius)) / (bildabstand * bildabstand);

                strahldichte = bestrahlungsstärke / raumwinkel;



                expositionswertH = 0;
                for (int i = 0; i < wellenlaenge.Count; i++)
                {

                    if (wellenlaenge[i] == 380)
                    {
                        x = i;
                    }
                    else if (wellenlaenge[i] == 1400)
                    {
                        y = i;
                    }
                }
                for (int i = x; i <= y; i++)
                {

                    zwspeicherliste.Add(strahldichte * verbrennungsgefahrwirkfkt[i] * spektrumcounts[i]);
                }
                expositionswertH = 0;
                for (int i = 0; i < zwspeicherliste.Count; i++)
                {
                    expositionswertH = expositionswertH + zwspeicherliste[i];

                }
              
            }
            else if (time < 10E-6)
            {
                zwspeicherliste.Clear();
                expositionswertG = 0;
                expositionswertH = 0;

                gewichteteLeistung = gesamtleistungKamera * prozentualerAnteil[3];
                aperaturdurchmesser = empfangswinkel * bildabstand;

                aperaturradius = aperaturdurchmesser / 2;

                bestrahlungsstärke = gewichteteLeistung / (Math.PI * (aperaturradius * aperaturradius));

                raumwinkel = (Math.PI * (aperaturradius * aperaturradius)) / (bildabstand * bildabstand);

                strahldichte = bestrahlungsstärke / raumwinkel;



                expositionswertH = 0;
                for (int i = 0; i < wellenlaenge.Count; i++)
                {

                    if (wellenlaenge[i] == 380)
                    {
                        x = i;
                    }
                    else if (wellenlaenge[i] == 1400)
                    {
                        y = i;
                    }
                }
                for (int i = x; i <= y; i++)
                {

                    zwspeicherliste.Add(strahldichte * verbrennungsgefahrwirkfkt[i] * spektrumcounts[i]);
                }
                expositionswertI = 0;
                for (int i = 0; i < zwspeicherliste.Count; i++)
                {
                    expositionswertI = expositionswertI + zwspeicherliste[i];

                }
              


            }
        }

        public void getVerbrennungsgefahrschwachervisuellerreizTROS(double empfangswinkel)
        {



            if (empfangswinkel >= 0.011 && empfangswinkel <= 0.1) { 
            expositionsgrenzwertJ = (6 * Math.Pow(10, 6)) / empfangswinkel;
            expositionsgrenzwertK = (5 * Math.Pow(10, 7)) / (empfangswinkel * Math.Pow(time, 0.25));
            expositionsgrenzwertL = 8.89 * Math.Pow(10, 8) / empfangswinkel;
           }

            else if (empfangswinkel < 0.011)
            {
                expositionsgrenzwertJ = (6 * Math.Pow(10, 6)) / 0.011;
                expositionsgrenzwertK = (5 * Math.Pow(10, 7)) / (0.011 * Math.Pow(time, 0.25));
                expositionsgrenzwertL = 8.89 * Math.Pow(10, 8) / 0.011;


            }

            else
            {

                expositionsgrenzwertJ = (6 * Math.Pow(10, 6)) / 0.1;
                expositionsgrenzwertK = (5 * Math.Pow(10, 7)) / (0.1 * Math.Pow(time, 0.25));
                expositionsgrenzwertL = 8.89 * Math.Pow(10, 8) / 0.1;
            }

            if (time > 10)
            {
                zwspeicherliste.Clear();
                expositionswertK = 0;
                expositionswertL = 0;

                gewichteteLeistung = gesamtleistungKamera * prozentualerAnteil[3];
                aperaturdurchmesser = empfangswinkel * bildabstand;

                aperaturradius = aperaturdurchmesser / 2;

                bestrahlungsstärke = gewichteteLeistung / (Math.PI * (aperaturradius * aperaturradius));

                raumwinkel = (Math.PI * (aperaturradius * aperaturradius)) / (bildabstand * bildabstand);

                strahldichte = bestrahlungsstärke / raumwinkel;



                expositionswertJ = 0;
                for (int i = 0; i < wellenlaenge.Count; i++)
                {

                    if (wellenlaenge[i] == 780)
                    {
                        x = i;
                    }
                    else if (wellenlaenge[i] == 1400)
                    {
                        y = i;
                    }
                }
                for (int i = x; i <= y; i++)
                {

                    zwspeicherliste.Add(strahldichte * verbrennungsgefahrwirkfkt[i] * spektrumcounts[i]);
                }
                expositionswertJ = 0;
                for (int i = 0; i < zwspeicherliste.Count; i++)
                {
                    expositionswertJ = expositionswertJ + zwspeicherliste[i];

                }
                
            }
            else if (10E-6 <= time && time <= 10)
            {
                zwspeicherliste.Clear();
                expositionswertJ = 0;
                expositionswertL = 0;

                gewichteteLeistung = gesamtleistungKamera * prozentualerAnteil[3];
                aperaturdurchmesser = empfangswinkel * bildabstand;

                aperaturradius = aperaturdurchmesser / 2;

                bestrahlungsstärke = gewichteteLeistung / (Math.PI * (aperaturradius * aperaturradius));

                raumwinkel = (Math.PI * (aperaturradius * aperaturradius)) / (bildabstand * bildabstand);

                strahldichte = bestrahlungsstärke / raumwinkel;



                expositionswertK = 0;
                for (int i = 0; i < wellenlaenge.Count; i++)
                {

                    if (wellenlaenge[i] == 780)
                    {
                        x = i;
                    }
                    else if (wellenlaenge[i] == 1400)
                    {
                        y = i;
                    }
                }
                for (int i = x; i <= y; i++)
                {

                    zwspeicherliste.Add(strahldichte * verbrennungsgefahrwirkfkt[i] * spektrumcounts[i]);
                }
                expositionswertK = 0;
                for (int i = 0; i < zwspeicherliste.Count; i++)
                {
                    expositionswertK = expositionswertK + zwspeicherliste[i];

                }
               
            }
            else if (time < 10E-6)
            {
                zwspeicherliste.Clear();
                expositionswertJ = 0;
                expositionswertK = 0;

                gewichteteLeistung = gesamtleistungKamera * prozentualerAnteil[3];
                aperaturdurchmesser = empfangswinkel * bildabstand;

                aperaturradius = aperaturdurchmesser / 2;

                bestrahlungsstärke = gewichteteLeistung / (Math.PI * (aperaturradius * aperaturradius));

                raumwinkel = (Math.PI * (aperaturradius * aperaturradius)) / (bildabstand * bildabstand);

                strahldichte = bestrahlungsstärke / raumwinkel;



                expositionswertL = 0;
                for (int i = 0; i < wellenlaenge.Count; i++)
                {

                    if (wellenlaenge[i] == 780)
                    {
                        x = i;
                    }
                    else if (wellenlaenge[i] == 1400)
                    {
                        y = i;
                    }
                }
                for (int i = x; i <= y; i++)
                {

                    zwspeicherliste.Add(strahldichte * verbrennungsgefahrwirkfkt[i] * spektrumcounts[i]);
                }
                expositionswertL = 0;
                for (int i = 0; i < zwspeicherliste.Count; i++)
                {
                    expositionswertL = expositionswertL + zwspeicherliste[i];

                }
                
            }
        }
        public void getHornhautverbrennungundkataraktogeneseTROS()
        {

            expositionsgrenzwertM = 18000 * Math.Pow(time, -0.75);
            expositionsgrenzwertN = 3 * Math.Pow(10, 6);


           

            if (time <= 1000)
            {

                zwspeicherliste.Clear();

                expositionswertN = 0;

                aperaturdurchmesser = 1.4 * 0.2;


                aperaturradius = aperaturdurchmesser / 2;

                bestrahlungsstärke = gesamtleistung14rad / (Math.PI * (aperaturradius * aperaturradius));



                expositionswertM = 0;
                for (int i = 0; i < wellenlaenge.Count; i++)
                {

                    if (wellenlaenge[i] == 780)
                    {
                        x = i;
                    }
                    else if (wellenlaenge[i] == 1400)
                    {
                        y = i;
                    }
                }
                for (int i = x; i <= y; i++)
                {

                    zwspeicherliste.Add(bestrahlungsstärke * spektrumcounts[i]);
                }
                expositionswertM = 0;
                for (int i = 0; i < zwspeicherliste.Count; i++)
                {
                    expositionswertM = expositionswertM + zwspeicherliste[i];

                }
               

            }
            else if (time <= 1000)
            {

                zwspeicherliste.Clear();

                expositionswertM = 0;

                aperaturdurchmesser = 1.4 * 0.2;


                aperaturradius = aperaturdurchmesser / 2;

                bestrahlungsstärke = gesamtleistung14rad / (Math.PI * (aperaturradius * aperaturradius));



                expositionswertN = 0;
                for (int i = 0; i < wellenlaenge.Count; i++)
                {

                    if (wellenlaenge[i] == 780)
                    {
                        x = i;
                    }
                    else if (wellenlaenge[i] == 1400)
                    {
                        y = i;
                    }
                }
                for (int i = x; i <= y; i++)
                {

                    zwspeicherliste.Add(bestrahlungsstärke * spektrumcounts[i]);
                }
                expositionswertN = 0;
                for (int i = 0; i < zwspeicherliste.Count; i++)
                {
                    expositionswertN = expositionswertN + zwspeicherliste[i];

                }
               
            }

        }

        public void gethautverbrennungTROS()
        {
            if (time < 10)
            {
                expositionsgrenzwertO = 20000 /( Math.Pow(time, 0.75));
                zwspeicherliste.Clear();



                aperaturdurchmesser = 1.4 * 0.2;


                aperaturradius = aperaturdurchmesser / 2;

                bestrahlungsstärke = gesamtleistung14rad / (Math.PI * (aperaturradius * aperaturradius));




                for (int i = 0; i < wellenlaenge.Count; i++)
                {

                    if (wellenlaenge[i] == 380)
                    {
                        x = i;
                    }
                    else if (wellenlaenge[i] == 1400)
                    {
                        y = i;
                    }
                }
                for (int i = x; i <= y; i++)
                {

                    zwspeicherliste.Add(bestrahlungsstärke * spektrumcounts[i]);
                }
                expositionswertO = 0;
                for (int i = 0; i < zwspeicherliste.Count; i++)
                {
                    expositionswertO = expositionswertO + zwspeicherliste[i];

                }
               

            }

            else if (time >10)
            {

                expositionsgrenzwertO = 7700 * Math.Pow(time, -0.34);


                zwspeicherliste.Clear();



                aperaturdurchmesser = 1.4 * 0.2;


                aperaturradius = aperaturdurchmesser / 2;

                bestrahlungsstärke = gesamtleistung14rad / (Math.PI * (aperaturradius * aperaturradius));



                for (int i = 0; i < wellenlaenge.Count; i++)
                {

                    if (wellenlaenge[i] == 380)
                    {
                        x = i;
                    }
                    else if (wellenlaenge[i] == 1400)
                    {
                        y = i;
                    }
                }
                for (int i = x; i <= y; i++)
                {

                    zwspeicherliste.Add(bestrahlungsstärke * spektrumcounts[i]);
                }
                expositionswertM = 0;
                for (int i = 0; i < zwspeicherliste.Count; i++)
                {
                    expositionswertO = expositionswertO + zwspeicherliste[i];

                }
               

            }


        }

        public void getaktinischesUVHautAuge()
        {
            aktinischesUV = new List<double>() { 0, 0, 0 };
            for (int j = 0; j < empfangswinkel62471.Count; j++)
            {
                zwspeicherliste.Clear();

                aperaturdurchmesser = 1.4 * 0.2;


                aperaturradius = aperaturdurchmesser / 2;

                bestrahlungsstärke = gesamtleistung14rad / (Math.PI * (aperaturradius * aperaturradius));




                for (int i = 0; i < wellenlaenge.Count; i++)
                {

                    if (wellenlaenge[i] == 200)
                    {
                        x = i;
                    }
                    else if (wellenlaenge[i] == 400)
                    {
                        y = i;
                    }
                }
                for (int i = x; i <= y; i++)
                {

                    zwspeicherliste.Add(bestrahlungsstärke * spektrumcounts[i]*uvgefahrwirkfkt[i]);
                }
               
                for (int i = 0; i < zwspeicherliste.Count; i++)
                {
                    aktinischesUV[j] = aktinischesUV[j] + zwspeicherliste[i];

                }
            }

        }

        public void getAugeUVA()
        {
            augeUVA = new List<double>() { 0, 0, 0 };
            for (int j = 0; j < empfangswinkel62471.Count; j++)
            {
                zwspeicherliste.Clear();


                aperaturdurchmesser = 1.4 * 0.2;


                aperaturradius = aperaturdurchmesser / 2;

                bestrahlungsstärke = gesamtleistung14rad / (Math.PI * (aperaturradius * aperaturradius));




                for (int i = 0; i < wellenlaenge.Count; i++)
            {

                if (wellenlaenge[i] == 315)
                {
                    x = i;
                }
                else if (wellenlaenge[i] == 400)
                {
                    y = i;
                }
            }
            for (int i = x; i <= y; i++)
            {

                zwspeicherliste.Add(bestrahlungsstärke * spektrumcounts[i]);
            }

            for (int i = 0; i < zwspeicherliste.Count; i++)
            {
                augeUVA[j] = augeUVA[j] + zwspeicherliste[i];

            }
        }
    }


        public void getBlaulicht()
        {

            blaulicht= new List<double>() { 0, 0, 0 };
            for (int j = 0; j < empfangswinkel62471.Count; j++)
            {
                zwspeicherliste.Clear();
                gewichteteLeistung = gesamtleistungKamera * prozentualerAnteil[j];
                aperaturdurchmesser = empfangswinkel62471[j] * bildabstand;

                aperaturradius = aperaturdurchmesser / 2;

                bestrahlungsstärke = gewichteteLeistung / (Math.PI * (aperaturradius * aperaturradius));

                raumwinkel = (Math.PI * (aperaturradius * aperaturradius)) / (bildabstand * bildabstand);

                strahldichte = bestrahlungsstärke / raumwinkel;

                for (int i = 0; i < wellenlaenge.Count; i++)
                {

                    if (wellenlaenge[i] == 300)
                    {
                        x = i;
                    }
                    else if (wellenlaenge[i] == 700)
                    {
                        y = i;
                    }
                }
                for (int i = x; i <= y; i++)
                {

                    zwspeicherliste.Add(strahldichte * spektrumcounts[i]*blaulichtgefahrwirkfkt[i]);
                }

                for (int i = 0; i < zwspeicherliste.Count; i++)
                {
                    blaulicht[j] = blaulicht[j] + zwspeicherliste[i];

                }
            }
        }

        /*public void getBlaulichtKleineQuellen()
        {
            blaulichtkleinequelle = new List<double>() { 0, 0, 0 };
            for (int j = 0; j < empfangswinkel62471.Count; j++)
            {
                zwspeicherliste.Clear();
                gewichteteLeistung =gesamtleistungKamera * source.ProzentualerAnteil;
                aperaturdurchmesser = empfangswinkel62471[j] * bildabstand;

                aperaturradius = aperaturdurchmesser / 2;

                bestrahlungsstärke = gewichteteLeistung / (Math.PI * (aperaturradius * aperaturradius));


                for (int i = 0; i < wellenlaenge.Count; i++)
                {

                    if (wellenlaenge[i] == 300)
                    {
                        x = i;
                    }
                    else if (wellenlaenge[i] == 700)
                    {
                        y = i;
                    }
                }
                for (int i = x; i <= y; i++)
                {

                    zwspeicherliste.Add(bestrahlungsstärke * spektrumcounts[i] * blaulichtgefahrwirkfkt[i]);
                }

                for (int i = 0; i < zwspeicherliste.Count; i++)
                {
                    blaulichtkleinequelle[j] = blaulichtkleinequelle[j] + zwspeicherliste[i];

                }
            }



        }

        */
        public void getNetzhautthermisch()
        {

            netzhautthermisch = new List<double>() { 0, 0, 0 };
            for (int j = 0; j < empfangswinkel62471.Count; j++)
            {
                zwspeicherliste.Clear();
                gewichteteLeistung = gesamtleistungKamera * prozentualerAnteil[j];
                aperaturdurchmesser = empfangswinkel62471[j] * bildabstand;

                aperaturradius = aperaturdurchmesser / 2;

                bestrahlungsstärke = gewichteteLeistung / (Math.PI * (aperaturradius * aperaturradius));
                raumwinkel = (Math.PI * (aperaturradius * aperaturradius)) / (bildabstand * bildabstand);

                strahldichte = bestrahlungsstärke / raumwinkel;

                for (int i = 0; i < wellenlaenge.Count; i++)
                {

                    if (wellenlaenge[i] == 380)
                    {
                        x = i;
                    }
                    else if (wellenlaenge[i] == 1400)
                    {
                        y = i;
                    }
                }
                for (int i = x; i <= y; i++)
                {

                    zwspeicherliste.Add(strahldichte * spektrumcounts[i] * verbrennungsgefahrwirkfkt[i]);
                }

                for (int i = 0; i < zwspeicherliste.Count; i++)
                {
                    netzhautthermisch[j] = netzhautthermisch[j] + zwspeicherliste[i];

                }
            }
        }


        public void getNetzhautthermischschwacherreiz()
        {
            netzhautthermischschwacherreiz = new List<double>() { 0, 0, 0 };
            for (int j = 0; j < empfangswinkel62471.Count; j++)
            {
                zwspeicherliste.Clear();
                gewichteteLeistung = gesamtleistungKamera * prozentualerAnteil[j];
                aperaturdurchmesser = empfangswinkel62471[j] * bildabstand;

                aperaturradius = aperaturdurchmesser / 2;

                bestrahlungsstärke = gewichteteLeistung / (Math.PI * (aperaturradius * aperaturradius));
                raumwinkel = (Math.PI * (aperaturradius * aperaturradius)) / (bildabstand * bildabstand);

                strahldichte = bestrahlungsstärke / raumwinkel;

                for (int i = 0; i < wellenlaenge.Count; i++)
                {

                    if (wellenlaenge[i] == 780)
                    {
                        x = i;
                    }
                    else if (wellenlaenge[i] == 1400)
                    {
                        y = i;
                    }
                }
                for (int i = x; i <= y; i++)
                {

                    zwspeicherliste.Add(strahldichte * spektrumcounts[i] * verbrennungsgefahrwirkfkt[i]);
                }

                for (int i = 0; i < zwspeicherliste.Count; i++)
                {
                    netzhautthermischschwacherreiz[j] = netzhautthermischschwacherreiz[j] + zwspeicherliste[i];

                }
            }

        }


        public void getIRSTRahlung()
        {


            augeir = new List<double>() { 0, 0, 0 };
            for (int j = 0; j < empfangswinkel62471.Count; j++)
            {
                zwspeicherliste.Clear();


                aperaturdurchmesser = 1.4 * 0.2;


                aperaturradius = aperaturdurchmesser / 2;

                bestrahlungsstärke = gesamtleistung14rad / (Math.PI * (aperaturradius * aperaturradius));




                for (int i = 0; i < wellenlaenge.Count; i++)
                {

                    if (wellenlaenge[i] == 780)
                    {
                        x = i;
                    }
                    else if (wellenlaenge[i] == 1400)
                    {
                        y = i;
                    }
                }
                for (int i = x; i <= y; i++)
                {

                    zwspeicherliste.Add(bestrahlungsstärke * spektrumcounts[i]);
                }

                for (int i = 0; i < zwspeicherliste.Count; i++)
                {
                    augeir[j] = augeir[j] + zwspeicherliste[i];

                }
            }


        }



        public void getRisikostufe()
        {

            double Expositionswert = 0;

            double Expositionswert0 = 0;
            double Expositionswert1 = 0;
            double Expositionswert2 = 0;


            Expositionswert = aktinischesUV[0];

            switch (Expositionswert)
            {
                case double i when i<=0.001:
                    risikostufeaktinischesUV = "Risikofrei";
                    break;

                case double i when i <= 0.003&&i>0.001:
                    risikostufeaktinischesUV = "Gerninges Risiko";
                        break;
                case double i when i <= 0.03&&i>0.003:
                    risikostufeaktinischesUV = "Mittleres Risiko";
                    break;
                default:
                    risikostufeaktinischesUV = "Hohes Risiko";
                    break;
            }

            Expositionswert = AugeUVA[0];

            switch (Expositionswert)
            {
                case double i when i <= 10:
                    risikostufeaktinischesUV = "Risikofrei";
                    break;

                case double i when i <= 33 && i > 10:
                    risikostufeaktinischesUV = "Gerninges Risiko";
                    break;
                case double i when i <= 100 && i > 33:
                    risikostufeaktinischesUV = "Mittleres Risiko";
                    break;
                default:
                    risikostufeaktinischesUV = "Hohes Risiko";
                    break;
            }


            Expositionswert = blaulichtkleinequelle[0];

            switch (Expositionswert)
            {
                /*case double i when i <= 1:
                    risikostufeaktinischesUV = "Risikofrei";
                    break;*/

                case double i when i <= 1:
                    risikostufeaktinischesUV = "Gerninges Risiko";
                    break;
                case double i when i <= 400 && i > 1:
                    risikostufeaktinischesUV = "Mittleres Risiko";
                    break;
                default:
                    risikostufeaktinischesUV = "Hohes Risiko";
                    break;
            }


            Expositionswert = augeir[0];

            switch (Expositionswert)
            {
                case double i when i <= 100:
                    risikostufeaktinischesUV = "Risikofrei";
                    break;

                case double i when i <= 570 && i >100:
                    risikostufeaktinischesUV = "Gerninges Risiko";
                    break;
                case double i when i <= 3200 && i > 570:
                    risikostufeaktinischesUV = "Mittleres Risiko";
                    break;
                default:
                    risikostufeaktinischesUV = "Hohes Risiko";
                    break;
            }

            Expositionswert0 = blaulicht[0];
            Expositionswert1 = blaulicht[1];
            Expositionswert2 = blaulicht[2];

            if (Expositionswert2<=100)
            {
                risikostufeBlaulicht = "Risikofrei";
            }
            else if (Expositionswert1<=10000)
            {
                risikostufeBlaulicht = "Gerninges Risiko";
            }
            else if (Expositionswert0<=4000000)
            {
                risikostufeBlaulicht = "Mittleres Risiko";
            }
            else
            {
                risikostufeBlaulicht = "Hohes Risiko";
            }

            Expositionswert0 = netzhautthermisch[0];
            Expositionswert1 = netzhautthermisch[1];
            Expositionswert2 = netzhautthermisch[2];

            if (Expositionswert1 <= 2545454)
            {
                risikostufeNetzhauthermisch = "Geringes Risiko";

            }
            else if (Expositionswert0> 2545454 && Expositionswert0<41764705)
            {
                risikostufeNetzhauthermisch = "Mittleres Risiko";
            }
            else {

                risikostufeNetzhauthermisch = "Hohes Risiko";

            }


            Expositionswert0 = netzhautthermischschwacherreiz[0];
            Expositionswert1 = netzhautthermischschwacherreiz[1];
            Expositionswert2 = netzhautthermischschwacherreiz[2];

            if (Expositionswert1>545455)
            {
                risikostufeNetzhauthermischschwachereiz = "Hohes Risiko";
            }
            else
            {
                risikostufeNetzhauthermischschwachereiz = "Mittleres Risiko";
            }








        }























    }





        




        }







            
        

    


    
