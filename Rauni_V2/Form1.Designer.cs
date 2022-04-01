namespace Rauni_V2
{
    partial class mainForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsm_upravljanjeBazom = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_klijenti = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_dodajKlijenta = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_izmjeniKlijenta = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_izbrisiKlijenta = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_stavke = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_dodajStavku = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_izmjeniStavku = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_izbrisiStavku = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_spojiSe = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_dodajKlijentaNaRacun = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_dodajStavkuNaRacun = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_ispis = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_ispisiRacun = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_ispisiSveRaune = new System.Windows.Forms.ToolStripMenuItem();
            this.mainFormLayoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_klijenti = new System.Windows.Forms.DataGridView();
            this.dgv_stavke = new System.Windows.Forms.DataGridView();
            this.menuStrip.SuspendLayout();
            this.mainFormLayoutTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_klijenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stavke)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_upravljanjeBazom,
            this.tsm_dodajKlijentaNaRacun,
            this.tsm_dodajStavkuNaRacun,
            this.tsm_ispis});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // tsm_upravljanjeBazom
            // 
            this.tsm_upravljanjeBazom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_klijenti,
            this.tsm_stavke,
            this.tsm_spojiSe});
            this.tsm_upravljanjeBazom.Name = "tsm_upravljanjeBazom";
            this.tsm_upravljanjeBazom.Size = new System.Drawing.Size(117, 20);
            this.tsm_upravljanjeBazom.Text = "Upravljanje bazom";
            // 
            // tsm_klijenti
            // 
            this.tsm_klijenti.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_dodajKlijenta,
            this.tsm_izmjeniKlijenta,
            this.tsm_izbrisiKlijenta});
            this.tsm_klijenti.Name = "tsm_klijenti";
            this.tsm_klijenti.Size = new System.Drawing.Size(180, 22);
            this.tsm_klijenti.Text = "Klijenti";
            // 
            // tsm_dodajKlijenta
            // 
            this.tsm_dodajKlijenta.Name = "tsm_dodajKlijenta";
            this.tsm_dodajKlijenta.Size = new System.Drawing.Size(199, 22);
            this.tsm_dodajKlijenta.Text = "Dodaj novog klijenta";
            // 
            // tsm_izmjeniKlijenta
            // 
            this.tsm_izmjeniKlijenta.Name = "tsm_izmjeniKlijenta";
            this.tsm_izmjeniKlijenta.Size = new System.Drawing.Size(199, 22);
            this.tsm_izmjeniKlijenta.Text = "Izmjeni podatke klijenta";
            // 
            // tsm_izbrisiKlijenta
            // 
            this.tsm_izbrisiKlijenta.Name = "tsm_izbrisiKlijenta";
            this.tsm_izbrisiKlijenta.Size = new System.Drawing.Size(199, 22);
            this.tsm_izbrisiKlijenta.Text = "Izbriši klijenta";
            // 
            // tsm_stavke
            // 
            this.tsm_stavke.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_dodajStavku,
            this.tsm_izmjeniStavku,
            this.tsm_izbrisiStavku});
            this.tsm_stavke.Name = "tsm_stavke";
            this.tsm_stavke.Size = new System.Drawing.Size(180, 22);
            this.tsm_stavke.Text = "Stavke";
            // 
            // tsm_dodajStavku
            // 
            this.tsm_dodajStavku.Name = "tsm_dodajStavku";
            this.tsm_dodajStavku.Size = new System.Drawing.Size(194, 22);
            this.tsm_dodajStavku.Text = "Dodaj novu stavku";
            // 
            // tsm_izmjeniStavku
            // 
            this.tsm_izmjeniStavku.Name = "tsm_izmjeniStavku";
            this.tsm_izmjeniStavku.Size = new System.Drawing.Size(194, 22);
            this.tsm_izmjeniStavku.Text = "Izmjeni podatke stavke";
            // 
            // tsm_izbrisiStavku
            // 
            this.tsm_izbrisiStavku.Name = "tsm_izbrisiStavku";
            this.tsm_izbrisiStavku.Size = new System.Drawing.Size(194, 22);
            this.tsm_izbrisiStavku.Text = "Izbriši stavku";
            // 
            // tsm_spojiSe
            // 
            this.tsm_spojiSe.Name = "tsm_spojiSe";
            this.tsm_spojiSe.Size = new System.Drawing.Size(180, 22);
            this.tsm_spojiSe.Text = "Spoji se s bazom";
            // 
            // tsm_dodajKlijentaNaRacun
            // 
            this.tsm_dodajKlijentaNaRacun.Name = "tsm_dodajKlijentaNaRacun";
            this.tsm_dodajKlijentaNaRacun.Size = new System.Drawing.Size(140, 20);
            this.tsm_dodajKlijentaNaRacun.Text = "Dodaj klijenta na račun";
            // 
            // tsm_dodajStavkuNaRacun
            // 
            this.tsm_dodajStavkuNaRacun.Name = "tsm_dodajStavkuNaRacun";
            this.tsm_dodajStavkuNaRacun.Size = new System.Drawing.Size(136, 20);
            this.tsm_dodajStavkuNaRacun.Text = "Dodaj stavku na račun";
            // 
            // tsm_ispis
            // 
            this.tsm_ispis.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_ispisiRacun,
            this.tsm_ispisiSveRaune});
            this.tsm_ispis.Name = "tsm_ispis";
            this.tsm_ispis.Size = new System.Drawing.Size(42, 20);
            this.tsm_ispis.Text = "Ispis";
            // 
            // tsm_ispisiRacun
            // 
            this.tsm_ispisiRacun.Name = "tsm_ispisiRacun";
            this.tsm_ispisiRacun.Size = new System.Drawing.Size(159, 22);
            this.tsm_ispisiRacun.Text = "Ispiši račun";
            // 
            // tsm_ispisiSveRaune
            // 
            this.tsm_ispisiSveRaune.Name = "tsm_ispisiSveRaune";
            this.tsm_ispisiSveRaune.Size = new System.Drawing.Size(159, 22);
            this.tsm_ispisiSveRaune.Text = "Ispiši sve račune";
            // 
            // mainFormLayoutTable
            // 
            this.mainFormLayoutTable.ColumnCount = 2;
            this.mainFormLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainFormLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainFormLayoutTable.Controls.Add(this.dgv_klijenti, 0, 0);
            this.mainFormLayoutTable.Controls.Add(this.dgv_stavke, 0, 1);
            this.mainFormLayoutTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainFormLayoutTable.Location = new System.Drawing.Point(0, 24);
            this.mainFormLayoutTable.Name = "mainFormLayoutTable";
            this.mainFormLayoutTable.RowCount = 2;
            this.mainFormLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainFormLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainFormLayoutTable.Size = new System.Drawing.Size(800, 426);
            this.mainFormLayoutTable.TabIndex = 1;
            // 
            // dgv_klijenti
            // 
            this.dgv_klijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_klijenti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_klijenti.Location = new System.Drawing.Point(3, 3);
            this.dgv_klijenti.Name = "dgv_klijenti";
            this.dgv_klijenti.Size = new System.Drawing.Size(394, 207);
            this.dgv_klijenti.TabIndex = 0;
            // 
            // dgv_stavke
            // 
            this.dgv_stavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_stavke.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_stavke.Location = new System.Drawing.Point(3, 216);
            this.dgv_stavke.Name = "dgv_stavke";
            this.dgv_stavke.Size = new System.Drawing.Size(394, 207);
            this.dgv_stavke.TabIndex = 1;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainFormLayoutTable);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "mainForm";
            this.Text = "Racuni";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.mainFormLayoutTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_klijenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stavke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsm_upravljanjeBazom;
        private System.Windows.Forms.TableLayoutPanel mainFormLayoutTable;
        private System.Windows.Forms.ToolStripMenuItem tsm_klijenti;
        private System.Windows.Forms.ToolStripMenuItem tsm_dodajKlijenta;
        private System.Windows.Forms.ToolStripMenuItem tsm_izmjeniKlijenta;
        private System.Windows.Forms.ToolStripMenuItem tsm_izbrisiKlijenta;
        private System.Windows.Forms.ToolStripMenuItem tsm_stavke;
        private System.Windows.Forms.ToolStripMenuItem tsm_dodajStavku;
        private System.Windows.Forms.ToolStripMenuItem tsm_izmjeniStavku;
        private System.Windows.Forms.ToolStripMenuItem tsm_izbrisiStavku;
        private System.Windows.Forms.ToolStripMenuItem tsm_spojiSe;
        private System.Windows.Forms.ToolStripMenuItem tsm_dodajKlijentaNaRacun;
        private System.Windows.Forms.ToolStripMenuItem tsm_dodajStavkuNaRacun;
        private System.Windows.Forms.ToolStripMenuItem tsm_ispis;
        private System.Windows.Forms.ToolStripMenuItem tsm_ispisiRacun;
        private System.Windows.Forms.ToolStripMenuItem tsm_ispisiSveRaune;
        private System.Windows.Forms.DataGridView dgv_klijenti;
        private System.Windows.Forms.DataGridView dgv_stavke;
    }
}

