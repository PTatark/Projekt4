using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using static Projekt4.KlasyBryłGeomerycznych;

namespace Projekt4
{
    public partial class Form1 : Form
    {
        Graphics Rysownica, PowierzchniaGraficznaWziernikaLinii;
        Pen Pioro;
        List<BrylaAbstrakcyjna> LBG = new List<BrylaAbstrakcyjna>();
        Point PunktLokalizacjiBryly = new Point(-1, -1);
        public Form1()
        {
            InitializeComponent();
            pbRysownica.Image = new Bitmap(pbRysownica.Width, pbRysownica.Height);
            Rysownica = Graphics.FromImage(pbRysownica.Image);
            Pioro = new Pen(Color.Black, 1F);
            Pioro.DashStyle = DashStyle.Solid;
            pbWziernikKoloruWypelnienia.BorderStyle = BorderStyle.Fixed3D;
            pbWziernikKoloruWypelnienia.BackColor = pbRysownica.BackColor;
            pbWziernikLinii.Image = new Bitmap(pbWziernikKoloruWypelnienia.Width, pbWziernikKoloruWypelnienia.Height);
            PowierzchniaGraficznaWziernikaLinii = Graphics.FromImage(pbWziernikLinii.Image);
            WykreslenieWziernikaLinii();
        }
        void WykreslenieWziernikaLinii()
        {
            const int Odstęp = 5;
            PowierzchniaGraficznaWziernikaLinii.Clear(pbWziernikLinii.BackColor);
            PowierzchniaGraficznaWziernikaLinii.DrawLine(Pioro, Odstęp, pbWziernikLinii.Height / 2, pbWziernikLinii.Width - 2 * Odstęp, pbWziernikLinii.Height / 2);
            pbWziernikLinii.Refresh();
        }

        private void kolorLiniiBryłyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog PaletaKolorow = new ColorDialog();
            PaletaKolorow.Color = Pioro.Color;
            if (PaletaKolorow.ShowDialog() == DialogResult.OK)
                Pioro.Color = PaletaKolorow.Color;
            WykreslenieWziernikaLinii();
            PaletaKolorow.Dispose();
        }

        private void kropkowaDotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pioro.DashStyle = DashStyle.Dot;
            WykreslenieWziernikaLinii();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Pioro.Width = 3F;
            WykreslenieWziernikaLinii();
        }

        private void btnDodajNowaBryle_Click(object sender, EventArgs e)
        {
            using (SolidBrush Pedzel = new SolidBrush(Color.Red))
            {
                if (PunktLokalizacjiBryly.X != -1)
                pbRysownica.Refresh();
            }

            int WysokoscBryly = trbWysokoscBryly.Value;
            int PromienBryly = trbPromienBryly.Value;
            int StopienWielokata = (int)nudStopienWielokata.Value;
            float KatPochylenia = trbKatPochyleniaBryly.Value;
            int XsP = PunktLokalizacjiBryly.X;
            int YsP = PunktLokalizacjiBryly.Y;
            switch (cmbListaBryl.SelectedItem)
            {
                case "Walec":
                    Walec walec = new Walec(PromienBryly, WysokoscBryly, StopienWielokata, XsP, YsP, Pioro.Color, Pioro.DashStyle, Pioro.Width);
                    walec.Wykresl(Rysownica);
                    LBG.Add(walec);
                    break;
                case "Stożek":
                    Stozek stozek = new Stozek(PromienBryly, WysokoscBryly, StopienWielokata, XsP, YsP, Pioro.Color, Pioro.DashStyle, Pioro.Width);
                    stozek.Wykresl(Rysownica);
                    LBG.Add(stozek);
                    break;
                case "StożekPochylony":
                    StozekPochylony stozekPochylony = new StozekPochylony(PromienBryly, WysokoscBryly, StopienWielokata, XsP, YsP, KatPochylenia, Pioro.Color, Pioro.DashStyle, Pioro.Width);
                    stozekPochylony.Wykresl(Rysownica);
                    LBG.Add(stozekPochylony);
                    break;
                case "StożekZłożony":
                    StozekZlozony stozekZlozony = new StozekZlozony(PromienBryly, WysokoscBryly, StopienWielokata, XsP, YsP, Pioro.Color, Pioro.DashStyle, Pioro.Width);
                    stozekZlozony.Wykresl(Rysownica);
                    LBG.Add(stozekZlozony);
                    break;
                case "StożekPochylonyZłożony":
                    StozekPochylonyZlozony stozekPochylonyZlozony = new StozekPochylonyZlozony(PromienBryly, WysokoscBryly, StopienWielokata, XsP, YsP, KatPochylenia, Pioro.Color, Pioro.DashStyle, Pioro.Width);
                    stozekPochylonyZlozony.Wykresl(Rysownica);
                    LBG.Add(stozekPochylonyZlozony);
                    break;
                case "Graniastosłup":
                    Graniastoslup graniastoslup = new Graniastoslup(PromienBryly, WysokoscBryly, StopienWielokata, XsP, YsP, Pioro.Color, Pioro.DashStyle, Pioro.Width);
                    graniastoslup.Wykresl(Rysownica);
                    LBG.Add(graniastoslup);
                    break;
                case "Ostrosłup":
                    Ostroslup ostroslup = new Ostroslup(PromienBryly, WysokoscBryly, StopienWielokata, XsP, YsP, Pioro.Color, Pioro.DashStyle, Pioro.Width);
                    ostroslup.Wykresl(Rysownica);
                    LBG.Add(ostroslup);
                    break;
                case "Kula":
                    Kula kula = new Kula(PromienBryly, PunktLokalizacjiBryly, Pioro.Color, Pioro.DashStyle, Pioro.Width);
                    kula.Wykresl(Rysownica);
                    LBG.Add(kula);
                    break;
                default:
                    MessageBox.Show("Wybierz jedną z dostępnych brył.");
                    break;
            }
            ZegarObrotu.Enabled = true;
            pbRysownica.Refresh();
        }

        private void ZegarObrotu_Tick(object sender, EventArgs e)
        {
            const float KatObrotu = 5F;
            for (int i = 0; i < LBG.Count; i++)
                LBG[i].ObrociWykresl(pbRysownica, Rysownica, KatObrotu);
            Refresh();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Pioro.Width = 1F;
            WykreslenieWziernikaLinii();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Pioro.Width = 2F;
            WykreslenieWziernikaLinii();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Pioro.Width = 4F;
            WykreslenieWziernikaLinii();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Pioro.Width = 5F;
            WykreslenieWziernikaLinii();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Pioro.Width = 6F;
            WykreslenieWziernikaLinii();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Pioro.Width = 7F;
            WykreslenieWziernikaLinii();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Pioro.Width = 8F;
            WykreslenieWziernikaLinii();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            Pioro.Width = 9F;
            WykreslenieWziernikaLinii();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            Pioro.Width = 10F;
            WykreslenieWziernikaLinii();
        }

        private void kreskowaDashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pioro.DashStyle = DashStyle.Dash;
            WykreslenieWziernikaLinii();
        }

        private void kreskowoKropkowaDashDotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pioro.DashStyle = DashStyle.DashDot;
            WykreslenieWziernikaLinii();
        }

        private void kreskowoKropkowaKropkowaDashDotDotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pioro.DashStyle = DashStyle.DashDotDot;
            WykreslenieWziernikaLinii();
        }

        private void CiągłaSolidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pioro.DashStyle = DashStyle.Solid;
            WykreslenieWziernikaLinii();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cmbListaBryl_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Pamiętaj, że po wyborze bryły geometrycznej i ustawieniu jej atrybutów geometrycznych i graficznych musisz ustalić miejsce (lokalizacje) wykreślenia tej bryły, klikając lewym przyciskiem myszy w odpowiednim miejscu na 'Rysownicy'");
            if ((cmbListaBryl.SelectedItem == "Walec") || (cmbListaBryl.SelectedItem == "Stożek") || (cmbListaBryl.SelectedItem == "Graniastosłup") || (cmbListaBryl.SelectedItem == "Ostrosłup") || (cmbListaBryl.SelectedItem == "Kula"))
            {
                trbWysokoscBryly.Enabled = true;
                trbPromienBryly.Enabled = true;
                nudStopienWielokata.Enabled = true;
            }
            else if ((cmbListaBryl.SelectedItem == "StożekPochylony") || (cmbListaBryl.SelectedItem == "StozekPochylonyZlozony") || (cmbListaBryl.SelectedItem == "WalecPochylony")) ;
            {
                trbWysokoscBryly.Enabled = true;
                trbPromienBryly.Enabled = true;
                nudStopienWielokata.Enabled = true;
                trbKatPochyleniaBryly.Enabled = true;
            }
        }

        private void pbRysownica_MouseClick(object sender, MouseEventArgs e)
        {
            using (SolidBrush Pedzel = new SolidBrush(Color.Red))
            {
                if (PunktLokalizacjiBryly.X != -1)
                {
                    Pedzel.Color = pbRysownica.BackColor;
                    Rysownica.FillEllipse(Pedzel, PunktLokalizacjiBryly.X - 3, PunktLokalizacjiBryly.Y - 3, 6, 6);
                    Pedzel.Color = Color.Red;
                }
                PunktLokalizacjiBryly = e.Location;
                Rysownica.FillEllipse(Pedzel, PunktLokalizacjiBryly.X - 3, PunktLokalizacjiBryly.Y - 3, 6, 6);
                btnDodajNowaBryle.Enabled = true;
                pbRysownica.Refresh();
            }
        }

        private void btnCofnij_Click(object sender, EventArgs e)
        {
            if (LBG.Count <= 0)
            {
                errorProvider1.SetError(btnCofnij, "ERROR: Lista brył jest pusta");
                return;
            }
            LBG.RemoveAt(LBG.Count - 1);
            Rysownica.Clear(pbRysownica.BackColor);
            for (int i = 0; i < LBG.Count; i++)
            {
                LBG[i].Wykresl(Rysownica);
            }
            pbRysownica.Refresh();
            errorProvider1.Dispose();
        }

        private void btnPrzesun_Click(object sender, EventArgs e)
        {
            Rysownica.Clear(pbRysownica.BackColor);
            int XMax = pbRysownica.Width;
            int Ymax = pbRysownica.Height;
            int X, Y;
            Random rnd = new Random();
            for (int i = 0; i < LBG.Count; i++)
            {
                X = rnd.Next(XMax);
                Y = rnd.Next(Ymax);
                LBG[i].PrzesunDoNowegoXY(pbRysownica, Rysownica, X, Y);
                LBG[i].Wykresl(Rysownica);
            }
            pbRysownica.Refresh();
        }

        private void kolorTłaRysownicyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog PaletaKolorow = new ColorDialog();
            PaletaKolorow.Color = pbRysownica.BackColor;
            if (PaletaKolorow.ShowDialog() == DialogResult.OK)
            {
                pbRysownica.BackColor = PaletaKolorow.Color;
                //uaktualnienie wziernka kolorów
                WykreslenieWziernikaLinii();
                //zwolenienie okna dialogowego
                PaletaKolorow.Dispose();
            }
        }

        private void EXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Wynik = MessageBox.Show("Czy rzeczywiście chcesz zakończyć działanie programu?", this.Text, MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            //sprawdzenie odpowiedzi użytkowanika
            if (Wynik != DialogResult.Yes)
                //skasowanie obsługi zdarzenia Cancel
                e.Cancel = true;
            else//zdarzenie Cancel nie może być skasowane
                e.Cancel = false;
        }
    }
}
