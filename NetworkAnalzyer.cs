using System;
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

        Data data;
        NetworkInterfaceLayer vrstva1;
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
                //Put in the Name property whatever neccessery to retrive your data on click event
                ddit.Name = "recently" + i;
                //On-Click event
                ddit.Click += new EventHandler(naposledyOtvorene_Click);
                //Add the submenu to the parent menu
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
        }

        private void dtgTabulka_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void výpisRámcovToolStripMenuItem_Click(object sender, EventArgs e)
        {
            paketylistBox.Visible = false;
            txtHexPole.Visible = true;
            výpisRámcovToolStripMenuItem.Checked = true;
            výpisKomunikácieToolStripMenuItem.Checked = false;
        }

        private void výpisKomunikácieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            paketylistBox.Visible = true;
            txtHexPole.Visible = false;
            výpisRámcovToolStripMenuItem.Checked = false;
            výpisKomunikácieToolStripMenuItem.Checked = true;
        }

        private void statusStripMenuItem_Click(object sender, EventArgs e)
        {
            if (staBar.Visible)
                staBar.Visible = false;
            else
                staBar.Visible = true;
        }

        private void otvoritToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dlgSubor.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    Analysis a = new Analysis();
                    a.analyse(dlgSubor.FileName, 5);

                    Frame f = (Frame)a.communication[0];
                    MessageBox.Show("ID: " + f.Id + "\nLENGHT: " + f.networkInterface.Lenght + "\nLENGHT(PH): " + f.networkInterface.PhysicalLenght + "\nTYPE: " + f.networkInterface.Type + "\nD_MAC: " + f.networkInterface.DestinationMAC + "\nS_MAC: " + f.networkInterface.SourceMAC);


                    this.Text = "Sieťový analyzátor - " + dlgSubor.SafeFileName;
                    Properties.Settings.Default.RecentlyOpened.Remove(dlgSubor.FileName);
                    Properties.Settings.Default.RecentlyOpened.Add(dlgSubor.FileName);
                    loadRecentlyOpened();
                }
                catch (Exception ex)
                {
                    this.Text = "Sieťový analyzátor";
                    MessageBox.Show("Pri otváraní súboru nastala chyba. \n Súbor neexistuje alebo je poškodený. \n\n" + ex.Message, "Chyba pri otváraní súboru", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
