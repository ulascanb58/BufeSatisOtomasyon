using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaBufeSatis
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
            int misir, bilet, su, cay, toplam;

            misir = Convert.ToInt16(txtMisir.Text);
            bilet = Convert.ToInt16(txtBilet.Text);
            su = Convert.ToInt16(txtSu.Text);
            cay = Convert.ToInt16(txtCay.Text);

            toplam = misir * 5 + bilet * 18 + su * 1 + cay * 2;

            lblToplam.Text = toplam.ToString() + " TL ";

            kasatutar = kasatutar + toplam;
            lblKasa.Text = kasatutar.ToString() + "TL";

           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtBilet.Text = "";
            txtCay.Text = "";
            txtMisir.Text = "";
            txtSu.Text = "";
            lblToplam.Text = "00 TL";
            txtMisir.Focus();
        }
    }
}
