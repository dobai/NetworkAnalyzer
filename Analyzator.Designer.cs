namespace SietovyAnalyzator
{
    partial class analyzator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(analyzator));
            this.dtgTabulka = new System.Windows.Forms.DataGridView();
            this.btnOtvorit = new System.Windows.Forms.Button();
            this.txtHexPole = new System.Windows.Forms.TextBox();
            this.staBar = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.bgbNacitaj = new System.Windows.Forms.ToolStripProgressBar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtCiel = new System.Windows.Forms.MaskedTextBox();
            this.txtZdroj = new System.Windows.Forms.MaskedTextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtPoznamka = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTyp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNazov = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCislo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dlgSubor = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTabulka)).BeginInit();
            this.staBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgTabulka
            // 
            this.dtgTabulka.AllowUserToAddRows = false;
            this.dtgTabulka.AllowUserToDeleteRows = false;
            this.dtgTabulka.AllowUserToResizeRows = false;
            this.dtgTabulka.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgTabulka.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgTabulka.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgTabulka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTabulka.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgTabulka.Location = new System.Drawing.Point(12, 12);
            this.dtgTabulka.MultiSelect = false;
            this.dtgTabulka.Name = "dtgTabulka";
            this.dtgTabulka.ReadOnly = true;
            this.dtgTabulka.RowHeadersVisible = false;
            this.dtgTabulka.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgTabulka.Size = new System.Drawing.Size(660, 191);
            this.dtgTabulka.TabIndex = 0;
            this.dtgTabulka.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTabulka_CellContentClick);
            // 
            // btnOtvorit
            // 
            this.btnOtvorit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOtvorit.Location = new System.Drawing.Point(597, 156);
            this.btnOtvorit.Name = "btnOtvorit";
            this.btnOtvorit.Size = new System.Drawing.Size(75, 21);
            this.btnOtvorit.TabIndex = 1;
            this.btnOtvorit.Text = "Otvoriť";
            this.btnOtvorit.UseVisualStyleBackColor = true;
            this.btnOtvorit.Click += new System.EventHandler(this.btnOtvorit_Click);
            // 
            // txtHexPole
            // 
            this.txtHexPole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHexPole.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtHexPole.Location = new System.Drawing.Point(12, 71);
            this.txtHexPole.Multiline = true;
            this.txtHexPole.Name = "txtHexPole";
            this.txtHexPole.ReadOnly = true;
            this.txtHexPole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHexPole.Size = new System.Drawing.Size(660, 80);
            this.txtHexPole.TabIndex = 3;
            this.txtHexPole.Text = resources.GetString("txtHexPole.Text");
            // 
            // staBar
            // 
            this.staBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.bgbNacitaj});
            this.staBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.staBar.Location = new System.Drawing.Point(0, 390);
            this.staBar.Name = "staBar";
            this.staBar.Size = new System.Drawing.Size(684, 22);
            this.staBar.TabIndex = 4;
            this.staBar.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(63, 17);
            this.lblStatus.Text = "Pripravený";
            // 
            // bgbNacitaj
            // 
            this.bgbNacitaj.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bgbNacitaj.Name = "bgbNacitaj";
            this.bgbNacitaj.Size = new System.Drawing.Size(100, 16);
            this.bgbNacitaj.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dtgTabulka);
            this.splitContainer1.Panel1MinSize = 100;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.txtCiel);
            this.splitContainer1.Panel2.Controls.Add(this.txtZdroj);
            this.splitContainer1.Panel2.Controls.Add(this.txtAdresa);
            this.splitContainer1.Panel2.Controls.Add(this.txtPoznamka);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.txtTyp);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.txtNazov);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.txtCislo);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.txtHexPole);
            this.splitContainer1.Panel2.Controls.Add(this.btnOtvorit);
            this.splitContainer1.Panel2MinSize = 150;
            this.splitContainer1.Size = new System.Drawing.Size(684, 390);
            this.splitContainer1.SplitterDistance = 206;
            this.splitContainer1.TabIndex = 5;
            // 
            // txtCiel
            // 
            this.txtCiel.Location = new System.Drawing.Point(245, 42);
            this.txtCiel.Mask = "aa-aa-aa-aa-aa-aa";
            this.txtCiel.Name = "txtCiel";
            this.txtCiel.ReadOnly = true;
            this.txtCiel.Size = new System.Drawing.Size(100, 20);
            this.txtCiel.TabIndex = 18;
            // 
            // txtZdroj
            // 
            this.txtZdroj.Location = new System.Drawing.Point(245, 16);
            this.txtZdroj.Mask = "aa-aa-aa-aa-aa-aa";
            this.txtZdroj.Name = "txtZdroj";
            this.txtZdroj.ReadOnly = true;
            this.txtZdroj.Size = new System.Drawing.Size(100, 20);
            this.txtZdroj.TabIndex = 17;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAdresa.Location = new System.Drawing.Point(12, 156);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.ReadOnly = true;
            this.txtAdresa.Size = new System.Drawing.Size(579, 20);
            this.txtAdresa.TabIndex = 16;
            // 
            // txtPoznamka
            // 
            this.txtPoznamka.Location = new System.Drawing.Point(417, 42);
            this.txtPoznamka.Name = "txtPoznamka";
            this.txtPoznamka.ReadOnly = true;
            this.txtPoznamka.Size = new System.Drawing.Size(100, 20);
            this.txtPoznamka.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(354, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Poznámka";
            // 
            // txtTyp
            // 
            this.txtTyp.Location = new System.Drawing.Point(417, 16);
            this.txtTyp.Name = "txtTyp";
            this.txtTyp.ReadOnly = true;
            this.txtTyp.Size = new System.Drawing.Size(100, 20);
            this.txtTyp.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(386, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Typ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "MAC cieľa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "MAC zdroja";
            // 
            // txtNazov
            // 
            this.txtNazov.Location = new System.Drawing.Point(68, 42);
            this.txtNazov.Name = "txtNazov";
            this.txtNazov.ReadOnly = true;
            this.txtNazov.Size = new System.Drawing.Size(100, 20);
            this.txtNazov.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Názov";
            // 
            // txtCislo
            // 
            this.txtCislo.Location = new System.Drawing.Point(68, 16);
            this.txtCislo.Name = "txtCislo";
            this.txtCislo.ReadOnly = true;
            this.txtCislo.Size = new System.Drawing.Size(100, 20);
            this.txtCislo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Číslo";
            // 
            // dlgSubor
            // 
            this.dlgSubor.FileName = "openFileDialog1";
            // 
            // analyzator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 412);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.staBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(550, 350);
            this.Name = "analyzator";
            this.Text = "Sieťový analyzátor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTabulka)).EndInit();
            this.staBar.ResumeLayout(false);
            this.staBar.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgTabulka;
        private System.Windows.Forms.Button btnOtvorit;
        private System.Windows.Forms.TextBox txtHexPole;
        private System.Windows.Forms.StatusStrip staBar;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripProgressBar bgbNacitaj;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtPoznamka;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTyp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNazov;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCislo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.MaskedTextBox txtCiel;
        private System.Windows.Forms.MaskedTextBox txtZdroj;
        private System.Windows.Forms.OpenFileDialog dlgSubor;

    }
}

