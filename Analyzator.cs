using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SietovyAnalyzator
{
    public partial class analyzator : Form
    {

        int vybranyZaznam = -1;
        Data data;
        Vrstva1 vrstva1;
        public analyzator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            data = new Data();
            vrstva1 = new Vrstva1(data);
            dtgTabulka.DataSource = data.vratTabulku();
            txtHexPole.DataBindings.Add("Text", data.vratTabulku(), "paket");  
        }

        private void btnOtvorit_Click(object sender, EventArgs e)
        {
            
            if (dlgSubor.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {

                    vrstva1.otvorZariadenie(dlgSubor.FileName);

                    txtAdresa.Text = dlgSubor.FileName;
                    this.Text = "Sieťový analyzátor - " + dlgSubor.SafeFileName;
                }
                catch (Exception ex)
                {
                    txtAdresa.Text = "";
                    this.Text = "Sieťový analyzátor";
                    MessageBox.Show("Pri otváraní súboru nastala chyba. \n Súbor neexistuje alebo je poškodený. \n\n" + ex.Message, "Chyba pri otváraní súboru", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dtgTabulka_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            vybranyZaznam = e.RowIndex;
        }
    }
}
