using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operações_Matemáticas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblResultadoAdicao.Visible = false;
            lblResultadoSub.Visible = false;
            lblResultadoMult.Visible = false;
            lblResultadoDiv.Visible = false;
        }

        private void btnCalcularAdicao_Click(object sender, EventArgs e)
        {
            int x, y, soma;
            int.TryParse(txtAdicao1.Text, out x);
            int.TryParse(txtAdicao2.Text, out y);
            soma = x + y;
            lblResultadoAdicao.Visible = true;
            lblResultadoAdicao.Text = Convert.ToString(soma);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x, y, sub;
            int.TryParse(txtSub1.Text, out x);
            int.TryParse(txtSub2.Text, out y);
            sub = x - y;
            lblResultadoSub.Visible = true;
            lblResultadoSub.Text = Convert.ToString(sub);
        }

        private void btnCalcularMult_Click(object sender, EventArgs e)
        {
            int x, y, mult;
            int.TryParse(txtMult1.Text, out x);
            int.TryParse(txtMul2.Text, out y);
            mult = x * y;
            lblResultadoMult.Visible = true;
            lblResultadoMult.Text = Convert.ToString(mult);
        }

        private void btnCalcularDiv_Click(object sender, EventArgs e)
        {
            int x, y, div;
            int.TryParse(txtDiv1.Text, out x);
            int.TryParse(txtDiv2.Text, out y);
            div = x / y;
            lblResultadoDiv.Visible = true;
            lblResultadoDiv.Text = Convert.ToString(div);
        }

        private void txtAdicao1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAdicao2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSub1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSub2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMult1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMul2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDiv1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDiv2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
