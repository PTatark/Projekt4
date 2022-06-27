using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Projekt4
{
    internal class KlasyBryłGeomerycznych
    {
        const float KatProsty = 90.0F;
        //deklaracje klasy abstrakcyjnej
        public abstract class BrylaAbstrakcyjna
        {
            public enum TypyBryl
            {BG_Walec, BG_Stożek, BG_Kula, BG_Ostrosłup, BG_Graniastosłup, BG_Sześcian, BG_StozekPochylony, BG_StozekPochylonyZłożony, BG_WalecPochylony};
            protected int XsP, YsP;
            protected int WysokoscBryly;
            protected float KatPochylenia;
            protected Color Kolor_Linii;
            protected DashStyle Styl_Linii;
            protected float Grubosc_Linii;
            public TypyBryl RodzajBryly;
            protected bool KierunekObrotu; //false w prawo, true w lewo
            public bool Widoczny;
            protected float PowierzchniaBryly;
            protected float ObjetoscBryly;
            public BrylaAbstrakcyjna (Color KolorLinii, DashStyle StylLinii, float GruboscLinii)
            {
                this.Kolor_Linii = KolorLinii;
                Styl_Linii = StylLinii;
                Grubosc_Linii = GruboscLinii;
                KatPochylenia = KatProsty;
            }
            //deklaracja metod abstrakcyjnych dla których nie jesteśmy w stanie zapisać ich implementacji
            public abstract void Wykresl(Graphics Rysownica);
            public abstract void Wymaz(Control Kontrolka, Graphics Rysownica);
            public abstract void ObrociWykresl(Control Kontrolka, Graphics Rysownica, float KatObrotu);
            public abstract void PrzesunDoNowegoXY(Control Kontrolka, Graphics Rysownica, int X, int Y);
            //metody publiczne
            public void UstalAtrybutyGraficzne(Color KolorLinii, DashStyle StylLinii, int GruboscLinii)
            {
                Kolor_Linii = KolorLinii;
                Styl_Linii = StylLinii;
                Grubosc_Linii = GruboscLinii;
            }
        }
        public class BrylyObrotowe: BrylaAbstrakcyjna
        {
            protected int PromienBryly;
            public BrylyObrotowe (int R, Color KolorLinii, DashStyle StylLinii, float GruboscLinii): base(KolorLinii, StylLinii, GruboscLinii)
            {
                PromienBryly = R;
            }
            public override void Wykresl(Graphics Rysownica)
            {

            }
            public override void Wymaz(Control Kontrolka, Graphics Rysownica)
            {

            }
            public override void ObrociWykresl(Control Kontrolka, Graphics Rysownica, float KatObrotu)
            {

            }
            public override void PrzesunDoNowegoXY(Control Kontrolka, Graphics Rysownica, int X, int Y)
            {

            }
        }
        public class Walec : BrylyObrotowe
        {
            protected Point[] WielokatPodlogi;
            protected Point[] WielokatSufitu;
            int XsS, YsS;
            int StopienWielokataPodstawy;
            float OsDuza, OsMala;
            float KatMiedzyWierzcholkami;
            float KatPolozenia;
            public Walec(int R, int WysokoscWalca, int StopienWielokataPodstawy, int XsP, int YsP, Color KolorLinii, DashStyle StylLinii, float GruboscLinii):
                base(R, KolorLinii, StylLinii, GruboscLinii)
            {
                RodzajBryly = TypyBryl.BG_Walec;
                Widoczny = false;
                KierunekObrotu = false;
                WysokoscBryly = WysokoscWalca;
                this.StopienWielokataPodstawy = StopienWielokataPodstawy;
                this.XsP = XsP;
                this.YsP = YsP;
                OsDuza = 2 * PromienBryly;
                OsMala = PromienBryly / 2;
                XsS = XsP;
                YsS = YsP - WysokoscWalca;
                KatMiedzyWierzcholkami = 360 / StopienWielokataPodstawy;
                KatPolozenia = 0F;
                WielokatPodlogi = new Point[StopienWielokataPodstawy + 1];
                WielokatSufitu = new Point[StopienWielokataPodstawy + 1];
                for (int i = 0; i <= StopienWielokataPodstawy; i++)
                {
                    WielokatPodlogi[i] = new Point();
                    WielokatSufitu[i] = new Point();
                    WielokatPodlogi[i].X = (int)(XsP + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWierzcholkami) / 180F));
                    WielokatPodlogi[i].Y = (int)(YsP + OsMala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWierzcholkami) / 180F));

                    WielokatSufitu[i].X = (int)(XsS + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWierzcholkami) / 180F));
                    WielokatSufitu[i].Y = (int)(YsS + OsMala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWierzcholkami) / 180F));
                }
            }
            public override void Wykresl(Graphics Rysownica)
            {
                using (Pen Pioro = new Pen(Kolor_Linii, Grubosc_Linii))
                {
                    Pioro.DashStyle = Styl_Linii;
                    Rysownica.DrawEllipse(Pioro, XsP - OsDuza / 2, YsP - OsMala / 2, OsDuza, OsMala);
                    Rysownica.DrawEllipse(Pioro, XsS - OsDuza / 2, YsS - OsMala / 2, OsDuza, OsMala);
                    using (Pen PioroPrazkow = new Pen(Pioro.Color, 0.5F))
                    {
                        PioroPrazkow.DashStyle = DashStyle.Dot;
                        for (int i = 0; i < StopienWielokataPodstawy; i++)
                            Rysownica.DrawLine(PioroPrazkow, WielokatPodlogi[i], WielokatSufitu[i]);
                    }

                    Rysownica.DrawLine(Pioro, XsP - OsDuza / 2, YsP, XsS - OsDuza / 2, YsS);
                    Rysownica.DrawLine(Pioro, XsP + OsDuza / 2, YsP, XsS + OsDuza / 2, YsS);
                }
            }
            public override void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                using (Pen Pioro = new Pen(Kontrolka.BackColor, Grubosc_Linii))
                {
                    Pioro.DashStyle = Styl_Linii;
                    Rysownica.DrawEllipse(Pioro, XsP - OsDuza / 2, YsP - OsMala / 2, OsDuza, OsMala);
                    Rysownica.DrawEllipse(Pioro, XsS - OsDuza / 2, YsS - OsMala / 2, OsDuza, OsMala);
                    using (Pen PioroPrazkow = new Pen(Pioro.Color, 0.5F))
                    {
                        PioroPrazkow.DashStyle = DashStyle.Dot;
                        for (int i = 0; i < StopienWielokataPodstawy; i++)
                            Rysownica.DrawLine(PioroPrazkow, WielokatPodlogi[i], WielokatSufitu[i]);
                    }

                    Rysownica.DrawLine(Pioro, XsP - OsDuza / 2, YsP, XsS - OsDuza / 2, YsS);
                    Rysownica.DrawLine(Pioro, XsP + OsDuza / 2, YsP, XsS + OsDuza / 2, YsS);
                }
            }
            public override void ObrociWykresl(Control Kontrolka, Graphics Rysownica, float KatObrotu)
            {
                Wymaz(Kontrolka, Rysownica);
                if (KierunekObrotu)
                    KatPolozenia -= KatObrotu;
                else
                    KatPolozenia += KatObrotu;
                for (int i = 0; i < StopienWielokataPodstawy; i++)
                {
                    WielokatPodlogi[i].X = (int)(XsP + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWierzcholkami) / 180F));
                    WielokatPodlogi[i].Y = (int)(YsP + OsMala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWierzcholkami) / 180F));

                    WielokatSufitu[i].X = (int)(XsS + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWierzcholkami) / 180F));
                    WielokatSufitu[i].Y = (int)(YsS + OsMala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWierzcholkami) / 180F));
                }
                Wykresl(Rysownica);
            }
            public override void PrzesunDoNowegoXY(Control Kontrolka, Graphics Rysownica, int X, int Y)
            {
                int dX, dY;
                Wymaz(Kontrolka, Rysownica);
                dX = XsP < X ? X - XsP : -(XsP - X);
                dY = YsP < Y ? Y - YsP : -(YsP - Y);
                XsP = XsP + dX;
                YsP = YsP + dY;
                XsS = XsS + dX;
                YsS = YsS + dY;
                for (int i = 0; i < StopienWielokataPodstawy; i++)
                {
                    WielokatPodlogi[i].X = (int)(XsP + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWierzcholkami) / 180F));
                    WielokatPodlogi[i].Y = (int)(YsP + OsMala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWierzcholkami) / 180F));

                    WielokatSufitu[i].X = (int)(XsS + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWierzcholkami) / 180F));
                    WielokatSufitu[i].Y = (int)(YsS + OsMala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWierzcholkami) / 180F));
                }
                Wykresl(Rysownica);
            }
        }
        public class Stozek: BrylyObrotowe
        {
            protected int XsS, YsS;
            protected int StopienWielokataPodstawy;
            protected float OsDuza, OsMala;
            protected float KatMiedzyWierzcholkami;
            protected float KatPolozenia;
            protected Point[] WielokatPodlogi;
            public Stozek(int R, int WysokoscStozka, int StopienWielokataPodstawy, int XsP, int YsP, Color KolorLinii, DashStyle StylLinii, float GruboscLinii):
                base(R, KolorLinii, StylLinii, GruboscLinii)
            {
                RodzajBryly = TypyBryl.BG_Stożek;
                Widoczny = false;
                KierunekObrotu = false;
                WysokoscBryly = WysokoscStozka;
                this.StopienWielokataPodstawy = StopienWielokataPodstawy;
                OsDuza = 2 * PromienBryly;
                OsMala = PromienBryly / 2;
                this.XsP = XsP;
                this.YsP = YsP;
                XsS = XsP;
                YsS = YsP - WysokoscStozka;
                KatPolozenia = 0F;
                KatMiedzyWierzcholkami = 360 / this.StopienWielokataPodstawy;
                WielokatPodlogi = new Point[this.StopienWielokataPodstawy];
                for (int i = 0; i < this.StopienWielokataPodstawy; i++)
                {
                    WielokatPodlogi[i] = new Point();
                    // Wyznaczenie wartosci wspolrzednych i-tego wierzcholka wielokata z rownania parametrycznego elipsy: Xi = XsP + OsDuza /2 * Cos(Fi) Yi = YsP = OŚ_mala * Sin(fi
                    WielokatPodlogi[i].X = (int)(base.XsP + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWierzcholkami) / 180));
                    WielokatPodlogi[i].Y = (int)(base.YsP + OsMala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWierzcholkami) / 180));
                }
            }
            public override void Wykresl(Graphics Rysownica)
            {
                using (Pen Pioro = new Pen(Kolor_Linii, Grubosc_Linii))
                {
                    Pioro.DashStyle = Styl_Linii;
                    Rysownica.DrawEllipse(Pioro, XsP - OsDuza / 2, YsP - OsMala / 2, OsDuza, OsMala);
                    using (Pen PioroPrążków = new Pen(Pioro.Color, Pioro.Width / 3))
                    {
                        for (int i = 0; i < StopienWielokataPodstawy; i++)
                        {
                            Rysownica.DrawLine(PioroPrążków, WielokatPodlogi[i], new Point(XsS, YsS));
                        }

                    }
                    // wykreslenie lewej krawedzi bocznej
                    Rysownica.DrawLine(Pioro, XsP - OsDuza / 2, YsP, XsS, YsS);
                    // wykreslenie prawej krawedzi bocznej
                    Rysownica.DrawLine(Pioro, XsP + OsDuza / 2, YsP, XsS, YsS);
                    Widoczny = true;
                }
            }
            public override void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                if (Widoczny)
                {
                    using (Pen Pioro = new Pen(Kontrolka.BackColor, Grubosc_Linii))
                    {
                        Pioro.DashStyle = Styl_Linii;
                        Rysownica.DrawEllipse(Pioro, XsP - OsDuza / 2, YsP - OsMala / 2, OsDuza, OsMala);
                        using (Pen PioroPrążków = new Pen(Pioro.Color, Pioro.Width / 3))
                        {
                            for (int i = 0; i < StopienWielokataPodstawy; i++)
                            {
                                Rysownica.DrawLine(PioroPrążków, WielokatPodlogi[i], new Point(XsS, YsS));
                            }

                        }
                        // wykreslenie lewej krawedzi bocznej
                        Rysownica.DrawLine(Pioro, XsP - OsDuza, YsP, XsS, YsS);
                        // wykreslenie prawej krawedzi bocznej
                        Rysownica.DrawLine(Pioro, XsP + OsDuza, YsP, XsS, YsS);
                        Widoczny = false;
                    }
                }
            }
            public override void ObrociWykresl(Control Kontrolka, Graphics Rysownica, float KątObrotu)
            {
                if (Widoczny)

                    Wymaz(Kontrolka, Rysownica);
                // wyznaczenie nowego kata polozenia pierwszego wierzcholka wielokata podstawy
                if (KierunekObrotu)
                    KatPolozenia -= KątObrotu;
                else
                    KatPolozenia += KątObrotu;
                // wyznaczenie nowych wspolrzednych wielokata podstawy
                for (int i = 0; i < StopienWielokataPodstawy; i++)
                {
                    WielokatPodlogi[i] = new Point();
                    // Wyznaczenie wartosci wspolrzednych i-tego wierzcholka wielokata z rownania parametrycznego elipsy: Xi = XsP + OsDuza /2 * Cos(Fi) Yi = YsP = OŚ_mala * Sin(fi
                    WielokatPodlogi[i].X = (int)(XsP + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWierzcholkami) / 180));
                    WielokatPodlogi[i].Y = (int)(YsP + OsMala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWierzcholkami) / 180));
                }
                // wykreslenie stozka po obrocie
                Wykresl(Rysownica);
            }
            public override void PrzesunDoNowegoXY(Control Kontrolka, Graphics Rysownica, int X, int Y)
            {
                if (Widoczny)
                {
                    int dX, dY;
                    Wymaz(Kontrolka, Rysownica);
                    // wyznaczenie przyrostów zmian dX i dY
                    dX = XsP < X ? X - XsP : -(XsP - X);
                    dY = YsP < Y ? Y - YsP : -(YsP - Y);
                    XsP = XsP + dX;
                    YsP = YsP + dY;
                    XsS = XsS + dX;
                    YsS = YsS + dY;
                    for (int i = 0; i < StopienWielokataPodstawy; i++)
                    {
                        WielokatPodlogi[i] = new Point();
                        // Wyznaczenie wartosci wspolrzednych i-tego wierzcholka wielokata z rownania parametrycznego elipsy: Xi = XsP + OsDuza /2 * Cos(Fi) Yi = YsP = OŚ_mala * Sin(fi
                        WielokatPodlogi[i].X = (int)(XsP + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWierzcholkami) / 180));
                        WielokatPodlogi[i].Y = (int)(YsP + OsMala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWierzcholkami) / 180));
                    }
                    Wykresl(Rysownica);
                }
            }
        }
        public class StozekPochylony : Stozek
        {
            public StozekPochylony(int R, int WysokośćStożka, int StopienWielokataPodstawy, int XsP, int YsP, float KątPochyleniaStożka, Color KolorLinii, DashStyle StylLinii, float GruboscLinii) :
                base(R, WysokośćStożka, StopienWielokataPodstawy, XsP, YsP, KolorLinii, StylLinii, GruboscLinii)
            {
                RodzajBryly = TypyBryl.BG_StozekPochylony;
                Widoczny = false;
                KierunekObrotu = false;
                OsDuza = 2 * PromienBryly;
                OsMala = PromienBryly / 2;
                // wyznaczenie współrzędnych wierzchołka Stożka
                XsS = XsP + (int)(WysokośćStożka / Math.Tan(Math.PI * KątPochyleniaStożka / 180F));
                YsS = YsP - WysokośćStożka;
                KatPolozenia = 0F;
                KatMiedzyWierzcholkami = 360 / StopienWielokataPodstawy;
                WielokatPodlogi = new Point[StopienWielokataPodstawy];
                for (int i = 0; i < StopienWielokataPodstawy; i++)
                {
                    WielokatPodlogi[i] = new Point();
                    // Wyznaczenie wartosci wspolrzednych i-tego wierzcholka wielokata z rownania parametrycznego elipsy: Xi = XsP + OsDuza /2 * Cos(Fi) Yi = YsP = OŚ_mala * Sin(fi
                    WielokatPodlogi[i].X = (int)(XsP + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWierzcholkami) / 180));
                    WielokatPodlogi[i].Y = (int)(YsP + OsMala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWierzcholkami) / 180));
                }
            }
            // nadpisanie metod abstrakcyjnych, ktore zostaly zadeklarowane w glownej klasie bazowej
            public override void Wykresl(Graphics Rysownica)
            {
                using (Pen Pioro = new Pen(Kolor_Linii, Grubosc_Linii))
                {
                    Pioro.DashStyle = Styl_Linii;
                    Rysownica.DrawEllipse(Pioro, XsP - OsDuza / 2, YsP - OsMala / 2, OsDuza, OsMala);
                    using (Pen PioroPrążków = new Pen(Pioro.Color, Pioro.Width / 3))
                    {
                        for (int i = 0; i < StopienWielokataPodstawy; i++)
                        {
                            Rysownica.DrawLine(PioroPrążków, WielokatPodlogi[i], new Point(XsS, YsS));
                        }

                    }
                    // wykreslenie lewej krawedzi bocznej
                    Rysownica.DrawLine(Pioro, XsP - OsDuza / 2, YsP, XsS, YsS);
                    // wykreslenie prawej krawedzi bocznej
                    Rysownica.DrawLine(Pioro, XsP + OsDuza / 2, YsP, XsS, YsS);
                    Widoczny = true;
                }
            }
            public override void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                if (Widoczny)
                {
                    using (Pen Pioro = new Pen(Kontrolka.BackColor, Grubosc_Linii))
                    {
                        Pioro.DashStyle = Styl_Linii;
                        Rysownica.DrawEllipse(Pioro, XsP - OsDuza / 2, YsP - OsMala / 2, OsDuza, OsMala);
                        using (Pen PioroPrążków = new Pen(Pioro.Color, Pioro.Width / 3))
                        {
                            for (int i = 0; i < StopienWielokataPodstawy; i++)
                            {
                                Rysownica.DrawLine(PioroPrążków, WielokatPodlogi[i], new Point(XsS, YsS));
                            }

                        }
                          // wykreslenie lewej krawedzi bocznej
                        Rysownica.DrawLine(Pioro, XsP - OsDuza, YsP, XsS, YsS);
                        // wykreslenie prawej krawedzi bocznej
                        Rysownica.DrawLine(Pioro, XsP + OsDuza, YsP, XsS, YsS);
                        Widoczny = false;
                    }
                }
            }
            public override void ObrociWykresl(Control Kontrolka, Graphics Rysownica, float KątObrotu)
            {
                if (Widoczny)

                    Wymaz(Kontrolka, Rysownica);
                // wyznaczenie nowego kata polozenia pierwszego wierzcholka wielokata podstawy
                if (KierunekObrotu)
                    KatPolozenia -= KątObrotu;
                else
                    KatPolozenia += KątObrotu;
                // wyznaczenie nowych wspolrzednych wielokata podstawy
                for (int i = 0; i < StopienWielokataPodstawy; i++)
                {
                    WielokatPodlogi[i] = new Point();
                    // Wyznaczenie wartosci wspolrzednych i-tego wierzcholka wielokata z rownania parametrycznego elipsy: Xi = XsP + OsDuza /2 * Cos(Fi) Yi = YsP = OŚ_mala * Sin(fi
                    WielokatPodlogi[i].X = (int)(XsP + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWierzcholkami) / 180));
                    WielokatPodlogi[i].Y = (int)(YsP + OsMala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWierzcholkami) / 180));
                }
                // wykreslenie stozka po obrocie
                Wykresl(Rysownica);
            }
            public override void PrzesunDoNowegoXY(Control Kontrolka, Graphics Rysownica, int X, int Y)
            {
                if (Widoczny)
                {
                    int dX, dY;
                    Wymaz(Kontrolka, Rysownica);
                    // wyznaczenie przyrostów zmian dX i dY
                    dX = XsP < X ? X - XsP : -(XsP - X);
                    dY = YsP < Y ? Y - YsP : -(YsP - Y);
                    XsP = XsP + dX;
                    YsP = YsP + dY;
                    XsS = XsS + dX;
                    YsS = YsS + dY;
                    for (int i = 0; i < StopienWielokataPodstawy; i++)
                    {
                        WielokatPodlogi[i] = new Point();
                        // Wyznaczenie wartosci wspolrzednych i-tego wierzcholka wielokata z rownania parametrycznego elipsy: Xi = XsP + OsDuza /2 * Cos(Fi) Yi = YsP = OŚ_mala * Sin(fi
                        WielokatPodlogi[i].X = (int)(XsP + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWierzcholkami) / 180));
                        WielokatPodlogi[i].Y = (int)(YsP + OsMala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWierzcholkami) / 180));
                    }
                    Wykresl(Rysownica);
                }
            }
        }
        public class Wielosciany : BrylaAbstrakcyjna
        {
            protected Point[] WielokatPodlogi;
            protected Point[] WielokątSufitu;
            protected int StopienWielokataPodstawy;
            protected int XsS, YsS;
            protected int PromienBryly;
            public Wielosciany(int R, int StopienWielokataPodstawy, Color KolorLinii, DashStyle StylLinii, float GruboscLinii) :
                base(KolorLinii, StylLinii, GruboscLinii)
            {
                this.PromienBryly = R;
                this.StopienWielokataPodstawy = StopienWielokataPodstawy;
            }
            public override void Wykresl(Graphics Rysownica)
            {
                throw new NotImplementedException();
            }
            public override void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                throw new NotImplementedException();
            }
            public override void ObrociWykresl(Control Kontrolka, Graphics Rysownica, float KątObrotu)
            {
                throw new NotImplementedException();
            }
            public override void PrzesunDoNowegoXY(Control Kontrolka, Graphics Rysownica, int X, int Y)
            {
                throw new NotImplementedException();
            }
        }
        public class Graniastoslup : Wielosciany
        {
            float OsDuza, OsMala;
            float KatSrodkowyMiedzyWierzcholkami;
            float KatPolozeniaPierwszegoWierzchołka;
            public Graniastoslup(int R, int WysokośćGraniastosłupa, int StopienWielokataPodstawy, int XsP, int YsP, Color KolorLinii, DashStyle StylLinii, float GruboscLinii) :
                base(R, StopienWielokataPodstawy, KolorLinii, StylLinii, GruboscLinii)
            {
                RodzajBryly = TypyBryl.BG_Graniastosłup;
                Widoczny = false;
                KierunekObrotu = false;
                WysokoscBryly = WysokośćGraniastosłupa;
                this.StopienWielokataPodstawy = StopienWielokataPodstawy;
                this.XsP = XsP;
                this.YsP = YsP;
                XsS = XsP;
                YsS = YsP - WysokośćGraniastosłupa;
                OsDuza = 2 * R;
                OsMala = R / 2;
                KatSrodkowyMiedzyWierzcholkami = 360 / StopienWielokataPodstawy;
                KatPolozeniaPierwszegoWierzchołka = 0F;
                WielokatPodlogi = new Point[StopienWielokataPodstawy + 1];
                WielokątSufitu = new Point[StopienWielokataPodstawy + 1];
                for (int i = 0; i <= StopienWielokataPodstawy; i++)
                {
                    WielokatPodlogi[i] = new Point();
                    WielokątSufitu[i] = new Point();
                    WielokatPodlogi[i].X = (int)(this.XsP + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozeniaPierwszegoWierzchołka + i * KatSrodkowyMiedzyWierzcholkami) / 180F));
                    WielokatPodlogi[i].Y = (int)(this.YsP + OsMala / 2 * Math.Sin(Math.PI * (KatPolozeniaPierwszegoWierzchołka + i * KatSrodkowyMiedzyWierzcholkami) / 180F));
                    WielokątSufitu[i].X = WielokatPodlogi[i].X;
                    WielokątSufitu[i].Y = WielokatPodlogi[i].Y - WysokośćGraniastosłupa;
                }
            }
            public override void Wykresl(Graphics Rysownica)
            {
                using (Pen Pioro = new Pen(Kolor_Linii, Grubosc_Linii))
                {
                    Pioro.DashStyle = Styl_Linii;
                    for (int i = 0; i < WielokatPodlogi.Length - 1; i++)
                        Rysownica.DrawLine(Pioro, WielokatPodlogi[i], WielokatPodlogi[i + 1]);
                    for (int i = 0; i < WielokątSufitu.Length - 1; i++)
                        Rysownica.DrawLine(Pioro, WielokątSufitu[i], WielokątSufitu[i + 1]);
                    for (int i = 0; i <= StopienWielokataPodstawy; i++)
                        Rysownica.DrawLine(Pioro, WielokatPodlogi[i], WielokątSufitu[i]);
                    Widoczny = true;
                }
            }
            public override void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                if (Widoczny)
                {
                    using (Pen Pioro = new Pen(Kontrolka.BackColor, Grubosc_Linii))
                    {
                        Pioro.DashStyle = Styl_Linii;
                        for (int i = 0; i < WielokatPodlogi.Length - 1; i++)
                            Rysownica.DrawLine(Pioro, WielokatPodlogi[i], WielokatPodlogi[i + 1]);
                        for (int i = 0; i < WielokątSufitu.Length - 1; i++)
                            Rysownica.DrawLine(Pioro, WielokątSufitu[i], WielokątSufitu[i + 1]);
                        for (int i = 0; i <= StopienWielokataPodstawy; i++)
                            Rysownica.DrawLine(Pioro, WielokatPodlogi[i], WielokątSufitu[i]);
                        Widoczny = false;
                    }
                }
            }
            public override void ObrociWykresl(Control Kontrolka, Graphics Rysownica, float KątObrotu)
            {
                if (Widoczny)
                {
                    Wymaz(Kontrolka, Rysownica);
                    if (KierunekObrotu)
                        KatPolozeniaPierwszegoWierzchołka -= KątObrotu;
                    else
                        KatPolozeniaPierwszegoWierzchołka += KątObrotu;
                    for (int i = 0; i <= StopienWielokataPodstawy; i++)
                    {
                        WielokatPodlogi[i] = new Point();
                        WielokątSufitu[i] = new Point();
                        WielokatPodlogi[i].X = (int)(this.XsP + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozeniaPierwszegoWierzchołka + i * KatSrodkowyMiedzyWierzcholkami) / 180F));
                        WielokatPodlogi[i].Y = (int)(this.YsP + OsMala / 2 * Math.Sin(Math.PI * (KatPolozeniaPierwszegoWierzchołka + i * KatSrodkowyMiedzyWierzcholkami) / 180F));
                        WielokątSufitu[i].X = WielokatPodlogi[i].X;
                        WielokątSufitu[i].Y = WielokatPodlogi[i].Y - WysokoscBryly;
                    }
                    Wykresl(Rysownica);
                }
            }
            public override void PrzesunDoNowegoXY(Control Kontrolka, Graphics Rysownica, int X, int Y)
            {
                if (Widoczny)
                {
                    Wymaz(Kontrolka, Rysownica);
                    XsP = X;
                    YsP = Y;
                    XsS = XsP;
                    YsS = YsP - WysokoscBryly;
                    for (int i = 0; i <= StopienWielokataPodstawy; i++)
                    {
                        WielokatPodlogi[i] = new Point();
                        WielokątSufitu[i] = new Point();
                        WielokatPodlogi[i].X = (int)(this.XsP + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozeniaPierwszegoWierzchołka + i * KatSrodkowyMiedzyWierzcholkami) / 180F));
                        WielokatPodlogi[i].Y = (int)(this.YsP + OsMala / 2 * Math.Sin(Math.PI * (KatPolozeniaPierwszegoWierzchołka + i * KatSrodkowyMiedzyWierzcholkami) / 180F));
                        WielokątSufitu[i].X = WielokatPodlogi[i].X;
                        WielokątSufitu[i].Y = WielokatPodlogi[i].Y - WysokoscBryly;
                    }
                    Wykresl(Rysownica);
                }
            }
        }
        public class Ostroslup : Wielosciany
        {
            protected int OsDuza, OsMala;
            protected float KatPolozeniaPierwszegoWierzchołka;
            protected float KatSrodkowyMiedzyWierzcholkami;
            public Ostroslup(int R, int WysokoscOstroslupa, int StopienWielokata, int XsP, int YsP, Color KolorLinii, DashStyle StylLinii, float GruboscLinii) :
                base(R, StopienWielokata, KolorLinii, StylLinii, GruboscLinii)
            {
                RodzajBryly = TypyBryl.BG_Ostrosłup;
                Widoczny = false;
                KierunekObrotu = false;
                WysokoscBryly = WysokoscOstroslupa;
                StopienWielokataPodstawy = StopienWielokata;
                this.XsP = XsP;
                this.YsP = YsP;
                XsS = XsP;
                YsS = YsP - WysokoscOstroslupa;
                OsDuza = 2 * R;
                OsMala = R / 2;
                KatPolozeniaPierwszegoWierzchołka = 0F;
                KatSrodkowyMiedzyWierzcholkami = 360 / StopienWielokata;
                WielokatPodlogi = new Point[StopienWielokataPodstawy + 1];
                for (int i = 0; i <= StopienWielokataPodstawy; i++)
                {
                    WielokatPodlogi[i] = new Point();
                    WielokatPodlogi[i].X = (int)(XsP + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozeniaPierwszegoWierzchołka + i * KatSrodkowyMiedzyWierzcholkami) / 180));
                    WielokatPodlogi[i].Y = (int)(YsP + OsMala / 2 * Math.Sin(Math.PI * (KatPolozeniaPierwszegoWierzchołka + i * KatSrodkowyMiedzyWierzcholkami) / 180));
                }
            }
            public override void Wykresl(Graphics Rysownica)
            {
                using (Pen Pioro = new Pen(Kolor_Linii, Grubosc_Linii))
                {
                    Pioro.DashStyle = Styl_Linii;
                    for (int i = 0; i < WielokatPodlogi.Length - 1; i++)
                        Rysownica.DrawLine(Pioro, WielokatPodlogi[i], WielokatPodlogi[i + 1]);
                    for (int i = 0; i <= StopienWielokataPodstawy; i++)
                        Rysownica.DrawLine(Pioro, WielokatPodlogi[i], new Point(XsS, YsS));
                    Widoczny = true;
                }
            }
            public override void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                if (Widoczny)
                {
                    using (Pen Pioro = new Pen(Kontrolka.BackColor, Grubosc_Linii))
                    {
                        Pioro.DashStyle = Styl_Linii;
                        for (int i = 0; i < WielokatPodlogi.Length - 1; i++)
                            Rysownica.DrawLine(Pioro, WielokatPodlogi[i], WielokatPodlogi[i + 1]);
                        for (int i = 0; i <= StopienWielokataPodstawy; i++)
                            Rysownica.DrawLine(Pioro, WielokatPodlogi[i], new Point(XsS, YsS));
                        Widoczny = false;
                    }
                }
            }
            public override void ObrociWykresl(Control Kontrolka, Graphics Rysownica, float KątObrotu)
            {
                if (Widoczny)
                {
                    Wymaz(Kontrolka, Rysownica);
                    if (KierunekObrotu)
                        KatPolozeniaPierwszegoWierzchołka -= KątObrotu;
                    else
                        KatPolozeniaPierwszegoWierzchołka += KątObrotu;
                    for (int i = 0; i <= StopienWielokataPodstawy; i++)
                    {
                        WielokatPodlogi[i].X = (int)(XsP + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozeniaPierwszegoWierzchołka + i * KatSrodkowyMiedzyWierzcholkami) / 180));
                        WielokatPodlogi[i].Y = (int)(YsP + OsMala / 2 * Math.Sin(Math.PI * (KatPolozeniaPierwszegoWierzchołka + i * KatSrodkowyMiedzyWierzcholkami) / 180));
                    }
                    Wykresl(Rysownica);
                }
            }
            public override void PrzesunDoNowegoXY(Control Kontrolka, Graphics Rysownica, int X, int Y)
            {
                if (Widoczny)
                {
                    Wymaz(Kontrolka, Rysownica);
                    XsP = X;
                    YsP = Y;
                    XsS = XsP;
                    YsS = YsP - WysokoscBryly;
                    for (int i = 0; i <= StopienWielokataPodstawy; i++)
                    {
                        WielokatPodlogi[i].X = (int)(XsP + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozeniaPierwszegoWierzchołka + i * KatSrodkowyMiedzyWierzcholkami) / 180));
                        WielokatPodlogi[i].Y = (int)(YsP + OsMala / 2 * Math.Sin(Math.PI * (KatPolozeniaPierwszegoWierzchołka + i * KatSrodkowyMiedzyWierzcholkami) / 180));
                    }
                    Wykresl(Rysownica);
                }
            }
        }
        public class Kula : BrylyObrotowe
        {
            float OsDuza, OsMala;
            int PrzesunięcieObręczy;
            float KatPolozeniaObręczy;
            public Kula(int R, Point ŚrodekPodłogi, Color KolorLinii, DashStyle StylLinii, float GruboscLinii) :
                base(R, KolorLinii, StylLinii, GruboscLinii)
            {
                RodzajBryly = TypyBryl.BG_Kula;
                Widoczny = false;
                KierunekObrotu = false;
                XsP = ŚrodekPodłogi.X;
                YsP = ŚrodekPodłogi.Y;
                OsDuza = R * 2;
                OsMala = R / 2;
                KatPolozeniaObręczy = 0;
                PrzesunięcieObręczy = 0;
                this.ObjetoscBryly = 4 / 3 * (float)Math.PI * ((OsDuza / 2) * (OsDuza / 2) * (OsDuza / 2));
                this.PowierzchniaBryly = 4 * (float)Math.PI * ((OsDuza / 2) * (OsDuza / 2));
            }
            public override void Wykresl(Graphics Rysownica)
            {
                Pen Pioro = new Pen(Kolor_Linii, Grubosc_Linii);
                Pen PioroObręczy = new Pen(Pioro.Color, 0.5F);
                Pioro.DashStyle = Styl_Linii;
                Rysownica.DrawEllipse(Pioro, XsP - OsDuza / 2, YsP - OsMala / 2, OsDuza, OsDuza);
                Rysownica.DrawEllipse(Pioro, XsP - OsDuza / 2, YsP + OsMala, OsDuza, OsMala);
                Rysownica.DrawEllipse(PioroObręczy, PrzesunięcieObręczy / 2 + XsP - OsDuza / 2, YsP - OsMala / 2, OsDuza - PrzesunięcieObręczy, OsDuza);
                Widoczny = true;
                PioroObręczy.Dispose();
                Pioro.Dispose();
            }
            public override void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                Pen Pioro = new Pen(Kontrolka.BackColor, Grubosc_Linii);
                Pioro.DashStyle = Styl_Linii;
                Rysownica.DrawEllipse(Pioro, XsP - OsDuza / 2, YsP - OsMala / 2, OsDuza, OsDuza);
                Rysownica.DrawEllipse(Pioro, XsP - OsDuza / 2, YsP + OsMala, OsDuza, OsMala);
                Rysownica.DrawEllipse(Pioro, PrzesunięcieObręczy / 2 + XsP - OsDuza / 2, YsP - OsMala / 2, OsDuza - PrzesunięcieObręczy, OsDuza);
                Widoczny = true;
                Pioro.Dispose();
            }
            public override void ObrociWykresl(Control Kontrolka, Graphics Rysownica, float KątObrotu)
            {
                KatPolozeniaObręczy = (KatPolozeniaObręczy = KątObrotu) % 360;
                Wymaz(Kontrolka, Rysownica);
                PrzesunięcieObręczy = (int)(KatPolozeniaObręczy % (int)(OsDuza)) * 2;
                Wykresl(Rysownica);
            }
            public override void PrzesunDoNowegoXY(Control Kontrolka, Graphics Rysownica, int X, int Y)
            {
                Wymaz(Kontrolka, Rysownica);
                XsP = X;
                YsP = Y;
                Wykresl(Rysownica);
            }
        }
        public class StozekZlozony : BrylyObrotowe
        {
            //deklaracje uzupełniajace (pelny opis stozka)
            protected int XsS, YsS, YsS2; //wierzchołek stożka
            protected int StopienWielokataPodstawy;
            protected float OsDuza, OsMala;
            protected float KatMiedzyWierzcholkami;
            protected float KatPolozenia; // pierwszego wierzchołka wielokąta podstawy stozka                                            
            protected Point[] WielokatPodlogi; // deklaracja tablicy dla przechowania refeencji dla egzemplarzy wierzchołków wielokata podstawy
            public StozekZlozony(int R, int WysokośćStożka, int StopienWielokataPodstawy, int XsP, int YsP, Color KolorLinii, DashStyle StylLinii, float GruboscLinii) :
                base(R, KolorLinii, StylLinii, GruboscLinii)
            {
                RodzajBryly = TypyBryl.BG_Stożek;
                Widoczny = false;
                KierunekObrotu = false;
                WysokoscBryly = WysokośćStożka;
                this.StopienWielokataPodstawy = StopienWielokataPodstawy;
                OsDuza = 2 * PromienBryly;
                OsMala = PromienBryly / 2;
                this.XsP = XsP;
                this.YsP = YsP;
                // wyznaczenie współrzędnych wierzchołka Stożka
                XsS = XsP;
                YsS = YsP - WysokośćStożka;
                YsS2 = YsP + WysokośćStożka;
                KatPolozenia = 0F;
                KatMiedzyWierzcholkami = 360 / StopienWielokataPodstawy;
                WielokatPodlogi = new Point[StopienWielokataPodstawy];
                for (int i = 0; i < StopienWielokataPodstawy; i++)
                {
                    WielokatPodlogi[i] = new Point();
                    // Wyznaczenie wartosci wspolrzednych i-tego wierzcholka wielokata z rownania parametrycznego elipsy: Xi = XsP + OsDuza /2 * Cos(Fi) Yi = YsP = OŚ_mala * Sin(fi
                    WielokatPodlogi[i].X = (int)(XsP + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWierzcholkami) / 180));
                    WielokatPodlogi[i].Y = (int)(YsP + OsMala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWierzcholkami) / 180));
                }                
            }
            // nadpisanie metod abstrakcyjnych, ktore zostaly zadeklarowane w glownej klasie bazowej
            public override void Wykresl(Graphics Rysownica)
            {
                using (Pen Pioro = new Pen(Kolor_Linii, Grubosc_Linii))
                {
                    Pioro.DashStyle = Styl_Linii;
                    Rysownica.DrawEllipse(Pioro, XsP - OsDuza / 2, YsP - OsMala / 2, OsDuza, OsMala);
                    using (Pen PioroPrążków = new Pen(Pioro.Color, Pioro.Width / 3))
                    {
                        for (int i = 0; i < StopienWielokataPodstawy; i++)
                        {
                            Rysownica.DrawLine(PioroPrążków, WielokatPodlogi[i], new Point(XsS, YsS));
                        }


                    }
                    using (Pen PioroPrążków = new Pen(Pioro.Color, Pioro.Width / 3))
                    {
                        for (int i = 0; i < StopienWielokataPodstawy; i++)
                        {
                            Rysownica.DrawLine(PioroPrążków, WielokatPodlogi[i], new Point(XsS, YsS2));
                        }


                    }
                    // wykreslenie lewej krawedzi bocznej
                    Rysownica.DrawLine(Pioro, XsP - OsDuza / 2, YsP, XsS, YsS);
                    // wykreslenie prawej krawedzi bocznej
                    Rysownica.DrawLine(Pioro, XsP + OsDuza / 2, YsP, XsS, YsS);
                    // wykreslenie lewej krawedzi bocznej
                    Rysownica.DrawLine(Pioro, XsP - OsDuza / 2, YsP, XsS, YsS2);
                    // wykreslenie prawej krawedzi bocznej
                    Rysownica.DrawLine(Pioro, XsP + OsDuza / 2, YsP, XsS, YsS2);
                    Widoczny = true;
                }
            }
            public override void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                if (Widoczny)
                {
                    using (Pen Pioro = new Pen(Kontrolka.BackColor, Grubosc_Linii))
                    {
                        Pioro.DashStyle = Styl_Linii;
                        Rysownica.DrawEllipse(Pioro, XsP - OsDuza / 2, YsP - OsMala / 2, OsDuza, OsMala);
                        using (Pen PioroPrążków = new Pen(Pioro.Color, Pioro.Width / 3))
                        {
                            for (int i = 0; i < StopienWielokataPodstawy; i++)
                            {
                                Rysownica.DrawLine(PioroPrążków, WielokatPodlogi[i], new Point(XsS, YsS));
                            }

                        }
                        using (Pen PioroPrążków = new Pen(Pioro.Color, Pioro.Width / 3))
                        {
                            for (int i = 0; i < StopienWielokataPodstawy; i++)
                            {
                                Rysownica.DrawLine(PioroPrążków, WielokatPodlogi[i], new Point(XsS, YsS2));
                            }


                        }
                        // wykreslenie lewej krawedzi bocznej
                        Rysownica.DrawLine(Pioro, XsP - OsDuza, YsP, XsS, YsS);
                        // wykreslenie prawej krawedzi bocznej
                        Rysownica.DrawLine(Pioro, XsP + OsDuza, YsP, XsS, YsS);
                        Rysownica.DrawLine(Pioro, XsP - OsDuza / 2, YsP, XsS, YsS2);
                        // wykreslenie prawej krawedzi bocznej
                        Rysownica.DrawLine(Pioro, XsP + OsDuza / 2, YsP, XsS, YsS2);
                        Widoczny = false;
                    }
                }
            }
            public override void ObrociWykresl(Control Kontrolka, Graphics Rysownica, float KątObrotu)
            {
                if (Widoczny)

                    Wymaz(Kontrolka, Rysownica);
                // wyznaczenie nowego kata polozenia pierwszego wierzcholka wielokata podstawy
                if (KierunekObrotu)
                    KatPolozenia -= KątObrotu;
                else
                    KatPolozenia += KątObrotu;
                // wyznaczenie nowych wspolrzednych wielokata podstawy
                for (int i = 0; i < StopienWielokataPodstawy; i++)
                {
                    WielokatPodlogi[i] = new Point();
                    // Wyznaczenie wartosci wspolrzednych i-tego wierzcholka wielokata z rownania parametrycznego elipsy: Xi = XsP + OsDuza /2 * Cos(Fi) Yi = YsP = OŚ_mala * Sin(fi
                    WielokatPodlogi[i].X = (int)(XsP + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWierzcholkami) / 180));
                    WielokatPodlogi[i].Y = (int)(YsP + OsMala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWierzcholkami) / 180));
                }
                // wykreslenie stozka po obrocie
                Wykresl(Rysownica);
            }
            public override void PrzesunDoNowegoXY(Control Kontrolka, Graphics Rysownica, int X, int Y)
            {
                if (Widoczny)
                {
                    int dX, dY;
                    Wymaz(Kontrolka, Rysownica);
                    // wyznaczenie przyrostów zmian dX i dY
                    dX = XsP < X ? X - XsP : -(XsP - X);
                    dY = YsP < Y ? Y - YsP : -(YsP - Y);
                    XsP = XsP + dX;
                    YsP = YsP + dY;
                    XsS = XsS + dX;
                    YsS = YsS + dY;
                    for (int i = 0; i < StopienWielokataPodstawy; i++)
                    {
                        WielokatPodlogi[i] = new Point();
                        // Wyznaczenie wartosci wspolrzednych i-tego wierzcholka wielokata z rownania parametrycznego elipsy: Xi = XsP + OsDuza /2 * Cos(Fi) Yi = YsP = OŚ_mala * Sin(fi
                        WielokatPodlogi[i].X = (int)(XsP + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWierzcholkami) / 180));
                        WielokatPodlogi[i].Y = (int)(YsP + OsMala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWierzcholkami) / 180));
                    }
                    Wykresl(Rysownica);
                }
            }
        }
        public class StozekPochylonyZlozony : Stozek
        {
            protected int YsS2;
            public StozekPochylonyZlozony(int R, int WysokośćStożka, int StopienWielokataPodstawy, int XsP, int YsP, float KątPochyleniaStożka, Color KolorLinii, DashStyle StylLinii, float GruboscLinii) :
                base(R, WysokośćStożka, StopienWielokataPodstawy, XsP, YsP, KolorLinii, StylLinii, GruboscLinii)
            {
                RodzajBryly = TypyBryl.BG_StozekPochylonyZłożony;
                Widoczny = false;
                KierunekObrotu = false;
                OsDuza = 2 * PromienBryly;
                OsMala = PromienBryly / 2;
                // wyznaczenie współrzędnych wierzchołka Stożka
                XsS = XsP + (int)(WysokośćStożka / Math.Tan(Math.PI * KątPochyleniaStożka / 180F));
                YsS = YsP - WysokośćStożka;
                YsS2 = YsP + WysokośćStożka;
                KatPolozenia = 0F;
                KatMiedzyWierzcholkami = 360 / StopienWielokataPodstawy;
                WielokatPodlogi = new Point[StopienWielokataPodstawy];
                for (int i = 0; i < StopienWielokataPodstawy; i++)
                {
                    WielokatPodlogi[i] = new Point();
                    // Wyznaczenie wartosci wspolrzednych i-tego wierzcholka wielokata z rownania parametrycznego elipsy: Xi = XsP + OsDuza /2 * Cos(Fi) Yi = YsP = OŚ_mala * Sin(fi
                    WielokatPodlogi[i].X = (int)(XsP + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWierzcholkami) / 180));
                    WielokatPodlogi[i].Y = (int)(YsP + OsMala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWierzcholkami) / 180));
                }
            }
            // nadpisanie metod abstrakcyjnych, ktore zostaly zadeklarowane w glownej klasie bazowej
            public override void Wykresl(Graphics Rysownica)
            {
                using (Pen Pioro = new Pen(Kolor_Linii, Grubosc_Linii))
                {
                    Pioro.DashStyle = Styl_Linii;
                    Rysownica.DrawEllipse(Pioro, XsP - OsDuza / 2, YsP - OsMala / 2, OsDuza, OsMala);
                    using (Pen PioroPrążków = new Pen(Pioro.Color, Pioro.Width / 3))
                    {
                        for (int i = 0; i < StopienWielokataPodstawy; i++)
                        {
                            Rysownica.DrawLine(PioroPrążków, WielokatPodlogi[i], new Point(XsS, YsS));
                        }

                    }
                    using (Pen PioroPrążków = new Pen(Pioro.Color, Pioro.Width / 3))
                    {
                        for (int i = 0; i < StopienWielokataPodstawy; i++)
                        {
                            Rysownica.DrawLine(PioroPrążków, WielokatPodlogi[i], new Point(XsS, YsS2));
                        }
                    }
                    // wykreslenie lewej krawedzi bocznej
                    Rysownica.DrawLine(Pioro, XsP - OsDuza / 2, YsP, XsS, YsS);
                    // wykreslenie prawej krawedzi bocznej
                    Rysownica.DrawLine(Pioro, XsP + OsDuza / 2, YsP, XsS, YsS);
                    Rysownica.DrawLine(Pioro, XsP - OsDuza / 2, YsP, XsS, YsS2);
                    // wykreslenie prawej krawedzi bocznej
                    Rysownica.DrawLine(Pioro, XsP + OsDuza / 2, YsP, XsS, YsS2);
                    Widoczny = true;
                }
            }
            public override void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                if (Widoczny)
                {
                    using (Pen Pioro = new Pen(Kontrolka.BackColor, Grubosc_Linii))
                    {
                        Pioro.DashStyle = Styl_Linii;
                        Rysownica.DrawEllipse(Pioro, XsP - OsDuza / 2, YsP - OsMala / 2, OsDuza, OsMala);
                        using (Pen PioroPrążków = new Pen(Pioro.Color, Pioro.Width / 3))
                        {
                            for (int i = 0; i < StopienWielokataPodstawy; i++)
                            {
                                Rysownica.DrawLine(PioroPrążków, WielokatPodlogi[i], new Point(XsS, YsS));
                            }

                        }
                        using (Pen PioroPrążków = new Pen(Pioro.Color, Pioro.Width / 3))
                        {
                            for (int i = 0; i < StopienWielokataPodstawy; i++)
                            {
                                Rysownica.DrawLine(PioroPrążków, WielokatPodlogi[i], new Point(XsS, YsS2));
                            }
                        }
                          // wykreslenie lewej krawedzi bocznej
                        Rysownica.DrawLine(Pioro, XsP - OsDuza, YsP, XsS, YsS);
                        // wykreslenie prawej krawedzi bocznej
                        Rysownica.DrawLine(Pioro, XsP + OsDuza, YsP, XsS, YsS);
                        Rysownica.DrawLine(Pioro, XsP - OsDuza / 2, YsP, XsS, YsS2);
                        // wykreslenie prawej krawedzi bocznej
                        Rysownica.DrawLine(Pioro, XsP + OsDuza / 2, YsP, XsS, YsS2);
                        Widoczny = false;
                    }
                }
            }
            public override void ObrociWykresl(Control Kontrolka, Graphics Rysownica, float KątObrotu)
            {
                if (Widoczny)

                    Wymaz(Kontrolka, Rysownica);
                // wyznaczenie nowego kata polozenia pierwszego wierzcholka wielokata podstawy
                if (KierunekObrotu)
                    KatPolozenia -= KątObrotu;
                else
                    KatPolozenia += KątObrotu;
                // wyznaczenie nowych wspolrzednych wielokata podstawy
                for (int i = 0; i < StopienWielokataPodstawy; i++)
                {
                    WielokatPodlogi[i] = new Point();
                    // Wyznaczenie wartosci wspolrzednych i-tego wierzcholka wielokata z rownania parametrycznego elipsy: Xi = XsP + OsDuza /2 * Cos(Fi) Yi = YsP = OŚ_mala * Sin(fi
                    WielokatPodlogi[i].X = (int)(XsP + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWierzcholkami) / 180));
                    WielokatPodlogi[i].Y = (int)(YsP + OsMala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWierzcholkami) / 180));
                }
                // wykreslenie stozka po obrocie
                Wykresl(Rysownica);
            }
            public override void PrzesunDoNowegoXY(Control Kontrolka, Graphics Rysownica, int X, int Y)
            {
                if (Widoczny)
                {
                    int dX, dY;
                    Wymaz(Kontrolka, Rysownica);
                    // wyznaczenie przyrostów zmian dX i dY
                    dX = XsP < X ? X - XsP : -(XsP - X);
                    dY = YsP < Y ? Y - YsP : -(YsP - Y);
                    XsP = XsP + dX;
                    YsP = YsP + dY;
                    XsS = XsS + dX;
                    YsS = YsS + dY;
                    for (int i = 0; i < StopienWielokataPodstawy; i++)
                    {
                        WielokatPodlogi[i] = new Point();
                        // Wyznaczenie wartosci wspolrzednych i-tego wierzcholka wielokata z rownania parametrycznego elipsy: Xi = XsP + OsDuza /2 * Cos(Fi) Yi = YsP = OŚ_mala * Sin(fi
                        WielokatPodlogi[i].X = (int)(XsP + OsDuza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWierzcholkami) / 180));
                        WielokatPodlogi[i].Y = (int)(YsP + OsMala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWierzcholkami) / 180));
                    }
                    Wykresl(Rysownica);
                }
            }
        }
    }
}
