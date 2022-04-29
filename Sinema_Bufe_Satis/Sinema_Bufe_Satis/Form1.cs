using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Bufe_Satis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, bilet, su, kola, tpl;

            misir = Convert.ToInt32(txtMsr.Text);
            bilet = Convert.ToInt32(txtBlt.Text);
            su = Convert.ToInt32(txtSu.Text);
            kola = Convert.ToInt32(txtKla.Text);

            tpl = misir * 15 + bilet * 35 + su * 5 + kola * 15;

            lblTpl.Text = tpl.ToString()+ " TL";

            kasatutar = kasatutar + tpl;

            lblKasa.Text = kasatutar.ToString() + " TL";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtBlt.Text = " ";
            txtSu.Text = " ";
            txtKla.Text = " ";
            txtMsr.Text = " ";
            txtMsr.Focus();
        }
    }
}
