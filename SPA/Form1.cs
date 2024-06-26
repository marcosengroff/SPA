using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPA
{
    public partial class frmSpa : Form
    {
        public frmSpa()
        {
            InitializeComponent();
        }

        void LimparCheckBox()
        {
            cbxMassagem.Checked = false;
            cbxMeditacao.Checked = false;
            cbxLimpeza.Checked = false;
            cbxPodologia.Checked = false;
        }

        private void txtInicial_KreyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsPunctuation(e.KeyChar))
                e.Handled = true;
        }

        private void frmSpa_Load(object sender, EventArgs e)
        {
            txtMassagem.Text = "134";
            txtMeditacao.Text = 20.ToString();
            txtLimpeza.Text = Convert.ToString (50);
            txtPodologia.Text = 30 + "";
        }

        private void txtInicial_TextChanged(object sender, EventArgs e)
        {
            if (txtInicial.Text == "") 
            txtInicial.Text = 0.ToString();

            else
            {
                LimparCheckBox();
                txtFinal.Text = txtInicial.Text;
            }
           
        }

        private void cbxMassagem_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxMassagem.Checked == true)
                txtFinal.Text = (Convert.ToDecimal(txtFinal.Text) + Convert.ToDecimal(txtMassagem.Text)).ToString();
           
            else txtFinal.Text = (Convert.ToDecimal(txtFinal.Text) - Convert.ToDecimal(txtMassagem.Text)).ToString();

        }

        private void cbxMeditacao_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxMeditacao.Checked == true)
                txtFinal.Text = (Convert.ToDecimal(txtFinal.Text) + Convert.ToDecimal(txtMeditacao.Text)).ToString();

            else txtFinal.Text = (Convert.ToDecimal(txtFinal.Text) - Convert.ToDecimal(txtMeditacao.Text)).ToString();
        }

        private void cbxLimpeza_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxLimpeza.Checked == true)
                txtFinal.Text = (Convert.ToDecimal(txtFinal.Text) + Convert.ToDecimal(txtLimpeza.Text)).ToString();

            else txtFinal.Text = (Convert.ToDecimal(txtFinal.Text) - Convert.ToDecimal(txtLimpeza.Text)).ToString();
        }

        private void cbxPodologia_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxPodologia.Checked == true)
                txtFinal.Text = (Convert.ToDecimal(txtFinal.Text) + Convert.ToDecimal(txtPodologia.Text)).ToString();

            else txtFinal.Text = (Convert.ToDecimal(txtFinal.Text) - Convert.ToDecimal(txtPodologia.Text)).ToString();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtInicial.Text = 0.ToString();
            txtFinal.Text = 0.ToString();
            LimparCheckBox();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}
