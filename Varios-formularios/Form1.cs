using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Varios_formularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            if(txtBoxNomes.Text == "")
            {

                MessageBox.Show("Por favor insira um nome no campo!!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxNomes.Focus();
                return;
            }
            txtBoxMultiLines.Text += txtBoxNomes.Text + " ,";
            txtBoxNomes.Clear();
            txtBoxNomes.Focus();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            txtBoxNomes.Clear();
            txtBoxMultiLines.Clear();
            txtBoxNomes.Focus();
        }

        private void buttonSegundoForm_Click(object sender, EventArgs e)
        {
            form2 formSegundo = new form2(txtBoxMultiLines.Text);
            formSegundo.ShowDialog();
        }
    }
}
