using System;

namespace Projekti
{
    partial class Jarjestelma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.valikko = new System.Windows.Forms.ToolStrip();
            this.hallitseAsikkaitaBtn = new System.Windows.Forms.ToolStripButton();
            this.hallitseHuoneitaBtn = new System.Windows.Forms.ToolStripButton();
            this.hallitseVarauksiaBtn = new System.Windows.Forms.ToolStripButton();
            this.hallitseAsiakkaitaPanel = new System.Windows.Forms.Panel();
            this.tyhjennaAsiakasBtn = new System.Windows.Forms.Button();
            this.poistaAsiakasBtn = new System.Windows.Forms.Button();
            this.paivitaAsiakasBtn = new System.Windows.Forms.Button();
            this.lisaaAsiakasBtn = new System.Windows.Forms.Button();
            this.asiakkaatDataBox = new System.Windows.Forms.DataGridView();
            this.maaTB = new System.Windows.Forms.TextBox();
            this.asiakasPuhTB = new System.Windows.Forms.TextBox();
            this.sukuNimiTB = new System.Windows.Forms.TextBox();
            this.etuNimiTB = new System.Windows.Forms.TextBox();
            this.asiakasIDTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hallitseHuoneitaPanel = new System.Windows.Forms.Panel();
            this.huoneIDTB = new System.Windows.Forms.TextBox();
            this.huoneIDLabel = new System.Windows.Forms.Label();
            this.huoneTyyppiCB = new System.Windows.Forms.ComboBox();
            this.huoneVapaaEi = new System.Windows.Forms.RadioButton();
            this.huoneVapaaKylla = new System.Windows.Forms.RadioButton();
            this.tyhjennaHuoneBtn = new System.Windows.Forms.Button();
            this.poistaHuoneBtn = new System.Windows.Forms.Button();
            this.paivitaHuoneBtn = new System.Windows.Forms.Button();
            this.lisaaHuoneBtn = new System.Windows.Forms.Button();
            this.huoneetDataBox = new System.Windows.Forms.DataGridView();
            this.huonePuhTB = new System.Windows.Forms.TextBox();
            this.huoneNroTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.hallitseVarauksiaPanel = new System.Windows.Forms.Panel();
            this.varauksetDataBox3 = new System.Windows.Forms.DataGridView();
            this.varauksetDataBox2 = new System.Windows.Forms.DataGridView();
            this.huoneNroVarausTB = new System.Windows.Forms.TextBox();
            this.asiakasVarausIDTB = new System.Windows.Forms.TextBox();
            this.varausLahtoAikaDate = new System.Windows.Forms.DateTimePicker();
            this.varausTuloAikaDate = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tyhjennaVarausBtn = new System.Windows.Forms.Button();
            this.poistaVarausBtn = new System.Windows.Forms.Button();
            this.paivitaVarausBtn = new System.Windows.Forms.Button();
            this.lisaaVarausBtn = new System.Windows.Forms.Button();
            this.varauksetDataBox1 = new System.Windows.Forms.DataGridView();
            this.huoneTyyppiVarausTB = new System.Windows.Forms.TextBox();
            this.varausIDTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.valikko.SuspendLayout();
            this.hallitseAsiakkaitaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.asiakkaatDataBox)).BeginInit();
            this.hallitseHuoneitaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.huoneetDataBox)).BeginInit();
            this.hallitseVarauksiaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.varauksetDataBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksetDataBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksetDataBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // valikko
            // 
            this.valikko.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hallitseAsikkaitaBtn,
            this.hallitseHuoneitaBtn,
            this.hallitseVarauksiaBtn});
            this.valikko.Location = new System.Drawing.Point(0, 0);
            this.valikko.Name = "valikko";
            this.valikko.Size = new System.Drawing.Size(804, 25);
            this.valikko.TabIndex = 9;
            this.valikko.Text = "Valikko";
            // 
            // hallitseAsikkaitaBtn
            // 
            this.hallitseAsikkaitaBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.hallitseAsikkaitaBtn.ImageTransparentColor = System.Drawing.Color.AliceBlue;
            this.hallitseAsikkaitaBtn.Name = "hallitseAsikkaitaBtn";
            this.hallitseAsikkaitaBtn.Size = new System.Drawing.Size(106, 22);
            this.hallitseAsikkaitaBtn.Text = "Hallitse Asiakkaita";
            this.hallitseAsikkaitaBtn.Click += new System.EventHandler(this.hallitseAsikkaitaBtn_Click);
            // 
            // hallitseHuoneitaBtn
            // 
            this.hallitseHuoneitaBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.hallitseHuoneitaBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.hallitseHuoneitaBtn.Name = "hallitseHuoneitaBtn";
            this.hallitseHuoneitaBtn.Size = new System.Drawing.Size(102, 22);
            this.hallitseHuoneitaBtn.Text = "Hallitse Huoneita";
            this.hallitseHuoneitaBtn.Click += new System.EventHandler(this.hallitseHuoneitaBtn_Click);
            // 
            // hallitseVarauksiaBtn
            // 
            this.hallitseVarauksiaBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.hallitseVarauksiaBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.hallitseVarauksiaBtn.Name = "hallitseVarauksiaBtn";
            this.hallitseVarauksiaBtn.Size = new System.Drawing.Size(102, 22);
            this.hallitseVarauksiaBtn.Text = "Hallitse Varauksia";
            this.hallitseVarauksiaBtn.Click += new System.EventHandler(this.hallitseVarauksiaBtn_Click);
            // 
            // hallitseAsiakkaitaPanel
            // 
            this.hallitseAsiakkaitaPanel.Controls.Add(this.tyhjennaAsiakasBtn);
            this.hallitseAsiakkaitaPanel.Controls.Add(this.poistaAsiakasBtn);
            this.hallitseAsiakkaitaPanel.Controls.Add(this.paivitaAsiakasBtn);
            this.hallitseAsiakkaitaPanel.Controls.Add(this.lisaaAsiakasBtn);
            this.hallitseAsiakkaitaPanel.Controls.Add(this.asiakkaatDataBox);
            this.hallitseAsiakkaitaPanel.Controls.Add(this.label1);
            this.hallitseAsiakkaitaPanel.Controls.Add(this.maaTB);
            this.hallitseAsiakkaitaPanel.Controls.Add(this.asiakasPuhTB);
            this.hallitseAsiakkaitaPanel.Controls.Add(this.sukuNimiTB);
            this.hallitseAsiakkaitaPanel.Controls.Add(this.etuNimiTB);
            this.hallitseAsiakkaitaPanel.Controls.Add(this.asiakasIDTB);
            this.hallitseAsiakkaitaPanel.Controls.Add(this.label5);
            this.hallitseAsiakkaitaPanel.Controls.Add(this.label4);
            this.hallitseAsiakkaitaPanel.Controls.Add(this.label3);
            this.hallitseAsiakkaitaPanel.Controls.Add(this.label2);
            this.hallitseAsiakkaitaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hallitseAsiakkaitaPanel.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.hallitseAsiakkaitaPanel.Location = new System.Drawing.Point(0, 25);
            this.hallitseAsiakkaitaPanel.Name = "hallitseAsiakkaitaPanel";
            this.hallitseAsiakkaitaPanel.Size = new System.Drawing.Size(804, 425);
            this.hallitseAsiakkaitaPanel.TabIndex = 1;
            this.hallitseAsiakkaitaPanel.TabStop = true;
            this.hallitseAsiakkaitaPanel.Visible = false;
            // 
            // tyhjennaAsiakasBtn
            // 
            this.tyhjennaAsiakasBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tyhjennaAsiakasBtn.Location = new System.Drawing.Point(112, 282);
            this.tyhjennaAsiakasBtn.Name = "tyhjennaAsiakasBtn";
            this.tyhjennaAsiakasBtn.Size = new System.Drawing.Size(122, 29);
            this.tyhjennaAsiakasBtn.TabIndex = 21;
            this.tyhjennaAsiakasBtn.Text = "Tyhjennä Tiedot";
            this.tyhjennaAsiakasBtn.UseVisualStyleBackColor = true;
            this.tyhjennaAsiakasBtn.Click += new System.EventHandler(this.tyhjennaAsiakasBtn_Click);
            // 
            // poistaAsiakasBtn
            // 
            this.poistaAsiakasBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poistaAsiakasBtn.Location = new System.Drawing.Point(112, 247);
            this.poistaAsiakasBtn.Name = "poistaAsiakasBtn";
            this.poistaAsiakasBtn.Size = new System.Drawing.Size(122, 29);
            this.poistaAsiakasBtn.TabIndex = 20;
            this.poistaAsiakasBtn.Text = "Poista Asiakas";
            this.poistaAsiakasBtn.UseVisualStyleBackColor = true;
            // 
            // paivitaAsiakasBtn
            // 
            this.paivitaAsiakasBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paivitaAsiakasBtn.Location = new System.Drawing.Point(187, 212);
            this.paivitaAsiakasBtn.Name = "paivitaAsiakasBtn";
            this.paivitaAsiakasBtn.Size = new System.Drawing.Size(123, 29);
            this.paivitaAsiakasBtn.TabIndex = 19;
            this.paivitaAsiakasBtn.Text = "Päivitä Asiakas";
            this.paivitaAsiakasBtn.UseVisualStyleBackColor = true;
            this.paivitaAsiakasBtn.Click += new System.EventHandler(this.paivitaAsiakasBtn_Click);
            // 
            // lisaaAsiakasBtn
            // 
            this.lisaaAsiakasBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lisaaAsiakasBtn.Location = new System.Drawing.Point(36, 212);
            this.lisaaAsiakasBtn.Name = "lisaaAsiakasBtn";
            this.lisaaAsiakasBtn.Size = new System.Drawing.Size(125, 29);
            this.lisaaAsiakasBtn.TabIndex = 18;
            this.lisaaAsiakasBtn.Text = "Lisää Asiakas";
            this.lisaaAsiakasBtn.UseVisualStyleBackColor = true;
            this.lisaaAsiakasBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // asiakkaatDataBox
            // 
            this.asiakkaatDataBox.AllowUserToAddRows = false;
            this.asiakkaatDataBox.AllowUserToDeleteRows = false;
            this.asiakkaatDataBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.asiakkaatDataBox.Location = new System.Drawing.Point(341, 13);
            this.asiakkaatDataBox.MultiSelect = false;
            this.asiakkaatDataBox.Name = "asiakkaatDataBox";
            this.asiakkaatDataBox.ReadOnly = true;
            this.asiakkaatDataBox.Size = new System.Drawing.Size(447, 400);
            this.asiakkaatDataBox.TabIndex = 17;
            this.asiakkaatDataBox.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.asiakkaatDataBox_CellClick);
            // 
            // maaTB
            // 
            this.maaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maaTB.Location = new System.Drawing.Point(153, 155);
            this.maaTB.Name = "maaTB";
            this.maaTB.Size = new System.Drawing.Size(157, 24);
            this.maaTB.TabIndex = 16;
            // 
            // asiakasPuhTB
            // 
            this.asiakasPuhTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asiakasPuhTB.Location = new System.Drawing.Point(153, 119);
            this.asiakasPuhTB.Name = "asiakasPuhTB";
            this.asiakasPuhTB.Size = new System.Drawing.Size(157, 24);
            this.asiakasPuhTB.TabIndex = 15;
            // 
            // sukuNimiTB
            // 
            this.sukuNimiTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sukuNimiTB.Location = new System.Drawing.Point(153, 86);
            this.sukuNimiTB.Name = "sukuNimiTB";
            this.sukuNimiTB.Size = new System.Drawing.Size(157, 24);
            this.sukuNimiTB.TabIndex = 14;
            // 
            // etuNimiTB
            // 
            this.etuNimiTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etuNimiTB.Location = new System.Drawing.Point(153, 57);
            this.etuNimiTB.Name = "etuNimiTB";
            this.etuNimiTB.Size = new System.Drawing.Size(157, 24);
            this.etuNimiTB.TabIndex = 13;
            // 
            // asiakasIDTB
            // 
            this.asiakasIDTB.Enabled = false;
            this.asiakasIDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asiakasIDTB.Location = new System.Drawing.Point(153, 24);
            this.asiakasIDTB.Name = "asiakasIDTB";
            this.asiakasIDTB.Size = new System.Drawing.Size(157, 24);
            this.asiakasIDTB.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Maa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Asiakas ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Puhelinnumero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sukunimi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Etunimi:";
            // 
            // hallitseHuoneitaPanel
            // 
            this.hallitseHuoneitaPanel.Controls.Add(this.huoneIDTB);
            this.hallitseHuoneitaPanel.Controls.Add(this.huoneIDLabel);
            this.hallitseHuoneitaPanel.Controls.Add(this.huoneTyyppiCB);
            this.hallitseHuoneitaPanel.Controls.Add(this.huoneVapaaEi);
            this.hallitseHuoneitaPanel.Controls.Add(this.huoneVapaaKylla);
            this.hallitseHuoneitaPanel.Controls.Add(this.tyhjennaHuoneBtn);
            this.hallitseHuoneitaPanel.Controls.Add(this.poistaHuoneBtn);
            this.hallitseHuoneitaPanel.Controls.Add(this.paivitaHuoneBtn);
            this.hallitseHuoneitaPanel.Controls.Add(this.lisaaHuoneBtn);
            this.hallitseHuoneitaPanel.Controls.Add(this.huoneetDataBox);
            this.hallitseHuoneitaPanel.Controls.Add(this.huonePuhTB);
            this.hallitseHuoneitaPanel.Controls.Add(this.huoneNroTB);
            this.hallitseHuoneitaPanel.Controls.Add(this.label7);
            this.hallitseHuoneitaPanel.Controls.Add(this.label8);
            this.hallitseHuoneitaPanel.Controls.Add(this.label9);
            this.hallitseHuoneitaPanel.Controls.Add(this.label10);
            this.hallitseHuoneitaPanel.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.hallitseHuoneitaPanel.Location = new System.Drawing.Point(378, 12);
            this.hallitseHuoneitaPanel.Name = "hallitseHuoneitaPanel";
            this.hallitseHuoneitaPanel.Size = new System.Drawing.Size(800, 425);
            this.hallitseHuoneitaPanel.TabIndex = 2;
            this.hallitseHuoneitaPanel.TabStop = true;
            this.hallitseHuoneitaPanel.Visible = false;
            // 
            // huoneIDTB
            // 
            this.huoneIDTB.Enabled = false;
            this.huoneIDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huoneIDTB.Location = new System.Drawing.Point(153, 37);
            this.huoneIDTB.Name = "huoneIDTB";
            this.huoneIDTB.Size = new System.Drawing.Size(157, 24);
            this.huoneIDTB.TabIndex = 26;
            // 
            // huoneIDLabel
            // 
            this.huoneIDLabel.AutoSize = true;
            this.huoneIDLabel.Enabled = false;
            this.huoneIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huoneIDLabel.Location = new System.Drawing.Point(33, 40);
            this.huoneIDLabel.Name = "huoneIDLabel";
            this.huoneIDLabel.Size = new System.Drawing.Size(74, 18);
            this.huoneIDLabel.TabIndex = 25;
            this.huoneIDLabel.Text = "Huone ID:";
            // 
            // huoneTyyppiCB
            // 
            this.huoneTyyppiCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huoneTyyppiCB.FormattingEnabled = true;
            this.huoneTyyppiCB.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Triple"});
            this.huoneTyyppiCB.Location = new System.Drawing.Point(153, 106);
            this.huoneTyyppiCB.Name = "huoneTyyppiCB";
            this.huoneTyyppiCB.Size = new System.Drawing.Size(157, 26);
            this.huoneTyyppiCB.TabIndex = 24;
            // 
            // huoneVapaaEi
            // 
            this.huoneVapaaEi.AutoSize = true;
            this.huoneVapaaEi.Enabled = false;
            this.huoneVapaaEi.Location = new System.Drawing.Point(224, 175);
            this.huoneVapaaEi.Name = "huoneVapaaEi";
            this.huoneVapaaEi.Size = new System.Drawing.Size(34, 17);
            this.huoneVapaaEi.TabIndex = 23;
            this.huoneVapaaEi.Text = "Ei";
            this.huoneVapaaEi.UseVisualStyleBackColor = true;
            // 
            // huoneVapaaKylla
            // 
            this.huoneVapaaKylla.AutoSize = true;
            this.huoneVapaaKylla.Enabled = false;
            this.huoneVapaaKylla.Location = new System.Drawing.Point(153, 175);
            this.huoneVapaaKylla.Name = "huoneVapaaKylla";
            this.huoneVapaaKylla.Size = new System.Drawing.Size(47, 17);
            this.huoneVapaaKylla.TabIndex = 22;
            this.huoneVapaaKylla.Text = "Kyllä";
            this.huoneVapaaKylla.UseVisualStyleBackColor = true;
            // 
            // tyhjennaHuoneBtn
            // 
            this.tyhjennaHuoneBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tyhjennaHuoneBtn.Location = new System.Drawing.Point(112, 282);
            this.tyhjennaHuoneBtn.Name = "tyhjennaHuoneBtn";
            this.tyhjennaHuoneBtn.Size = new System.Drawing.Size(122, 29);
            this.tyhjennaHuoneBtn.TabIndex = 21;
            this.tyhjennaHuoneBtn.Text = "Tyhjennä Tiedot";
            this.tyhjennaHuoneBtn.UseVisualStyleBackColor = true;
            this.tyhjennaHuoneBtn.Click += new System.EventHandler(this.tyhjennaHuoneBtn_Click);
            // 
            // poistaHuoneBtn
            // 
            this.poistaHuoneBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poistaHuoneBtn.Location = new System.Drawing.Point(112, 247);
            this.poistaHuoneBtn.Name = "poistaHuoneBtn";
            this.poistaHuoneBtn.Size = new System.Drawing.Size(122, 29);
            this.poistaHuoneBtn.TabIndex = 20;
            this.poistaHuoneBtn.Text = "Poista Huone";
            this.poistaHuoneBtn.UseVisualStyleBackColor = true;
            // 
            // paivitaHuoneBtn
            // 
            this.paivitaHuoneBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paivitaHuoneBtn.Location = new System.Drawing.Point(187, 212);
            this.paivitaHuoneBtn.Name = "paivitaHuoneBtn";
            this.paivitaHuoneBtn.Size = new System.Drawing.Size(123, 29);
            this.paivitaHuoneBtn.TabIndex = 19;
            this.paivitaHuoneBtn.Text = "Päivitä Huone";
            this.paivitaHuoneBtn.UseVisualStyleBackColor = true;
            this.paivitaHuoneBtn.Click += new System.EventHandler(this.paivitaHuoneBtn_Click);
            // 
            // lisaaHuoneBtn
            // 
            this.lisaaHuoneBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lisaaHuoneBtn.Location = new System.Drawing.Point(36, 212);
            this.lisaaHuoneBtn.Name = "lisaaHuoneBtn";
            this.lisaaHuoneBtn.Size = new System.Drawing.Size(125, 29);
            this.lisaaHuoneBtn.TabIndex = 18;
            this.lisaaHuoneBtn.Text = "Lisää Huone";
            this.lisaaHuoneBtn.UseVisualStyleBackColor = true;
            this.lisaaHuoneBtn.Click += new System.EventHandler(this.lisaaHuoneBtn_Click);
            // 
            // huoneetDataBox
            // 
            this.huoneetDataBox.AllowUserToAddRows = false;
            this.huoneetDataBox.AllowUserToDeleteRows = false;
            this.huoneetDataBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.huoneetDataBox.Location = new System.Drawing.Point(341, 13);
            this.huoneetDataBox.MultiSelect = false;
            this.huoneetDataBox.Name = "huoneetDataBox";
            this.huoneetDataBox.ReadOnly = true;
            this.huoneetDataBox.Size = new System.Drawing.Size(447, 400);
            this.huoneetDataBox.TabIndex = 17;
            this.huoneetDataBox.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.huoneetDataBox_CellClick);
            // 
            // huonePuhTB
            // 
            this.huonePuhTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huonePuhTB.Location = new System.Drawing.Point(153, 135);
            this.huonePuhTB.Name = "huonePuhTB";
            this.huonePuhTB.Size = new System.Drawing.Size(157, 24);
            this.huonePuhTB.TabIndex = 14;
            // 
            // huoneNroTB
            // 
            this.huoneNroTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huoneNroTB.Location = new System.Drawing.Point(153, 73);
            this.huoneNroTB.Name = "huoneNroTB";
            this.huoneNroTB.Size = new System.Drawing.Size(157, 24);
            this.huoneNroTB.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Huone Nro:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "Vapaa:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(33, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Puhelin:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(33, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 18);
            this.label10.TabIndex = 7;
            this.label10.Text = "Huone Tyyppi:";
            // 
            // hallitseVarauksiaPanel
            // 
            this.hallitseVarauksiaPanel.Controls.Add(this.varauksetDataBox3);
            this.hallitseVarauksiaPanel.Controls.Add(this.varauksetDataBox2);
            this.hallitseVarauksiaPanel.Controls.Add(this.huoneNroVarausTB);
            this.hallitseVarauksiaPanel.Controls.Add(this.asiakasVarausIDTB);
            this.hallitseVarauksiaPanel.Controls.Add(this.varausLahtoAikaDate);
            this.hallitseVarauksiaPanel.Controls.Add(this.varausTuloAikaDate);
            this.hallitseVarauksiaPanel.Controls.Add(this.label15);
            this.hallitseVarauksiaPanel.Controls.Add(this.label14);
            this.hallitseVarauksiaPanel.Controls.Add(this.tyhjennaVarausBtn);
            this.hallitseVarauksiaPanel.Controls.Add(this.poistaVarausBtn);
            this.hallitseVarauksiaPanel.Controls.Add(this.paivitaVarausBtn);
            this.hallitseVarauksiaPanel.Controls.Add(this.lisaaVarausBtn);
            this.hallitseVarauksiaPanel.Controls.Add(this.varauksetDataBox1);
            this.hallitseVarauksiaPanel.Controls.Add(this.huoneTyyppiVarausTB);
            this.hallitseVarauksiaPanel.Controls.Add(this.varausIDTB);
            this.hallitseVarauksiaPanel.Controls.Add(this.label6);
            this.hallitseVarauksiaPanel.Controls.Add(this.label11);
            this.hallitseVarauksiaPanel.Controls.Add(this.label12);
            this.hallitseVarauksiaPanel.Controls.Add(this.label13);
            this.hallitseVarauksiaPanel.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.hallitseVarauksiaPanel.Location = new System.Drawing.Point(669, 0);
            this.hallitseVarauksiaPanel.Name = "hallitseVarauksiaPanel";
            this.hallitseVarauksiaPanel.Size = new System.Drawing.Size(800, 425);
            this.hallitseVarauksiaPanel.TabIndex = 24;
            this.hallitseVarauksiaPanel.TabStop = true;
            this.hallitseVarauksiaPanel.Visible = false;
            // 
            // varauksetDataBox3
            // 
            this.varauksetDataBox3.AllowUserToAddRows = false;
            this.varauksetDataBox3.AllowUserToDeleteRows = false;
            this.varauksetDataBox3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.varauksetDataBox3.Location = new System.Drawing.Point(341, 286);
            this.varauksetDataBox3.MultiSelect = false;
            this.varauksetDataBox3.Name = "varauksetDataBox3";
            this.varauksetDataBox3.ReadOnly = true;
            this.varauksetDataBox3.Size = new System.Drawing.Size(447, 127);
            this.varauksetDataBox3.TabIndex = 31;
            this.varauksetDataBox3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.varauksetDataBox3_CellClick);
            // 
            // varauksetDataBox2
            // 
            this.varauksetDataBox2.AllowUserToAddRows = false;
            this.varauksetDataBox2.AllowUserToDeleteRows = false;
            this.varauksetDataBox2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.varauksetDataBox2.Location = new System.Drawing.Point(341, 150);
            this.varauksetDataBox2.MultiSelect = false;
            this.varauksetDataBox2.Name = "varauksetDataBox2";
            this.varauksetDataBox2.ReadOnly = true;
            this.varauksetDataBox2.Size = new System.Drawing.Size(447, 127);
            this.varauksetDataBox2.TabIndex = 30;
            this.varauksetDataBox2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.varauksetDataBox2_CellClick);
            // 
            // huoneNroVarausTB
            // 
            this.huoneNroVarausTB.Enabled = false;
            this.huoneNroVarausTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huoneNroVarausTB.Location = new System.Drawing.Point(153, 117);
            this.huoneNroVarausTB.Name = "huoneNroVarausTB";
            this.huoneNroVarausTB.Size = new System.Drawing.Size(157, 24);
            this.huoneNroVarausTB.TabIndex = 29;
            // 
            // asiakasVarausIDTB
            // 
            this.asiakasVarausIDTB.Enabled = false;
            this.asiakasVarausIDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asiakasVarausIDTB.Location = new System.Drawing.Point(153, 57);
            this.asiakasVarausIDTB.Name = "asiakasVarausIDTB";
            this.asiakasVarausIDTB.Size = new System.Drawing.Size(157, 24);
            this.asiakasVarausIDTB.TabIndex = 28;
            // 
            // varausLahtoAikaDate
            // 
            this.varausLahtoAikaDate.Location = new System.Drawing.Point(123, 178);
            this.varausLahtoAikaDate.Name = "varausLahtoAikaDate";
            this.varausLahtoAikaDate.Size = new System.Drawing.Size(200, 20);
            this.varausLahtoAikaDate.TabIndex = 27;
            // 
            // varausTuloAikaDate
            // 
            this.varausTuloAikaDate.Location = new System.Drawing.Point(123, 147);
            this.varausTuloAikaDate.Name = "varausTuloAikaDate";
            this.varausTuloAikaDate.Size = new System.Drawing.Size(200, 20);
            this.varausTuloAikaDate.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(34, 180);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 18);
            this.label15.TabIndex = 25;
            this.label15.Text = "Lähtö Pvm:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(33, 150);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 18);
            this.label14.TabIndex = 24;
            this.label14.Text = "Tulo Pvm:";
            // 
            // tyhjennaVarausBtn
            // 
            this.tyhjennaVarausBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tyhjennaVarausBtn.Location = new System.Drawing.Point(113, 307);
            this.tyhjennaVarausBtn.Name = "tyhjennaVarausBtn";
            this.tyhjennaVarausBtn.Size = new System.Drawing.Size(122, 29);
            this.tyhjennaVarausBtn.TabIndex = 21;
            this.tyhjennaVarausBtn.Text = "Tyhjennä Tiedot";
            this.tyhjennaVarausBtn.UseVisualStyleBackColor = true;
            this.tyhjennaVarausBtn.Click += new System.EventHandler(this.tyhjennaVarausBtn_Click);
            // 
            // poistaVarausBtn
            // 
            this.poistaVarausBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poistaVarausBtn.Location = new System.Drawing.Point(113, 272);
            this.poistaVarausBtn.Name = "poistaVarausBtn";
            this.poistaVarausBtn.Size = new System.Drawing.Size(122, 29);
            this.poistaVarausBtn.TabIndex = 20;
            this.poistaVarausBtn.Text = "Poista Varaus";
            this.poistaVarausBtn.UseVisualStyleBackColor = true;
            // 
            // paivitaVarausBtn
            // 
            this.paivitaVarausBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paivitaVarausBtn.Location = new System.Drawing.Point(188, 237);
            this.paivitaVarausBtn.Name = "paivitaVarausBtn";
            this.paivitaVarausBtn.Size = new System.Drawing.Size(123, 29);
            this.paivitaVarausBtn.TabIndex = 19;
            this.paivitaVarausBtn.Text = "Päivitä Varaus";
            this.paivitaVarausBtn.UseVisualStyleBackColor = true;
            this.paivitaVarausBtn.Click += new System.EventHandler(this.paivitaVarausBtn_Click);
            // 
            // lisaaVarausBtn
            // 
            this.lisaaVarausBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lisaaVarausBtn.Location = new System.Drawing.Point(37, 237);
            this.lisaaVarausBtn.Name = "lisaaVarausBtn";
            this.lisaaVarausBtn.Size = new System.Drawing.Size(125, 29);
            this.lisaaVarausBtn.TabIndex = 18;
            this.lisaaVarausBtn.Text = "Lisää Varaus";
            this.lisaaVarausBtn.UseVisualStyleBackColor = true;
            this.lisaaVarausBtn.Click += new System.EventHandler(this.lisaaVarausBtn_Click);
            // 
            // varauksetDataBox1
            // 
            this.varauksetDataBox1.AllowUserToAddRows = false;
            this.varauksetDataBox1.AllowUserToDeleteRows = false;
            this.varauksetDataBox1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.varauksetDataBox1.Location = new System.Drawing.Point(341, 13);
            this.varauksetDataBox1.MultiSelect = false;
            this.varauksetDataBox1.Name = "varauksetDataBox1";
            this.varauksetDataBox1.ReadOnly = true;
            this.varauksetDataBox1.Size = new System.Drawing.Size(447, 127);
            this.varauksetDataBox1.TabIndex = 17;
            this.varauksetDataBox1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.varauksetDataBox1_CellClick);
            // 
            // huoneTyyppiVarausTB
            // 
            this.huoneTyyppiVarausTB.Enabled = false;
            this.huoneTyyppiVarausTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huoneTyyppiVarausTB.Location = new System.Drawing.Point(153, 86);
            this.huoneTyyppiVarausTB.Name = "huoneTyyppiVarausTB";
            this.huoneTyyppiVarausTB.Size = new System.Drawing.Size(157, 24);
            this.huoneTyyppiVarausTB.TabIndex = 14;
            // 
            // varausIDTB
            // 
            this.varausIDTB.Enabled = false;
            this.varausIDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.varausIDTB.Location = new System.Drawing.Point(153, 24);
            this.varausIDTB.Name = "varausIDTB";
            this.varausIDTB.Size = new System.Drawing.Size(157, 24);
            this.varausIDTB.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Varaus ID:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(33, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 18);
            this.label11.TabIndex = 9;
            this.label11.Text = "Huone Nro:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(33, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 18);
            this.label12.TabIndex = 8;
            this.label12.Text = "Huone Tyyppi:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(33, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 18);
            this.label13.TabIndex = 7;
            this.label13.Text = "Asiakas ID:";
            // 
            // Jarjestelma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.hallitseVarauksiaPanel);
            this.Controls.Add(this.hallitseHuoneitaPanel);
            this.Controls.Add(this.hallitseAsiakkaitaPanel);
            this.Controls.Add(this.valikko);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Jarjestelma";
            this.Text = "Jarjestelma";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.valikko.ResumeLayout(false);
            this.valikko.PerformLayout();
            this.hallitseAsiakkaitaPanel.ResumeLayout(false);
            this.hallitseAsiakkaitaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.asiakkaatDataBox)).EndInit();
            this.hallitseHuoneitaPanel.ResumeLayout(false);
            this.hallitseHuoneitaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.huoneetDataBox)).EndInit();
            this.hallitseVarauksiaPanel.ResumeLayout(false);
            this.hallitseVarauksiaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.varauksetDataBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksetDataBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksetDataBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStrip valikko;
        private System.Windows.Forms.ToolStripButton hallitseAsikkaitaBtn;
        private System.Windows.Forms.ToolStripButton hallitseHuoneitaBtn;
        private System.Windows.Forms.ToolStripButton hallitseVarauksiaBtn;
        private System.Windows.Forms.Panel hallitseAsiakkaitaPanel;
        private System.Windows.Forms.Button lisaaAsiakasBtn;
        private System.Windows.Forms.DataGridView asiakkaatDataBox;
        private System.Windows.Forms.TextBox maaTB;
        private System.Windows.Forms.TextBox asiakasPuhTB;
        private System.Windows.Forms.TextBox sukuNimiTB;
        private System.Windows.Forms.TextBox etuNimiTB;
        private System.Windows.Forms.TextBox asiakasIDTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel hallitseHuoneitaPanel;
        private System.Windows.Forms.RadioButton huoneVapaaEi;
        private System.Windows.Forms.RadioButton huoneVapaaKylla;
        private System.Windows.Forms.Button tyhjennaHuoneBtn;
        private System.Windows.Forms.Button poistaHuoneBtn;
        private System.Windows.Forms.Button paivitaHuoneBtn;
        private System.Windows.Forms.Button lisaaHuoneBtn;
        private System.Windows.Forms.DataGridView huoneetDataBox;
        private System.Windows.Forms.TextBox huonePuhTB;
        private System.Windows.Forms.TextBox huoneNroTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button tyhjennaAsiakasBtn;
        private System.Windows.Forms.Button poistaAsiakasBtn;
        private System.Windows.Forms.Button paivitaAsiakasBtn;
        private System.Windows.Forms.Panel hallitseVarauksiaPanel;
        private System.Windows.Forms.TextBox huoneNroVarausTB;
        private System.Windows.Forms.TextBox asiakasVarausIDTB;
        private System.Windows.Forms.DateTimePicker varausLahtoAikaDate;
        private System.Windows.Forms.DateTimePicker varausTuloAikaDate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button tyhjennaVarausBtn;
        private System.Windows.Forms.Button poistaVarausBtn;
        private System.Windows.Forms.Button paivitaVarausBtn;
        private System.Windows.Forms.Button lisaaVarausBtn;
        private System.Windows.Forms.DataGridView varauksetDataBox1;
        private System.Windows.Forms.TextBox huoneTyyppiVarausTB;
        private System.Windows.Forms.TextBox varausIDTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox huoneTyyppiCB;
        private System.Windows.Forms.DataGridView varauksetDataBox3;
        private System.Windows.Forms.DataGridView varauksetDataBox2;
        private System.Windows.Forms.TextBox huoneIDTB;
        private System.Windows.Forms.Label huoneIDLabel;

    }
}

