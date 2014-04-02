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
            this.dtgRamce = new System.Windows.Forms.DataGridView();
            this.txtHexPole = new System.Windows.Forms.TextBox();
            this.staBar = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.bgbNacitaj = new System.Windows.Forms.ToolStripProgressBar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lstProtokoly = new System.Windows.Forms.ListBox();
            this.dtgKomunikacie = new System.Windows.Forms.DataGridView();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lstIPcky = new System.Windows.Forms.ListBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.súborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otvoritToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zatvorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.naposledyOtvorenéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.koniecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zobraziťToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.výpisRámcovToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.výpisKomunikácieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocníkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.oProgrameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.dlgSubor = new System.Windows.Forms.OpenFileDialog();
            this.dtgRamceKomunikacia = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRamce)).BeginInit();
            this.staBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKomunikacie)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRamceKomunikacia)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgRamce
            // 
            this.dtgRamce.AllowUserToAddRows = false;
            this.dtgRamce.AllowUserToDeleteRows = false;
            this.dtgRamce.AllowUserToResizeRows = false;
            this.dtgRamce.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgRamce.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgRamce.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgRamce.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRamce.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgRamce.Location = new System.Drawing.Point(168, 27);
            this.dtgRamce.MultiSelect = false;
            this.dtgRamce.Name = "dtgRamce";
            this.dtgRamce.ReadOnly = true;
            this.dtgRamce.RowHeadersVisible = false;
            this.dtgRamce.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgRamce.Size = new System.Drawing.Size(547, 158);
            this.dtgRamce.TabIndex = 0;
            this.dtgRamce.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTabulka_RowEnter);
            // 
            // txtHexPole
            // 
            this.txtHexPole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHexPole.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtHexPole.Location = new System.Drawing.Point(0, 0);
            this.txtHexPole.Multiline = true;
            this.txtHexPole.Name = "txtHexPole";
            this.txtHexPole.ReadOnly = true;
            this.txtHexPole.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtHexPole.Size = new System.Drawing.Size(366, 166);
            this.txtHexPole.TabIndex = 3;
            this.txtHexPole.WordWrap = false;
            this.txtHexPole.Resize += new System.EventHandler(this.txtHexPole_Resize);
            // 
            // staBar
            // 
            this.staBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.bgbNacitaj});
            this.staBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.staBar.Location = new System.Drawing.Point(0, 390);
            this.staBar.Name = "staBar";
            this.staBar.Size = new System.Drawing.Size(727, 22);
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
            this.bgbNacitaj.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
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
            this.splitContainer1.Panel1.Controls.Add(this.lstProtokoly);
            this.splitContainer1.Panel1.Controls.Add(this.dtgKomunikacie);
            this.splitContainer1.Panel1.Controls.Add(this.txtAdresa);
            this.splitContainer1.Panel1.Controls.Add(this.lblAdresa);
            this.splitContainer1.Panel1.Controls.Add(this.lstIPcky);
            this.splitContainer1.Panel1.Controls.Add(this.dtgRamce);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip);
            this.splitContainer1.Panel1MinSize = 100;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.checkBox1);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.numericUpDown);
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2MinSize = 150;
            this.splitContainer1.Size = new System.Drawing.Size(727, 390);
            this.splitContainer1.SplitterDistance = 188;
            this.splitContainer1.TabIndex = 5;
            // 
            // lstProtokoly
            // 
            this.lstProtokoly.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstProtokoly.FormattingEnabled = true;
            this.lstProtokoly.IntegralHeight = false;
            this.lstProtokoly.Location = new System.Drawing.Point(12, 27);
            this.lstProtokoly.Name = "lstProtokoly";
            this.lstProtokoly.Size = new System.Drawing.Size(150, 158);
            this.lstProtokoly.TabIndex = 6;
            this.lstProtokoly.Visible = false;
            this.lstProtokoly.SelectedIndexChanged += new System.EventHandler(this.lstProtokoly_SelectedIndexChanged);
            // 
            // dtgKomunikacie
            // 
            this.dtgKomunikacie.AllowUserToAddRows = false;
            this.dtgKomunikacie.AllowUserToDeleteRows = false;
            this.dtgKomunikacie.AllowUserToResizeRows = false;
            this.dtgKomunikacie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgKomunikacie.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgKomunikacie.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgKomunikacie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgKomunikacie.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgKomunikacie.Location = new System.Drawing.Point(168, 27);
            this.dtgKomunikacie.MultiSelect = false;
            this.dtgKomunikacie.Name = "dtgKomunikacie";
            this.dtgKomunikacie.ReadOnly = true;
            this.dtgKomunikacie.RowHeadersVisible = false;
            this.dtgKomunikacie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgKomunikacie.Size = new System.Drawing.Size(547, 158);
            this.dtgKomunikacie.TabIndex = 5;
            this.dtgKomunikacie.Visible = false;
            this.dtgKomunikacie.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgKomunikacie_RowEnter);
            // 
            // txtAdresa
            // 
            this.txtAdresa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtAdresa.Location = new System.Drawing.Point(12, 165);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.ReadOnly = true;
            this.txtAdresa.Size = new System.Drawing.Size(150, 20);
            this.txtAdresa.TabIndex = 4;
            // 
            // lblAdresa
            // 
            this.lblAdresa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Location = new System.Drawing.Point(12, 136);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(150, 26);
            this.lblAdresa.TabIndex = 3;
            this.lblAdresa.Text = "IP adresa s najväčším počtom\r\nodvysielaných bajtov:";
            // 
            // lstIPcky
            // 
            this.lstIPcky.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstIPcky.FormattingEnabled = true;
            this.lstIPcky.IntegralHeight = false;
            this.lstIPcky.Location = new System.Drawing.Point(12, 27);
            this.lstIPcky.Name = "lstIPcky";
            this.lstIPcky.Size = new System.Drawing.Size(150, 106);
            this.lstIPcky.TabIndex = 2;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.súborToolStripMenuItem,
            this.zobraziťToolStripMenuItem,
            this.pomocníkToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(727, 24);
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
            // otvoritToolStripMenuItem
            // 
            this.otvoritToolStripMenuItem.Name = "otvoritToolStripMenuItem";
            this.otvoritToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.otvoritToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.otvoritToolStripMenuItem.Text = "Otvor...";
            this.otvoritToolStripMenuItem.Click += new System.EventHandler(this.otvoritToolStripMenuItem_Click);
            // 
            // zatvorToolStripMenuItem
            // 
            this.zatvorToolStripMenuItem.Enabled = false;
            this.zatvorToolStripMenuItem.Name = "zatvorToolStripMenuItem";
            this.zatvorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zatvorToolStripMenuItem.Text = "Zatvor";
            this.zatvorToolStripMenuItem.Click += new System.EventHandler(this.zatvorToolStripMenuItem_Click);
            // 
            // naposledyOtvorenéToolStripMenuItem
            // 
            this.naposledyOtvorenéToolStripMenuItem.Name = "naposledyOtvorenéToolStripMenuItem";
            this.naposledyOtvorenéToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.naposledyOtvorenéToolStripMenuItem.Text = "Naposledy otvorené";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // koniecToolStripMenuItem
            // 
            this.koniecToolStripMenuItem.Name = "koniecToolStripMenuItem";
            this.koniecToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.koniecToolStripMenuItem.Text = "Koniec";
            this.koniecToolStripMenuItem.Click += new System.EventHandler(this.koniecToolStripMenuItem_Click);
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(170, 6);
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
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.Enabled = false;
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.pomocToolStripMenuItem.Text = "Pomocník programu Sieťový analyzátor";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(280, 6);
            // 
            // oProgrameToolStripMenuItem
            // 
            this.oProgrameToolStripMenuItem.Name = "oProgrameToolStripMenuItem";
            this.oProgrameToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.oProgrameToolStripMenuItem.Text = "O programe...";
            this.oProgrameToolStripMenuItem.Click += new System.EventHandler(this.oProgrameToolStripMenuItem_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(632, 176);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 17);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "automaticky";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(492, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Počet stĺpcov:";
            // 
            // numericUpDown
            // 
            this.numericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown.Enabled = false;
            this.numericUpDown.Location = new System.Drawing.Point(574, 175);
            this.numericUpDown.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(52, 20);
            this.numericUpDown.TabIndex = 19;
            this.numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
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
            this.splitContainer2.Panel1.Controls.Add(this.txtInfo);
            this.splitContainer2.Panel1MinSize = 200;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dtgRamceKomunikacia);
            this.splitContainer2.Panel2.Controls.Add(this.txtHexPole);
            this.splitContainer2.Panel2MinSize = 320;
            this.splitContainer2.Size = new System.Drawing.Size(703, 166);
            this.splitContainer2.SplitterDistance = 333;
            this.splitContainer2.TabIndex = 18;
            // 
            // txtInfo
            // 
            this.txtInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInfo.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtInfo.Location = new System.Drawing.Point(0, 0);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInfo.Size = new System.Drawing.Size(333, 166);
            this.txtInfo.TabIndex = 17;
            this.txtInfo.WordWrap = false;
            // 
            // dlgSubor
            // 
            this.dlgSubor.FileName = "openFileDialog1";
            // 
            // dtgRamceKomunikacia
            // 
            this.dtgRamceKomunikacia.AllowUserToAddRows = false;
            this.dtgRamceKomunikacia.AllowUserToDeleteRows = false;
            this.dtgRamceKomunikacia.AllowUserToResizeRows = false;
            this.dtgRamceKomunikacia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgRamceKomunikacia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgRamceKomunikacia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgRamceKomunikacia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRamceKomunikacia.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgRamceKomunikacia.Location = new System.Drawing.Point(0, 1);
            this.dtgRamceKomunikacia.MultiSelect = false;
            this.dtgRamceKomunikacia.Name = "dtgRamceKomunikacia";
            this.dtgRamceKomunikacia.ReadOnly = true;
            this.dtgRamceKomunikacia.RowHeadersVisible = false;
            this.dtgRamceKomunikacia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgRamceKomunikacia.Size = new System.Drawing.Size(366, 166);
            this.dtgRamceKomunikacia.TabIndex = 7;
            this.dtgRamceKomunikacia.Visible = false;
            this.dtgRamceKomunikacia.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgRamceKomunikacia_RowEnter);
            // 
            // NetworkAnalzyer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 412);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.staBar);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(550, 350);
            this.Name = "NetworkAnalzyer";
            this.Text = "Sieťový analyzátor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgRamce)).EndInit();
            this.staBar.ResumeLayout(false);
            this.staBar.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgKomunikacie)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgRamceKomunikacia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgRamce;
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
        private System.Windows.Forms.TextBox txtInfo;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListBox lstIPcky;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.ListBox lstProtokoly;
        private System.Windows.Forms.DataGridView dtgKomunikacie;
        private System.Windows.Forms.DataGridView dtgRamceKomunikacia;

    }
}

