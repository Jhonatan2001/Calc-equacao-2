using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Matematica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //caixa para a confirmação do fechamento
            DialogResult fechar = MessageBox.Show("Deseja realmente fechar?", "Confirmação de encerramento.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (fechar == DialogResult.No)
            {
                //para sair
            }
            else
            {
                Application.ExitThread();
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double a, b, c, total;
            double x1, x2, xv, yv;

            try
            {

            a= Convert.ToInt32(txtA.Text);
            b = Convert.ToInt32(txtB.Text);
            c = Convert.ToInt32(txtC.Text);

            total = (b * b) - (4 * a * c);


            x1 = ((-(b)) + (Math.Sqrt(total))) / (2 * a);
            x2 = ((-(b)) - (Math.Sqrt(total))) / (2 * a);
            xv = (-(b)) / (2 * a);
            yv = (-(total)) / (4 * a);

            lblX1.Text = "X1 : " + x1.ToString("0.00");
            lblX2.Text = "X2 : " + x2.ToString("0.00");
            lblXv.Text = "Xv : " + xv.ToString("0.00");
            lblYv.Text = "Yv : " + yv.ToString("0.00");
            lblDelta.Text = "Δ : " + total.ToString();

            }
            catch (Exception)
            {
                DialogResult fechar = MessageBox.Show("Insira valores válidos.", "ERRO.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (fechar == DialogResult.OK)
                {
                    limpar();//para limpar
                }
                else
                {
                  
                }
            }
        }
         public void limpar()
        {
            lblX1.Text = "X1 : ";
            lblX2.Text = "X2 : ";
            lblXv.Text = "Xv : ";
            lblYv.Text = "Yv : ";
            lblDelta.Text = "Δ : ";

            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void lblHora_Click(object sender, EventArgs e)
        {
            
        }

        private void Hora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
