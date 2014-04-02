using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkAnalzyer
{
    public partial class NetworkAnalzyer : Form
    {

        Analysis analysis;
        public NetworkAnalzyer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //data = new Data();
            //vrstva1 = new NetworkInterfaceLayer();
            //dtgTabulka.DataSource = data.vratTabulku();
            //txtHexPole.DataBindings.Add("Text", data.vratTabulku(), "paket");
            analysis = new Analysis();
            loadRecentlyOpened();
        }

        private void loadRecentlyOpened()
        {
            if (Properties.Settings.Default.RecentlyOpened.Count > 5)
                Properties.Settings.Default.RecentlyOpened.RemoveAt(0);
            naposledyOtvorenéToolStripMenuItem.DropDownItems.Clear();
            int i=0;
            foreach (string adr in Properties.Settings.Default.RecentlyOpened)
            {
                ToolStripItem ddit = new ToolStripMenuItem();
                ddit.Text = i + " " + adr;
                ddit.Name = "recently" + i;
                ddit.Click += new EventHandler(naposledyOtvorene_Click);
                naposledyOtvorenéToolStripMenuItem.DropDownItems.Add(ddit);
                i++;
            }
            if (naposledyOtvorenéToolStripMenuItem.DropDownItems.Count == 0)
                naposledyOtvorenéToolStripMenuItem.Enabled = false;
            else
                naposledyOtvorenéToolStripMenuItem.Enabled = true;
        }

        private void naposledyOtvorene_Click(object sender, EventArgs e)
        {
            ToolStripItem t = (ToolStripItem)sender;
            string adr = t.Text.Split(' ')[0];

            otvor(Properties.Settings.Default.RecentlyOpened[Int32.Parse(adr)]);
        }

        private void výpisRámcovToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dtgRamceKomunikacia.Visible = false;
            lstProtokoly.Visible = false;
            dtgKomunikacie.Visible = false;
            lstIPcky.Visible = true;
            txtHexPole.Visible = true;
            dtgRamce.Visible = true;
            txtAdresa.Visible = true;
            lblAdresa.Visible = true;
            výpisRámcovToolStripMenuItem.Checked = true;
            výpisKomunikácieToolStripMenuItem.Checked = false;
            analyzujRamce();
        }

        private void výpisKomunikácieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dtgRamceKomunikacia.Visible = true;
            lstProtokoly.Visible = true;
            dtgKomunikacie.Visible = true;
            lstIPcky.Visible = false;
            txtHexPole.Visible = false;
            dtgRamce.Visible = false;
            txtAdresa.Visible = false;
            lblAdresa.Visible = false;
            výpisRámcovToolStripMenuItem.Checked = false;
            výpisKomunikácieToolStripMenuItem.Checked = true;
            analyzujKomunikaciu();
        }

        private void statusStripMenuItem_Click(object sender, EventArgs e)
        {
            if (staBar.Visible)
            {
                staBar.Visible = false;
                statusStripMenuItem.Checked = false;
            }
            else
            {
                staBar.Visible = true;
                statusStripMenuItem.Checked = true;
            }
        }

        private void analyzujRamce()
        {
            dtgRamce.DataSource = analysis.getDataTableFrames();
            dtgRamce.AutoResizeColumns();
            dtgRamce.Columns[dtgRamce.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            lstIPcky.DataSource = analysis.getIPList();
            txtAdresa.Text = analysis.getMaxIP();

        }

        private void analyzujKomunikaciu()
        {
            dtgKomunikacie.DataSource = analysis.getDataTableCommunications(80);
            dtgKomunikacie.AutoResizeColumns();
            dtgKomunikacie.Columns[dtgRamce.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            lstProtokoly.DataSource = analysis.getProtocols();
        }

        private void otvor(string cesta)
        {
            lblStatus.Text = "Pracujem...";
            bgbNacitaj.Visible = true;
            zatvorToolStripMenuItem_Click(this, new EventArgs());
            analysis.analyse(cesta, 0);
            if (výpisRámcovToolStripMenuItem.Checked)
                analyzujRamce();
            else
                analyzujKomunikaciu();

            analyzujRamce();
            this.Text = "Sieťový analyzátor - " + Path.GetFileName (cesta);
            Properties.Settings.Default.RecentlyOpened.Remove(cesta);
            Properties.Settings.Default.RecentlyOpened.Add(cesta);
            loadRecentlyOpened();
            lblStatus.Text = "Pripravený";
            bgbNacitaj.Visible = false;
            zatvorToolStripMenuItem.Enabled = true;
        }

        private void otvoritToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dlgSubor.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    otvor(dlgSubor.FileName);
                }
                catch (Exception ex)
                {
                    bgbNacitaj.Visible = false;
                    this.Text = "Sieťový analyzátor";
                    MessageBox.Show("Pri otváraní súboru nastala chyba. \n Súbor neexistuje alebo je poškodený. \n\n" + ex.Message, "Chyba pri otváraní súboru", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblStatus.Text = "Pripravený";
                }
            }

        }

        private string formatuj(string s)
        {
            int pocetStlpcov;
            if (checkBox1.Checked)
                pocetStlpcov = txtHexPole.Width / 182;
            else
                pocetStlpcov = (int)numericUpDown.Value;

            s = s.Replace("  ", "-");
            s = s.Replace(Environment.NewLine, "-");
            StringBuilder sb = new StringBuilder(s);
            for (int i= 23; i < s.Length; i += 24)
            {
                sb[i] = ' ';
                if (i % (24 * pocetStlpcov) == (24*pocetStlpcov-1))
                   sb[i] = '*';
            }
            s = sb.ToString();
            s = s.Replace(" ","  ");
            s = s.Replace("*", Environment.NewLine);
            return s;
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            txtHexPole.Text = formatuj(txtHexPole.Text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                numericUpDown.Enabled = false;
            else
                numericUpDown.Enabled = true;

            txtHexPole.Text = formatuj(txtHexPole.Text);
        }

        private void txtHexPole_Resize(object sender, EventArgs e)
        {
            txtHexPole.Text = formatuj(txtHexPole.Text);
        }

        private void zatvorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            analysis = new Analysis();
            lstIPcky.DataSource = null;
            dtgRamce.DataSource = null;
            txtInfo.Text = "";
            txtHexPole.Text = "";
            zatvorToolStripMenuItem.Enabled = false;
        }

        private void koniecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void oProgrameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }

        private void lstProtokoly_SelectedIndexChanged(object sender, EventArgs e)
        {
            int protocol=0;
            switch(lstProtokoly.SelectedIndex)
            {
                case 0:
                    protocol = 80;
                    break;
                case 1:
                    protocol = 443;
                    break;
                case 2:
                    protocol = 23;
                    break;
                case 3:
                    protocol = 22;
                    break;
                case 4:
                    protocol = 21;
                    break;
                case 5:
                    protocol = 20;
                    break;
                case 6:
                    protocol = 69;
                    break;
                case 7:
                    protocol = 1;
                    break;
                case 8:
                    protocol = 2054;
                    break;
                default:
                    break;
            }
            dtgKomunikacie.DataSource = analysis.getDataTableCommunications(protocol);
        }

        private void dtgRamceKomunikacia_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtInfo.Text = analysis.getFrameInfo((int)dtgRamceKomunikacia.Rows[e.RowIndex].Cells[0].Value - 1);
        }

        private void dtgKomunikacie_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dtgRamceKomunikacia.DataSource = analysis.getFrameList((int)dtgRamce.Rows[e.RowIndex].Cells[0].Value - 1);
            dtgRamceKomunikacia.Update();
        }

        private void dtgTabulka_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            string s = BitConverter.ToString(analysis.getFrame(e.RowIndex).Raw);
            txtHexPole.Text = formatuj(s);
            txtInfo.Text = analysis.getFrameInfo((int)dtgRamce.Rows[e.RowIndex].Cells[0].Value - 1);

        }

    }
}
