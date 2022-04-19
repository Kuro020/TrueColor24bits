﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrueColor24bits
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void hsbRed_Scroll(object sender, ScrollEventArgs e)
        {
            tbxRed.Text = hsbRed.Value.ToString();
            TrocaCor();
        }

        private void hsbGreen_Scroll(object sender, ScrollEventArgs e)
        {
            tbxGreen.Text = hsbGreen.Value.ToString();
            TrocaCor();
        }

        private void hsbBlue_Scroll(object sender, ScrollEventArgs e)
        {
            tbxBlue.Text = hsbBlue.Value.ToString();
            TrocaCor();
        }

        private void TrocaCor()
        {
            lblCores.BackColor = Color.FromArgb(
                hsbRed.Value,hsbGreen.Value,hsbBlue.Value
                );
        }

        private void lblCores_Click(object sender, EventArgs e)
        {
            
        }
    }
}
