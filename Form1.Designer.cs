namespace Projekt4
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ustawienieKolorówToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolorLiniiBryłyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolorTłaRysownicyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ustawienieStyluToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreskowaDashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreskowoKropkowaDashDotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreskowoKropkowaKropkowaDashDotDotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kropkowaDotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CiągłaSolidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ustawinieGrubościLiniiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.pbWziernikKoloruWypelnienia = new System.Windows.Forms.PictureBox();
            this.pbWziernikLinii = new System.Windows.Forms.PictureBox();
            this.lblKolorWypelnienia = new System.Windows.Forms.Label();
            this.lblAtrybutyGraficzneLinii = new System.Windows.Forms.Label();
            this.lblWyborBryly = new System.Windows.Forms.Label();
            this.cmbListaBryl = new System.Windows.Forms.ComboBox();
            this.pbRysownica = new System.Windows.Forms.PictureBox();
            this.gbAtrybutyNowejBryly = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.trbKatPochyleniaBryly = new System.Windows.Forms.TrackBar();
            this.nudStopienWielokata = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trbPromienBryly = new System.Windows.Forms.TrackBar();
            this.trbWysokoscBryly = new System.Windows.Forms.TrackBar();
            this.btnDodajNowaBryle = new System.Windows.Forms.Button();
            this.ZegarObrotu = new System.Windows.Forms.Timer(this.components);
            this.btnCofnij = new System.Windows.Forms.Button();
            this.btnPrzesun = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWziernikKoloruWypelnienia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWziernikLinii)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).BeginInit();
            this.gbAtrybutyNowejBryly.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbKatPochyleniaBryly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStopienWielokata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbPromienBryly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbWysokoscBryly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.ustawienieKolorówToolStripMenuItem,
            this.ustawienieStyluToolStripMenuItem,
            this.ustawinieGrubościLiniiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1209, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EXITToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(47, 25);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // EXITToolStripMenuItem
            // 
            this.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem";
            this.EXITToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.EXITToolStripMenuItem.Text = "EXIT";
            this.EXITToolStripMenuItem.Click += new System.EventHandler(this.EXITToolStripMenuItem_Click);
            // 
            // ustawienieKolorówToolStripMenuItem
            // 
            this.ustawienieKolorówToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kolorLiniiBryłyToolStripMenuItem,
            this.kolorTłaRysownicyToolStripMenuItem});
            this.ustawienieKolorówToolStripMenuItem.Name = "ustawienieKolorówToolStripMenuItem";
            this.ustawienieKolorówToolStripMenuItem.Size = new System.Drawing.Size(159, 25);
            this.ustawienieKolorówToolStripMenuItem.Text = "Ustawienie kolorów";
            // 
            // kolorLiniiBryłyToolStripMenuItem
            // 
            this.kolorLiniiBryłyToolStripMenuItem.Name = "kolorLiniiBryłyToolStripMenuItem";
            this.kolorLiniiBryłyToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.kolorLiniiBryłyToolStripMenuItem.Text = "Kolor linii bryły";
            this.kolorLiniiBryłyToolStripMenuItem.Click += new System.EventHandler(this.kolorLiniiBryłyToolStripMenuItem_Click);
            // 
            // kolorTłaRysownicyToolStripMenuItem
            // 
            this.kolorTłaRysownicyToolStripMenuItem.Name = "kolorTłaRysownicyToolStripMenuItem";
            this.kolorTłaRysownicyToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.kolorTłaRysownicyToolStripMenuItem.Text = "Kolor tła Rysownicy";
            this.kolorTłaRysownicyToolStripMenuItem.Click += new System.EventHandler(this.kolorTłaRysownicyToolStripMenuItem_Click);
            // 
            // ustawienieStyluToolStripMenuItem
            // 
            this.ustawienieStyluToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreskowaDashToolStripMenuItem,
            this.kreskowoKropkowaDashDotToolStripMenuItem,
            this.kreskowoKropkowaKropkowaDashDotDotToolStripMenuItem,
            this.kropkowaDotToolStripMenuItem,
            this.CiągłaSolidToolStripMenuItem});
            this.ustawienieStyluToolStripMenuItem.Name = "ustawienieStyluToolStripMenuItem";
            this.ustawienieStyluToolStripMenuItem.Size = new System.Drawing.Size(164, 25);
            this.ustawienieStyluToolStripMenuItem.Text = "Ustawienie stylu linii";
            // 
            // kreskowaDashToolStripMenuItem
            // 
            this.kreskowaDashToolStripMenuItem.Name = "kreskowaDashToolStripMenuItem";
            this.kreskowaDashToolStripMenuItem.Size = new System.Drawing.Size(387, 26);
            this.kreskowaDashToolStripMenuItem.Text = "Kreskowa (Dash)";
            this.kreskowaDashToolStripMenuItem.Click += new System.EventHandler(this.kreskowaDashToolStripMenuItem_Click);
            // 
            // kreskowoKropkowaDashDotToolStripMenuItem
            // 
            this.kreskowoKropkowaDashDotToolStripMenuItem.Name = "kreskowoKropkowaDashDotToolStripMenuItem";
            this.kreskowoKropkowaDashDotToolStripMenuItem.Size = new System.Drawing.Size(387, 26);
            this.kreskowoKropkowaDashDotToolStripMenuItem.Text = "KreskowoKropkowa (DashDot)";
            this.kreskowoKropkowaDashDotToolStripMenuItem.Click += new System.EventHandler(this.kreskowoKropkowaDashDotToolStripMenuItem_Click);
            // 
            // kreskowoKropkowaKropkowaDashDotDotToolStripMenuItem
            // 
            this.kreskowoKropkowaKropkowaDashDotDotToolStripMenuItem.Name = "kreskowoKropkowaKropkowaDashDotDotToolStripMenuItem";
            this.kreskowoKropkowaKropkowaDashDotDotToolStripMenuItem.Size = new System.Drawing.Size(387, 26);
            this.kreskowoKropkowaKropkowaDashDotDotToolStripMenuItem.Text = "KreskowoKropkowaKropkowa (DashDotDot)";
            this.kreskowoKropkowaKropkowaDashDotDotToolStripMenuItem.Click += new System.EventHandler(this.kreskowoKropkowaKropkowaDashDotDotToolStripMenuItem_Click);
            // 
            // kropkowaDotToolStripMenuItem
            // 
            this.kropkowaDotToolStripMenuItem.Name = "kropkowaDotToolStripMenuItem";
            this.kropkowaDotToolStripMenuItem.Size = new System.Drawing.Size(387, 26);
            this.kropkowaDotToolStripMenuItem.Text = "Kropkowa (Dot)";
            this.kropkowaDotToolStripMenuItem.Click += new System.EventHandler(this.kropkowaDotToolStripMenuItem_Click);
            // 
            // CiągłaSolidToolStripMenuItem
            // 
            this.CiągłaSolidToolStripMenuItem.Name = "CiągłaSolidToolStripMenuItem";
            this.CiągłaSolidToolStripMenuItem.Size = new System.Drawing.Size(387, 26);
            this.CiągłaSolidToolStripMenuItem.Text = "Ciągła (Solid)";
            this.CiągłaSolidToolStripMenuItem.Click += new System.EventHandler(this.CiągłaSolidToolStripMenuItem_Click);
            // 
            // ustawinieGrubościLiniiToolStripMenuItem
            // 
            this.ustawinieGrubościLiniiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11});
            this.ustawinieGrubościLiniiToolStripMenuItem.Name = "ustawinieGrubościLiniiToolStripMenuItem";
            this.ustawinieGrubościLiniiToolStripMenuItem.Size = new System.Drawing.Size(183, 25);
            this.ustawinieGrubościLiniiToolStripMenuItem.Text = "Ustawinie grubości linii";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 26);
            this.toolStripMenuItem2.Text = "1";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 26);
            this.toolStripMenuItem3.Text = "2";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(180, 26);
            this.toolStripMenuItem4.Text = "3";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(180, 26);
            this.toolStripMenuItem5.Text = "4";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(180, 26);
            this.toolStripMenuItem6.Text = "5";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(180, 26);
            this.toolStripMenuItem7.Text = "6";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(180, 26);
            this.toolStripMenuItem8.Text = "7";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(180, 26);
            this.toolStripMenuItem9.Text = "8";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(180, 26);
            this.toolStripMenuItem10.Text = "9";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.toolStripMenuItem10_Click);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(180, 26);
            this.toolStripMenuItem11.Text = "10";
            this.toolStripMenuItem11.Click += new System.EventHandler(this.toolStripMenuItem11_Click);
            // 
            // pbWziernikKoloruWypelnienia
            // 
            this.pbWziernikKoloruWypelnienia.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbWziernikKoloruWypelnienia.Location = new System.Drawing.Point(37, 104);
            this.pbWziernikKoloruWypelnienia.Name = "pbWziernikKoloruWypelnienia";
            this.pbWziernikKoloruWypelnienia.Size = new System.Drawing.Size(172, 50);
            this.pbWziernikKoloruWypelnienia.TabIndex = 2;
            this.pbWziernikKoloruWypelnienia.TabStop = false;
            // 
            // pbWziernikLinii
            // 
            this.pbWziernikLinii.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbWziernikLinii.Location = new System.Drawing.Point(37, 203);
            this.pbWziernikLinii.Name = "pbWziernikLinii";
            this.pbWziernikLinii.Size = new System.Drawing.Size(172, 50);
            this.pbWziernikLinii.TabIndex = 3;
            this.pbWziernikLinii.TabStop = false;
            // 
            // lblKolorWypelnienia
            // 
            this.lblKolorWypelnienia.AutoSize = true;
            this.lblKolorWypelnienia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKolorWypelnienia.Location = new System.Drawing.Point(34, 60);
            this.lblKolorWypelnienia.Name = "lblKolorWypelnienia";
            this.lblKolorWypelnienia.Size = new System.Drawing.Size(175, 32);
            this.lblKolorWypelnienia.TabIndex = 4;
            this.lblKolorWypelnienia.Text = "Wziernik koloru wypełnienia\r\nbryły geometrycznej";
            // 
            // lblAtrybutyGraficzneLinii
            // 
            this.lblAtrybutyGraficzneLinii.AutoSize = true;
            this.lblAtrybutyGraficzneLinii.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAtrybutyGraficzneLinii.Location = new System.Drawing.Point(34, 168);
            this.lblAtrybutyGraficzneLinii.Name = "lblAtrybutyGraficzneLinii";
            this.lblAtrybutyGraficzneLinii.Size = new System.Drawing.Size(183, 32);
            this.lblAtrybutyGraficzneLinii.TabIndex = 5;
            this.lblAtrybutyGraficzneLinii.Text = "Wziernik atrybutów grficznych \r\nlinii (zewnętrznej) ";
            // 
            // lblWyborBryly
            // 
            this.lblWyborBryly.AutoSize = true;
            this.lblWyborBryly.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWyborBryly.Location = new System.Drawing.Point(72, 266);
            this.lblWyborBryly.Name = "lblWyborBryly";
            this.lblWyborBryly.Size = new System.Drawing.Size(92, 16);
            this.lblWyborBryly.TabIndex = 6;
            this.lblWyborBryly.Text = "Wybierz bryłę";
            // 
            // cmbListaBryl
            // 
            this.cmbListaBryl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbListaBryl.FormattingEnabled = true;
            this.cmbListaBryl.Items.AddRange(new object[] {
            "Walec",
            "Stożek",
            "Kula",
            "StożekPochylony",
            "StożekZłożony",
            "StożekPochylonyZłożony",
            "Ostrosłup",
            "Graniastosłup"});
            this.cmbListaBryl.Location = new System.Drawing.Point(37, 285);
            this.cmbListaBryl.Name = "cmbListaBryl";
            this.cmbListaBryl.Size = new System.Drawing.Size(177, 24);
            this.cmbListaBryl.TabIndex = 7;
            this.cmbListaBryl.Text = "Nie wybrano żadnej bryły";
            this.cmbListaBryl.SelectedIndexChanged += new System.EventHandler(this.cmbListaBryl_SelectedIndexChanged);
            // 
            // pbRysownica
            // 
            this.pbRysownica.BackColor = System.Drawing.SystemColors.Control;
            this.pbRysownica.Location = new System.Drawing.Point(258, 60);
            this.pbRysownica.Name = "pbRysownica";
            this.pbRysownica.Size = new System.Drawing.Size(916, 492);
            this.pbRysownica.TabIndex = 8;
            this.pbRysownica.TabStop = false;
            this.pbRysownica.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbRysownica_MouseClick);
            // 
            // gbAtrybutyNowejBryly
            // 
            this.gbAtrybutyNowejBryly.Controls.Add(this.label4);
            this.gbAtrybutyNowejBryly.Controls.Add(this.trbKatPochyleniaBryly);
            this.gbAtrybutyNowejBryly.Controls.Add(this.nudStopienWielokata);
            this.gbAtrybutyNowejBryly.Controls.Add(this.label3);
            this.gbAtrybutyNowejBryly.Controls.Add(this.label2);
            this.gbAtrybutyNowejBryly.Controls.Add(this.label1);
            this.gbAtrybutyNowejBryly.Controls.Add(this.trbPromienBryly);
            this.gbAtrybutyNowejBryly.Controls.Add(this.trbWysokoscBryly);
            this.gbAtrybutyNowejBryly.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbAtrybutyNowejBryly.Location = new System.Drawing.Point(20, 339);
            this.gbAtrybutyNowejBryly.Name = "gbAtrybutyNowejBryly";
            this.gbAtrybutyNowejBryly.Size = new System.Drawing.Size(197, 326);
            this.gbAtrybutyNowejBryly.TabIndex = 9;
            this.gbAtrybutyNowejBryly.TabStop = false;
            this.gbAtrybutyNowejBryly.Text = "Ustaw atrybuty dla wybranej bryły";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Kąt pochylenia bryły";
            // 
            // trbKatPochyleniaBryly
            // 
            this.trbKatPochyleniaBryly.Enabled = false;
            this.trbKatPochyleniaBryly.Location = new System.Drawing.Point(15, 208);
            this.trbKatPochyleniaBryly.Maximum = 180;
            this.trbKatPochyleniaBryly.Name = "trbKatPochyleniaBryly";
            this.trbKatPochyleniaBryly.Size = new System.Drawing.Size(157, 45);
            this.trbKatPochyleniaBryly.TabIndex = 14;
            this.trbKatPochyleniaBryly.Value = 90;
            // 
            // nudStopienWielokata
            // 
            this.nudStopienWielokata.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nudStopienWielokata.Location = new System.Drawing.Point(33, 275);
            this.nudStopienWielokata.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudStopienWielokata.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudStopienWielokata.Name = "nudStopienWielokata";
            this.nudStopienWielokata.Size = new System.Drawing.Size(127, 24);
            this.nudStopienWielokata.TabIndex = 5;
            this.nudStopienWielokata.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudStopienWielokata.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Liczba wierzchołków podstawy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ustaw wysokość bryły";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ustaw promień bryły";
            // 
            // trbPromienBryly
            // 
            this.trbPromienBryly.Location = new System.Drawing.Point(15, 132);
            this.trbPromienBryly.Maximum = 150;
            this.trbPromienBryly.Minimum = 10;
            this.trbPromienBryly.Name = "trbPromienBryly";
            this.trbPromienBryly.Size = new System.Drawing.Size(165, 45);
            this.trbPromienBryly.TabIndex = 1;
            this.trbPromienBryly.Value = 50;
            // 
            // trbWysokoscBryly
            // 
            this.trbWysokoscBryly.Location = new System.Drawing.Point(15, 68);
            this.trbWysokoscBryly.Maximum = 300;
            this.trbWysokoscBryly.Minimum = 10;
            this.trbWysokoscBryly.Name = "trbWysokoscBryly";
            this.trbWysokoscBryly.Size = new System.Drawing.Size(165, 45);
            this.trbWysokoscBryly.TabIndex = 0;
            this.trbWysokoscBryly.Value = 70;
            // 
            // btnDodajNowaBryle
            // 
            this.btnDodajNowaBryle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajNowaBryle.Location = new System.Drawing.Point(241, 570);
            this.btnDodajNowaBryle.Name = "btnDodajNowaBryle";
            this.btnDodajNowaBryle.Size = new System.Drawing.Size(265, 89);
            this.btnDodajNowaBryle.TabIndex = 10;
            this.btnDodajNowaBryle.Text = "Dodaj wybraną bryłę";
            this.btnDodajNowaBryle.UseVisualStyleBackColor = true;
            this.btnDodajNowaBryle.Click += new System.EventHandler(this.btnDodajNowaBryle_Click);
            // 
            // ZegarObrotu
            // 
            this.ZegarObrotu.Tick += new System.EventHandler(this.ZegarObrotu_Tick);
            // 
            // btnCofnij
            // 
            this.btnCofnij.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCofnij.Location = new System.Drawing.Point(543, 570);
            this.btnCofnij.Name = "btnCofnij";
            this.btnCofnij.Size = new System.Drawing.Size(259, 89);
            this.btnCofnij.TabIndex = 12;
            this.btnCofnij.Text = "Cofnij ostatnią bryłę";
            this.btnCofnij.UseVisualStyleBackColor = true;
            this.btnCofnij.Click += new System.EventHandler(this.btnCofnij_Click);
            // 
            // btnPrzesun
            // 
            this.btnPrzesun.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrzesun.Location = new System.Drawing.Point(847, 570);
            this.btnPrzesun.Name = "btnPrzesun";
            this.btnPrzesun.Size = new System.Drawing.Size(279, 89);
            this.btnPrzesun.TabIndex = 13;
            this.btnPrzesun.Text = "Zmiana lokalizacji brył";
            this.btnPrzesun.UseVisualStyleBackColor = true;
            this.btnPrzesun.Click += new System.EventHandler(this.btnPrzesun_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1209, 677);
            this.Controls.Add(this.btnPrzesun);
            this.Controls.Add(this.btnCofnij);
            this.Controls.Add(this.btnDodajNowaBryle);
            this.Controls.Add(this.gbAtrybutyNowejBryly);
            this.Controls.Add(this.pbRysownica);
            this.Controls.Add(this.cmbListaBryl);
            this.Controls.Add(this.lblWyborBryly);
            this.Controls.Add(this.lblAtrybutyGraficzneLinii);
            this.Controls.Add(this.lblKolorWypelnienia);
            this.Controls.Add(this.pbWziernikLinii);
            this.Controls.Add(this.pbWziernikKoloruWypelnienia);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Wizualizacja podstawowych i złożonych brył geometrycznych";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWziernikKoloruWypelnienia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWziernikLinii)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).EndInit();
            this.gbAtrybutyNowejBryly.ResumeLayout(false);
            this.gbAtrybutyNowejBryly.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbKatPochyleniaBryly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStopienWielokata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbPromienBryly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbWysokoscBryly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EXITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ustawienieKolorówToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolorLiniiBryłyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolorTłaRysownicyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ustawienieStyluToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreskowaDashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreskowoKropkowaDashDotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreskowoKropkowaKropkowaDashDotDotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kropkowaDotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CiągłaSolidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ustawinieGrubościLiniiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.PictureBox pbWziernikKoloruWypelnienia;
        private System.Windows.Forms.PictureBox pbWziernikLinii;
        private System.Windows.Forms.Label lblKolorWypelnienia;
        private System.Windows.Forms.Label lblAtrybutyGraficzneLinii;
        private System.Windows.Forms.Label lblWyborBryly;
        private System.Windows.Forms.ComboBox cmbListaBryl;
        private System.Windows.Forms.PictureBox pbRysownica;
        private System.Windows.Forms.GroupBox gbAtrybutyNowejBryly;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trbPromienBryly;
        private System.Windows.Forms.TrackBar trbWysokoscBryly;
        private System.Windows.Forms.NumericUpDown nudStopienWielokata;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDodajNowaBryle;
        private System.Windows.Forms.Timer ZegarObrotu;
        private System.Windows.Forms.TrackBar trbKatPochyleniaBryly;
        private System.Windows.Forms.Button btnCofnij;
        private System.Windows.Forms.Button btnPrzesun;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

