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
        private double gesamtleistung;
        public double Gesamtleistung { get { return gesamtleistung; } set { gesamtleistung = value; } }

        private double gewichteteLeistung;
        public double GewichteteLeistung { get { return gewichteteLeistung; } set { gewichteteLeistung = value; } }



                private List<double> blaulichtgefahrwirkfkt;
                public List<double> Blaulichtgefahrwirkfkt
                {
                    get { return blaulichtgefahrwirkfkt; }
                    set { blaulichtgefahrwirkfkt = value; }
                }
        private List<double> zwspeicherliste;
        public List<double> Zwspeicherliste
        {
            get { return zwspeicherliste; }
            set { zwspeicherliste = value; }
        }


        private Bitmap bitma;
       public Bitmap Bitma { set { bitma = value; } get { return bitma; } } 





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


        private double expositionsgrenzwertB;
        public double ExpositionsgrenzwertB { get { return expositionsgrenzwertB; } set { expositionsgrenzwertB = value; } }

        private double expositionsgrenzwertC;
        public double ExpositionsgrenzwertC { get { return expositionsgrenzwertC; } set { expositionsgrenzwertC = value; } }

        private double expositionsgrenzwertD;
        public double ExpositionsgrenzwertD { get { return expositionsgrenzwertD; } set { expositionsgrenzwertD = value; } }

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

        private bool flag;

        public bool Flag { get { return flag; } set { flag = value; } }

        Hotspot source = new Beamgage_Fertigg.Hotspot();

        Spektrum spektrumcnt = new Spektrum();


        private List<double> normiersp = new List<double>();
        public List<double> Normiersp
        {
            get { return normiersp; }
            set { normiersp = value; }
        }

        
        

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

                    Verbrennung.readTextFile(@"E:\Bachelorarbeit Versuch 1\Verbrennungsgefahrwirkfkt.txt");

                    for (int i = 0; i < Verbrennung.Counts.Count; i++)
                    {
                        verbrennungsgefahrwirkfkt.Add(Verbrennung.Counts[i]);

                    }
                }

                   public void getspektrumcounts()
        {

         
            spektrumcounts = new List<double>();

            spektrumcnt.readTextFile(@"E:\Bachelorarbeit Versuch 1\Spektrum_1.txt");

            for(int i = 0; i < spektrumcnt.Counts.Count; i++)
            {

                
                spektrumcounts.Add(spektrumcnt.Counts[i]);
              
            }
                
        }


        public void spektrumnomrieren()
        {
            normiersp = new List<double>();

            for(int i = 0; i< spektrumcounts.Count; i++)
            {
                normiersp.Add(spektrumcounts[i]);

            }

            spektrumcounts.Clear();



            spektrumcnt.normierung(Normiersp, spektrumcounts, flag);
            

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
            source.picturemachen(source.Bitmaaaaa.Width, source.Bitmaaaaa.Height);

        }


        public void testbitmap()
        {

            source.testbitmap();

        }




                public void getGefährdungsstufe()
                {
            source.getHotspot(1.7E-3, 0.2, 0.00000369, 0.00000369, source.Bitmaaaaa.Width, source.Bitmaaaaa.Height, 0.1);
            zwspeicherliste = new List<double>();

            bitma = source.Bitmaaaaa;

            gewichteteLeistung = gesamtleistung * source.ProzentualerAnteil;

            expositionsgrenzwertA = 0.0;

           for(int i = 0; i <= 221; i++)
            {
                zwspeicherliste.Add(gewichteteLeistung * uvgefahrwirkfkt[i] * spektrumcounts[i]);

            }

          for(int i = 0; i < zwspeicherliste.Count; i++)
            {
                expositionsgrenzwertA = expositionsgrenzwertA + zwspeicherliste[i];

            }
            




                }







            }
        }

    


    
