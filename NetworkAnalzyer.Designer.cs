namespace NetworkAnalzyer
{
    partial class NetworkAnalzyer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetworkAnalzyer));
            this.dtgTabulka = new System.Windows.Forms.DataGridView();
            this.txtHexPole = new System.Windows.Forms.TextBox();
            this.staBar = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.bgbNacitaj = new System.Windows.Forms.ToolStripProgressBar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dlgSubor = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.súborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.koniecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otvoritToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.protokolylistBox = new System.Windows.Forms.ListBox();
            this.zobraziťToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.výpisRámcovToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.výpisKomunikácieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pomocníkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgrameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.naposledyOtvorenéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zatvorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paketylistBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTabulka)).BeginInit();
            this.staBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
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
            this.dtgTabulka.Location = new System.Drawing.Point(174, 27);
            this.dtgTabulka.MultiSelect = false;
            this.dtgTabulka.Name = "dtgTabulka";
            this.dtgTabulka.ReadOnly = true;
            this.dtgTabulka.RowHeadersVisible = false;
            this.dtgTabulka.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgTabulka.Size = new System.Drawing.Size(498, 176);
            this.dtgTabulka.TabIndex = 0;
            this.dtgTabulka.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTabulka_CellContentClick);
            // 
            // txtHexPole
            // 
            this.txtHexPole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHexPole.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtHexPole.Location = new System.Drawing.Point(0, 0);
            this.txtHexPole.Multiline = true;
            this.txtHexPole.Name = "txtHexPole";
            this.txtHexPole.ReadOnly = true;
            this.txtHexPole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHexPole.Size = new System.Drawing.Size(320, 147);
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
            this.splitContainer1.Panel1.Controls.Add(this.protokolylistBox);
            this.splitContainer1.Panel1.Controls.Add(this.dtgTabulka);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip);
            this.splitContainer1.Panel1MinSize = 100;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2MinSize = 150;
            this.splitContainer1.Size = new System.Drawing.Size(684, 390);
            this.splitContainer1.SplitterDistance = 206;
            this.splitContainer1.TabIndex = 5;
            // 
            // dlgSubor
            // 
            this.dlgSubor.FileName = "openFileDialog1";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.súborToolStripMenuItem,
            this.zobraziťToolStripMenuItem,
            this.pomocníkToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(684, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // súborToolStripMenuItem
            // 
            this.súborToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otvoritToolStripMenuItem,
            this.zatvorToolStripMenuItem,
            this.naposledyOtvorenéToolStripMenuItem,
            this.toolStripSeparator1,
            this.koniecToolStripMenuItem});
            this.súborToolStripMenuItem.Name = "súborToolStripMenuItem";
            this.súborToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.súborToolStripMenuItem.Text = "Súbor";
            // 
            // koniecToolStripMenuItem
            // 
            this.koniecToolStripMenuItem.Name = "koniecToolStripMenuItem";
            this.koniecToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.koniecToolStripMenuItem.Text = "Koniec";
            // 
            // otvoritToolStripMenuItem
            // 
            this.otvoritToolStripMenuItem.Name = "otvoritToolStripMenuItem";
            this.otvoritToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.otvoritToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.otvoritToolStripMenuItem.Text = "Otvor...";
            this.otvoritToolStripMenuItem.Click += new System.EventHandler(this.otvoritToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(336, 147);
            this.textBox1.TabIndex = 17;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(12, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.textBox1);
            this.splitContainer2.Panel1MinSize = 200;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.paketylistBox);
            this.splitContainer2.Panel2.Controls.Add(this.txtHexPole);
            this.splitContainer2.Panel2MinSize = 320;
            this.splitContainer2.Size = new System.Drawing.Size(660, 147);
            this.splitContainer2.SplitterDistance = 336;
            this.splitContainer2.TabIndex = 18;
            // 
            // protokolylistBox
            // 
            this.protokolylistBox.FormattingEnabled = true;
            this.protokolylistBox.Location = new System.Drawing.Point(12, 27);
            this.protokolylistBox.Name = "protokolylistBox";
            this.protokolylistBox.Size = new System.Drawing.Size(156, 173);
            this.protokolylistBox.TabIndex = 2;
            this.protokolylistBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // zobraziťToolStripMenuItem
            // 
            this.zobraziťToolStripMenuItem.Checked = true;
            this.zobraziťToolStripMenuItem.CheckOnClick = true;
            this.zobraziťToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.zobraziťToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.výpisRámcovToolStripMenuItem,
            this.výpisKomunikácieToolStripMenuItem,
            this.toolStripSeparator2,
            this.statusStripMenuItem});
            this.zobraziťToolStripMenuItem.Name = "zobraziťToolStripMenuItem";
            this.zobraziťToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.zobraziťToolStripMenuItem.Text = "Zobraziť";
            // 
            // výpisRámcovToolStripMenuItem
            // 
            this.výpisRámcovToolStripMenuItem.Checked = true;
            this.výpisRámcovToolStripMenuItem.CheckOnClick = true;
            this.výpisRámcovToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.výpisRámcovToolStripMenuItem.Name = "výpisRámcovToolStripMenuItem";
            this.výpisRámcovToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.výpisRámcovToolStripMenuItem.Text = "Výpis rámcov";
            this.výpisRámcovToolStripMenuItem.Click += new System.EventHandler(this.výpisRámcovToolStripMenuItem_Click);
            // 
            // výpisKomunikácieToolStripMenuItem
            // 
            this.výpisKomunikácieToolStripMenuItem.CheckOnClick = true;
            this.výpisKomunikácieToolStripMenuItem.Name = "výpisKomunikácieToolStripMenuItem";
            this.výpisKomunikácieToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.výpisKomunikácieToolStripMenuItem.Text = "Výpis komunikácie";
            this.výpisKomunikácieToolStripMenuItem.Click += new System.EventHandler(this.výpisKomunikácieToolStripMenuItem_Click);
            // 
            // statusStripMenuItem
            // 
            this.statusStripMenuItem.Checked = true;
            this.statusStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusStripMenuItem.Name = "statusStripMenuItem";
            this.statusStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.statusStripMenuItem.Text = "Stavový riadok";
            this.statusStripMenuItem.Click += new System.EventHandler(this.statusStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(170, 6);
            // 
            // pomocníkToolStripMenuItem
            // 
            this.pomocníkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pomocToolStripMenuItem,
            this.toolStripSeparator3,
            this.oProgrameToolStripMenuItem});
            this.pomocníkToolStripMenuItem.Name = "pomocníkToolStripMenuItem";
            this.pomocníkToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.pomocníkToolStripMenuItem.Text = "Pomocník";
            // 
            // oProgrameToolStripMenuItem
            // 
            this.oProgrameToolStripMenuItem.Name = "oProgrameToolStripMenuItem";
            this.oProgrameToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.oProgrameToolStripMenuItem.Text = "O programe...";
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.pomocToolStripMenuItem.Text = "Pomocník programu Sieťový analyzátor";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(280, 6);
            // 
            // naposledyOtvorenéToolStripMenuItem
            // 
            this.naposledyOtvorenéToolStripMenuItem.Name = "naposledyOtvorenéToolStripMenuItem";
            this.naposledyOtvorenéToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.naposledyOtvorenéToolStripMenuItem.Text = "Naposledy otvorené";
            // 
            // zatvorToolStripMenuItem
            // 
            this.zatvorToolStripMenuItem.Name = "zatvorToolStripMenuItem";
            this.zatvorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zatvorToolStripMenuItem.Text = "Zatvor";
            // 
            // paketylistBox
            // 
            this.paketylistBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paketylistBox.FormattingEnabled = true;
            this.paketylistBox.Location = new System.Drawing.Point(0, 0);
            this.paketylistBox.Name = "paketylistBox";
            this.paketylistBox.Size = new System.Drawing.Size(320, 147);
            this.paketylistBox.TabIndex = 4;
            this.paketylistBox.Visible = false;
            // 
            // analyzator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 412);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.staBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(550, 350);
            this.Name = "analyzator";
            this.Text = "Sieťový analyzátor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTabulka)).EndInit();
            this.staBar.ResumeLayout(false);
            this.staBar.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgTabulka;
        private System.Windows.Forms.TextBox txtHexPole;
        private System.Windows.Forms.StatusStrip staBar;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripProgressBar bgbNacitaj;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.OpenFileDialog dlgSubor;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem súborToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otvoritToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem koniecToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox protokolylistBox;
        private System.Windows.Forms.ToolStripMenuItem zatvorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem naposledyOtvorenéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zobraziťToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem výpisRámcovToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem výpisKomunikácieToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem statusStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocníkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem oProgrameToolStripMenuItem;
        private System.Windows.Forms.ListBox paketylistBox;

    }
}

